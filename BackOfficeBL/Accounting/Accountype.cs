using BackOfficeAudit;
using BackOfficeDAL;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace BackOfficeBL.Accounting
{
    public class Accounttype
    {
        public int TypeID { get; set; }
        public string Name { get { return GetAccounttypeName(); } }
        public bool IsDisable { get; set; }
        public string TypeName_Ara { get; set; }
        public string TypeName_Eng { get; set; }
        public bool IsNew { get; set; }

        public static List<Accounttype> GetAllAccounttype()
        {
            List<Accounttype> result = new List<Accounttype>();
            NewAppsCnn newAppsCnn = new NewAppsCnn(AppSettings.CrAppSettings.NewAppsConnectionString);
            var dbAccounttypes = from g in newAppsCnn.Acc_Accountype select g;
            foreach (var dbAccounttype in dbAccounttypes)
            {
                Accounttype accounttype = new Accounttype();
                accounttype.FromDbAccounttype(dbAccounttype);
                result.Add(accounttype);
            }
            return result;
        }

        public static Accounttype FindByAccounttypeID(int _VaidationID)
        {
            NewAppsCnn newAppsCnn = new NewAppsCnn(AppSettings.CrAppSettings.NewAppsConnectionString);
            var dbAccounttypes = from u in newAppsCnn.Acc_Accountype where u.TypeID == _VaidationID select u;
            if (dbAccounttypes.Count() > 0)
            {
                Acc_Accountype dbAccounttype = dbAccounttypes.First();
                Accounttype accounttype = new Accounttype();
                accounttype.FromDbAccounttype(dbAccounttype);
                accounttype.IsNew = false;
                return accounttype;
            }
            else
                return null;
        }
        public Accounttype()
        {
            this.IsNew = true;
        }

        private string GetAccounttypeName()
        {
            CultureInfo cultureinfo = CultureInfo.CurrentUICulture;
            switch (cultureinfo.Name)
            {
                case "en-US":
                    return this.TypeName_Eng;
                case "ar-KW":
                    return this.TypeName_Ara;
                default:
                    return this.TypeName_Eng;
            }
        }

        public void FromDbAccounttype(Acc_Accountype _dbAccounttype)
        {
            this.TypeID = _dbAccounttype.TypeID;
            this.TypeName_Ara = _dbAccounttype.TypeName_Ara;
            this.TypeName_Eng = _dbAccounttype.TypeName_Eng;
            this.IsDisable = _dbAccounttype.IsDisable;
            this.IsNew = false;
        }

        public void ToDbAccounttype(Acc_Accountype _dbAccounttype)
        {
            _dbAccounttype.TypeID = this.TypeID;
            _dbAccounttype.TypeName_Ara = this.TypeName_Ara;
            _dbAccounttype.TypeName_Eng = this.TypeName_Eng;
            _dbAccounttype.IsDisable = this.IsDisable;
        }

        public DataSaveResult Save()
        {
            Acc_Accountype dbAccounttype;
            try
            {
                NewAppsCnn newAppsCnn = new NewAppsCnn(AppSettings.CrAppSettings.NewAppsConnectionString);
                var dbAccounttypes = from u in newAppsCnn.Acc_Accountype where u.TypeID == this.TypeID select u;
                if (dbAccounttypes.Count() > 0)
                {
                    dbAccounttype = dbAccounttypes.First();
                    this.ToDbAccounttype(dbAccounttype);
                }
                else
                {
                    dbAccounttype = new Acc_Accountype();
                    this.ToDbAccounttype(dbAccounttype);
                    newAppsCnn.Acc_Accountype.Add(dbAccounttype);
                }
                newAppsCnn.SaveChanges();
                Audit.AddDataAudit(Audit.AuditActionTypes.AddNew, "Acc_Accountype", this);
                this.FromDbAccounttype(dbAccounttype);
                return new DataSaveResult() { SaveStatus = true };
            }
            catch (Exception ex)
            {
                return new DataSaveResult() { SaveStatus = false };
            }
        }

        public DataDeleteResult Delete()
        {
            Acc_Accountype dbAccounttype;
            try
            {
                NewAppsCnn newAppsCnn = new NewAppsCnn(AppSettings.CrAppSettings.NewAppsConnectionString);
                var dbAccounttypes = from u in newAppsCnn.Acc_Accountype where u.TypeID == this.TypeID select u;
                if (dbAccounttypes.Count() > 0)
                {
                    dbAccounttype = dbAccounttypes.First();
                    newAppsCnn.Acc_Accountype.Remove(dbAccounttype);
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
