using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BackOfficeDAL;
using System.Globalization;
namespace BackOfficeBL.Security
{
    public class Group
    {
        public string GroupID { get; set; }
        public string Name { get { return GetGroupName(); } }
        public string Name_Ara { get; set; }
        public string Name_Eng { get; set; }
        public bool IsDisable { get; set; }
        public bool IsNew { get; set; }

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

        public Group()
        {
            this.IsNew = true;
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
    }
}
