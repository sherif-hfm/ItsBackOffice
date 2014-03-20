using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BackOfficeDAL;
using System.Globalization;
using BackOfficeBL.General;
using BackOfficeAudit;
using System.Xml.Serialization;
namespace BackOfficeBL.Security
{
    public class Group
    {
        public string GroupID { get; set; }
        public string Name { get { return GetGroupName(); } }
        public string Name_Ara { get; set; }
        public string Name_Eng { get; set; }
        public bool IsDisable { get; set; }
        [XmlIgnore]
        public bool IsNew { get; set; }
        [XmlIgnore]
        public List<User> Users = new List<User>();

        #region ************************** Static Methods **************************
        
        public static List<Group> GetAllGroups()
        {
            List<Group> result = new List<Group>();
            NewAppsCnn newAppsCnn = new NewAppsCnn(AppSettings.CrAppSettings.NewAppsConnectionString);
            var dbGroups = from g in newAppsCnn.Sec_Groups select g;
            foreach (var dbGroup in dbGroups)
            {
                Group group = new Group();
                group.FromDbGroup(dbGroup);
                result.Add(group);
            }
            return result;
        }

        public static Group GetGroup(MoveCommandEnum _moveCommand,Group _crGroup)
        {
            Sec_Groups dbGroup = null;
            NewAppsCnn newAppsCnn = new NewAppsCnn(AppSettings.CrAppSettings.NewAppsConnectionString);
            switch (_moveCommand)
            { 
                case MoveCommandEnum.MoveFirst:
                    dbGroup = newAppsCnn.Sec_Groups.FirstOrDefault();
                    break;
                case MoveCommandEnum.MovePrev:
                    if (_crGroup != null)
                        dbGroup = (from g in newAppsCnn.Sec_Groups where g.GroupID.CompareTo(_crGroup.GroupID) < 0 orderby g.GroupID descending select g).FirstOrDefault();
                    break;
                case MoveCommandEnum.MoveNext:
                    if (_crGroup != null)
                        dbGroup = (from g in newAppsCnn.Sec_Groups where g.GroupID.CompareTo(_crGroup.GroupID) > 0 orderby g.GroupID ascending select g).FirstOrDefault();
                    break;
                case MoveCommandEnum.MoveLast:
                    dbGroup = (from g in newAppsCnn.Sec_Groups orderby g.GroupID descending select g).FirstOrDefault();
                    break;
            }
            if (dbGroup != null)
            {
                Group group = new Group();
                group.FromDbGroup(dbGroup);
                group.LoadGroupUsers(dbGroup);
                return group;
            }
            else
                return null;
        }

        public static Group GetGroupByID(string groupID)
        {
            NewAppsCnn newAppsCnn = new NewAppsCnn(AppSettings.CrAppSettings.NewAppsConnectionString);
            var dbGroup = (from g in newAppsCnn.Sec_Groups where g.GroupID == groupID select g).FirstOrDefault();
            if (dbGroup != null)
            {
                Group group = new Group();
                group.FromDbGroup(dbGroup);
                group.LoadGroupUsers(dbGroup);
                return group;
            }
            else
                return null;
        }

        #endregion

        public Group()
        {
            this.IsNew = true;
        }

        public List<User> GetOutGroupUsers()
        {
            var usersIds = this.Users.Select(u => u.UserID);
            NewAppsCnn newAppsCnn = new NewAppsCnn(AppSettings.CrAppSettings.NewAppsConnectionString);
            var users = from u in newAppsCnn.Sec_Users
                        where usersIds.Contains(u.UserID)==false
                        select new User { UserID = u.UserID, Name_Ara = u.Name_Ara, Name_Eng = u.Name_Eng, IsAdmin = u.IsAdmin, Password = u.Password, UserLogin = u.UserLogin };
            if (users.Count() > 0)
                return users.ToList();
            else
                return new List<User>();
        }

