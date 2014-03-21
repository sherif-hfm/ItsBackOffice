using BackOfficeAudit;
using BackOfficeDAL;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace BackOfficeBL.Security
{
    public class User
    {

        public int UserID { get; set; }
        public string UserLogin { get; set; }
        public string Name { get {return GetUserName(); } }
        public string Name_Ara { get; set; }
        public string Name_Eng { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsNew { get; set; }
        [XmlIgnore]
        public List<MenuItem> UserMenuItems = new List<MenuItem>();
        [XmlIgnore]
        public List<Group> Groups = new List<Group>();

        public User() 
        {
            this.IsNew = true;
        }

        #region ************************** Static Methods **************************

        public static User FindByUserID(int _userID)
        {
            NewAppsCnn newAppsCnn = new NewAppsCnn(AppSettings.CrAppSettings.NewAppsConnectionString);
            var dbUsers = from u in newAppsCnn.Sec_Users where u.UserID == _userID  select u;
            if (dbUsers.Count() > 0)
            {
                Sec_Users dbUser = dbUsers.First();
                User user = new User();
                user.FromDbUser(dbUser);
                user.LoadDbUserGroups(dbUser);
                return user;
            }
            else
                return null;
        }

        public static User CheckUser(string _userName,string _password)
        {
            try
            {
                NewAppsCnn newAppsCnn = new NewAppsCnn(AppSettings.CrAppSettings.NewAppsConnectionString);
                var dbUsers = from u in newAppsCnn.Sec_Users where u.UserLogin == _userName && u.Password == _password select u;
                if (dbUsers.Count() > 0)
                {
                    Sec_Users dbUser = dbUsers.First();
                    User user = new User();
                    user.FromDbUser(dbUser);
                    user.LoadUserMenu(dbUser);
                    return user;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        public static User GetFirst()
        {
            NewAppsCnn newAppsCnn = new NewAppsCnn(AppSettings.CrAppSettings.NewAppsConnectionString);
            var dbUser = newAppsCnn.Sec_Users.FirstOrDefault();
            if (dbUser != null)
            {
                User user = new User();
                user.FromDbUser(dbUser);
                user.LoadDbUserGroups(dbUser);
                return user;
            }
            else
                return null;
        }

        public static User GetLast()
        {
            NewAppsCnn newAppsCnn = new NewAppsCnn(AppSettings.CrAppSettings.NewAppsConnectionString);
            var dbUsers = from u in newAppsCnn.Sec_Users orderby u.UserID descending select u;
            if (dbUsers.Count() > 0)
            {
                var dbUser = dbUsers.FirstOrDefault();
                User user = new User();
                user.FromDbUser(dbUser);
                user.LoadDbUserGroups(dbUser);
                return user;
            }
            else
                return null;
        }

        public static User GetNext(User _user)
        {
            if (_user == null)
                return GetLast();
            NewAppsCnn newAppsCnn = new NewAppsCnn(AppSettings.CrAppSettings.NewAppsConnectionString);
            var dbUsers = from u in newAppsCnn.Sec_Users where u.UserID > _user.UserID orderby u.UserID ascending select u;
            if (dbUsers.Count() > 0)
            {
                var dbUser = dbUsers.FirstOrDefault();
                User user = new User();
                user.FromDbUser(dbUser);
                user.LoadDbUserGroups(dbUser);
                return user;
            }
            else
                return null;
        }

        public static User GetPrev(User _user)
        {
            if (_user == null)
                return GetFirst();
            NewAppsCnn newAppsCnn = new NewAppsCnn(AppSettings.CrAppSettings.NewAppsConnectionString);
            var dbUsers = from u in newAppsCnn.Sec_Users where u.UserID < _user.UserID orderby u.UserID descending select u;
            if (dbUsers.Count() > 0)
            {
                var dbUser = dbUsers.FirstOrDefault();
                User user = new User();
                user.FromDbUser(dbUser);
                user.LoadDbUserGroups(dbUser);
                return user;
            }
            else
                return null;
        }

        #endregion

        public string GetUserName()
        {
            CultureInfo cultureinfo = CultureInfo.CurrentUICulture;
            switch (cultureinfo.Name)
            {
                case "en-US":
                    return this.Name_Eng;
                case "ar-KW":
                    return this.Name_Ara;
                default:
                    return this.Name_Eng;
            }
        }

        private void LoadUserMenu(Sec_Users _dbUser)
        {
            if (_dbUser.IsAdmin == false)
                this.LoadUserMenuForUser(_dbUser);
            else
                this.LoadUserMenuForAdminUser(_dbUser);
        }

        private void LoadUserMenuForUser(Sec_Users _dbUser)
        {
            foreach (var dbGroup in _dbUser.Sec_Groups)
            {
                foreach (var dbGroupRight in dbGroup.Sec_GroupRights)
                {
                    MenuItem menuItem = new MenuItem();
                    menuItem.FromDbMenuItem(dbGroupRight.Sec_MainMenu);
                    menuItem.FormAllowedFunctions = menuItem.FormAllowedFunctions & dbGroupRight.AllowedFunctions;
                    var existMenuItem = this.UserMenuItems.Find(m => m.MenuID == menuItem.MenuID);
                    if (existMenuItem == null)
                        this.UserMenuItems.Add(menuItem);
                    else
                    {
                        existMenuItem.FormAllowedFunctions = existMenuItem.FormAllowedFunctions & dbGroupRight.AllowedFunctions;
                    }
                }
            }
        }

        private void LoadUserMenuForAdminUser(Sec_Users _dbUser)
        {
            NewAppsCnn newAppsCnn = new NewAppsCnn(AppSettings.CrAppSettings.NewAppsConnectionString);
            var dbMenuItems = from m in newAppsCnn.Sec_MainMenu select m;
            foreach (var dbMenuItem in dbMenuItems)
            {
                MenuItem menuItem = new MenuItem();
                menuItem.FromDbMenuItem(dbMenuItem);
                this.UserMenuItems.Add(menuItem);
            }
        }

        public void FromDbUser(Sec_Users _dbUser)
        {
            this.UserID = _dbUser.UserID;
            this.UserLogin = _dbUser.UserLogin;
            this.Name_Ara = _dbUser.Name_Ara;
            this.Name_Eng = _dbUser.Name_Eng;
            this.Password = _dbUser.Password;
            this.IsAdmin = _dbUser.IsAdmin;
            this.IsNew = false;
            
        }

        public void LoadDbUserGroups(Sec_Users _dbUser)
        {
            Groups.Clear();
            foreach (var dbGroup in _dbUser.Sec_Groups)
            {
                Group group = new Group();
                group.FromDbGroup(dbGroup);
                this.Groups.Add(group);
            }
        }

        public void SaveDbUserGroups(Sec_Users _dbUser, NewAppsCnn newAppsCnn)
        {
            // Add New User Groups
            foreach (var group in this.Groups)
            {
                var dbUserGroups = _dbUser.Sec_Groups.Where(g => g.GroupID == group.GroupID);
                if (dbUserGroups.Count() == 0)
                {
                    var dbGroup = newAppsCnn.Sec_Groups.First(g => g.GroupID == group.GroupID);
                    _dbUser.Sec_Groups.Add(dbGroup);
                }
            }
            // Delete User Groups
            foreach (var dbGroup in _dbUser.Sec_Groups.ToList())
            {
                var group = this.Groups.Find(g => g.GroupID == dbGroup.GroupID);
                if (group == null)
                    _dbUser.Sec_Groups.Remove(dbGroup);
            }
        }

        public void ToDbUser(Sec_Users _dbUser)
        {
            _dbUser.UserLogin = this.UserLogin;
            _dbUser.Name_Ara = this.Name_Ara;
            _dbUser.Name_Eng = this.Name_Eng;
            _dbUser.Password = this.Password;
            _dbUser.IsAdmin = this.IsAdmin;
        }

        public DataSaveResult Save()
        {
            Sec_Users dbUser;
            try
            {
                NewAppsCnn newAppsCnn = new NewAppsCnn(AppSettings.CrAppSettings.NewAppsConnectionString);
                var dbUsers = from u in newAppsCnn.Sec_Users where u.UserID == this.UserID select u;
                if (dbUsers.Count() > 0)
                {
                    dbUser = dbUsers.First();
                    this.ToDbUser(dbUser);
                    this.SaveDbUserGroups(dbUser, newAppsCnn);
                }
                else
                {
                    dbUser = new Sec_Users();
                    this.ToDbUser(dbUser);
                    this.SaveDbUserGroups(dbUser,newAppsCnn);
                    newAppsCnn.Sec_Users.Add(dbUser);
                }
                newAppsCnn.SaveChanges();
                Audit.AddDataAudit(Audit.AuditActionTypes.AddNew, "Sec_Users", this);
                this.FromDbUser(dbUser);
                return new DataSaveResult() { SaveStatus = true };
            }
            catch (Exception ex)
            {
                return new DataSaveResult() { SaveStatus = false };
            }
        }

        public DataDeleteResult Delete()
        {
            Sec_Users dbUser;
            try
            {
                NewAppsCnn newAppsCnn = new NewAppsCnn(AppSettings.CrAppSettings.NewAppsConnectionString);
                var dbUsers = from u in newAppsCnn.Sec_Users where u.UserID == this.UserID select u;
                if (dbUsers.Count() > 0)
                {
                    dbUser = dbUsers.First();
                    newAppsCnn.Sec_Users.Remove(dbUser);
                    newAppsCnn.SaveChanges();
                }
                return new DataDeleteResult() { DeleteStatus = true };
            }
            catch (Exception ex)
            {
                return new DataDeleteResult() { DeleteStatus = false, ErrorMessage = ex.Message };
            }
        }

        
    }
}