        private string GetGroupName()
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

        public void FromDbGroup(Sec_Groups _dbGroup)
        {
            this.GroupID = _dbGroup.GroupID;
            this.Name_Ara = _dbGroup.Name_Ara;
            this.Name_Eng = _dbGroup.Name_Eng;
            this.IsDisable = _dbGroup.IsDisable;
            this.IsNew = false;
        }

        public void ToDbGroup(Sec_Groups _dbGroup)
        {
            _dbGroup.GroupID = this.GroupID;
            _dbGroup.Name_Ara = this.Name_Ara;
            _dbGroup.Name_Eng = this.Name_Eng;
            _dbGroup.IsDisable = this.IsDisable;
        }

        public void LoadGroupUsers(Sec_Groups _dbGroup)
        {
            Users.Clear();
            foreach (var dbUser in _dbGroup.Sec_Users)
            {
                User user = new User();
                user.FromDbUser(dbUser);
                Users.Add(user);
            }
        }

        public void SaveGroupUsers(Sec_Groups _dbGroup, NewAppsCnn newAppsCnn)
        {
            // Add New User To Group
            foreach (var user in Users)
            {
                var dbUsers = from u in _dbGroup.Sec_Users where u.UserID == user.UserID select u;
                if (dbUsers.Count() == 0)
                {
                    var dbUser = newAppsCnn.Sec_Users.First(u => u.UserID == user.UserID);
                    _dbGroup.Sec_Users.Add(dbUser);
                }
            }
            // Delete User Groups
            foreach (var dbUser in _dbGroup.Sec_Users.ToList())
            {
                var user = Users.Find(u => u.UserID == dbUser.UserID);
                if (user == null)
                {
                    _dbGroup.Sec_Users.Remove(dbUser);
                }
            }
        }

        public DataSaveResult Save()
        {
            Sec_Groups dbGroup;
            try
            {
                NewAppsCnn newAppsCnn = new NewAppsCnn(AppSettings.CrAppSettings.NewAppsConnectionString);
                dbGroup = (from g in newAppsCnn.Sec_Groups where g.GroupID == this.GroupID select g).FirstOrDefault();
                if (dbGroup == null)
                {
                    dbGroup = new Sec_Groups();
                    this.ToDbGroup(dbGroup);
                    newAppsCnn.Sec_Groups.Add(dbGroup);
                    SaveGroupUsers(dbGroup, newAppsCnn);
                    newAppsCnn.SaveChanges();
                }
                else
                {
                    this.ToDbGroup(dbGroup);
                    SaveGroupUsers(dbGroup, newAppsCnn);
                    newAppsCnn.SaveChanges();
                    Audit.AddDataAudit(Audit.AuditActionTypes.AddNew, "Sec_Groups", this);
                }
                this.FromDbGroup(dbGroup);
                return new DataSaveResult() { SaveStatus = true, ErrorMessage = "", Data = this };
            }
            catch (Exception ex)
            {
                return new DataSaveResult() { SaveStatus = false, ErrorMessage = ex.Message };
            }
        }

        public DataDeleteResult Delete()
        {
            try
            {
                NewAppsCnn newAppsCnn = new NewAppsCnn(AppSettings.CrAppSettings.NewAppsConnectionString);
                var dbGroup = (from g in newAppsCnn.Sec_Groups where g.GroupID == this.GroupID select g).FirstOrDefault();
                if (dbGroup != null)
                {
                    newAppsCnn.Sec_Groups.Remove(dbGroup);
                    newAppsCnn.SaveChanges();
                    return new DataDeleteResult() { DeleteStatus = true, ErrorMessage = "" };
                }
                else
                    return new DataDeleteResult() { DeleteStatus = false, ErrorMessage = "" };
            }
            catch (Exception ex)
            {
               return new DataDeleteResult() { DeleteStatus = false, ErrorMessage = ex.Message };
            }
        }
    }
}
