using BackOfficeAudit;
using BackOfficeDAL;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace BackOfficeBL.Accounting
{

    public class AccountCategory
    {
        public int CategoryId { get; set; }
        public string Name { get { return GetAccountCategoryName(); } }
        public bool IsDisableCategory { get; set; }
        public string CategoryName_Ara { get; set; }
        public string CategroyName_Eng { get; set; }
        public bool IsNew { get; set; }

        public static List<AccountCategory> GetAllAccountCategory()
        {
            List<AccountCategory> result = new List<AccountCategory>();
            NewAppsCnn newAppsCnn = new NewAppsCnn(AppSettings.CrAppSettings.NewAppsConnectionString);
            var dbAccountCategorys = from g in newAppsCnn.Acc_AccountCategory select g;
            foreach (var dbAccountCategory in dbAccountCategorys)
            {
                AccountCategory accountcategory = new AccountCategory();
                accountcategory.FromDbAccountCategory(dbAccountCategory);
                result.Add(accountcategory);
            }
            return result;
        }

        public AccountCategory()
        {
            this.IsNew = true;
        }

        private string GetAccountCategoryName()
        {
            CultureInfo cultureinfo = CultureInfo.CurrentUICulture;
            switch (cultureinfo.Name)
            {
                case "en-US":
                    return this.CategroyName_Eng;
                case "ar-KW":
                    return this.CategoryName_Ara;
                default:
                    return this.CategroyName_Eng;
            }
        }

        public void FromDbAccountCategory(Acc_AccountCategory _dbAccountCategory)
        {
            this.CategoryId = _dbAccountCategory.CategoryId;
            this.CategoryName_Ara = _dbAccountCategory.CategoryName_Ara;
            this.CategroyName_Eng = _dbAccountCategory.CategroyName_Eng;
            this.IsDisableCategory = _dbAccountCategory.IsDisableCategory;
            this.IsNew = false;
        }

        public void ToDbAccountCategory(Acc_AccountCategory _dbAccountCategory)
        {
            _dbAccountCategory.CategoryId = this.CategoryId;
            _dbAccountCategory.CategoryName_Ara = this.CategoryName_Ara;
            _dbAccountCategory.CategroyName_Eng = this.CategroyName_Eng;
            _dbAccountCategory.IsDisableCategory = this.IsDisableCategory;
        }

        public DataSaveResult Save()
        {
            Acc_AccountCategory dbAccountCategory;
            try
            {
                NewAppsCnn newAppsCnn = new NewAppsCnn(AppSettings.CrAppSettings.NewAppsConnectionString);
                var dbAccountCategorys = from u in newAppsCnn.Acc_AccountCategory where u.CategoryId == this.CategoryId select u;
                if (dbAccountCategorys.Count() > 0)
                {
                    dbAccountCategory = dbAccountCategorys.First();
                    this.ToDbAccountCategory(dbAccountCategory);
                }
                else
                {
                    dbAccountCategory = new Acc_AccountCategory();
                    this.ToDbAccountCategory(dbAccountCategory);
                    newAppsCnn.Acc_AccountCategory.Add(dbAccountCategory);
                }
                newAppsCnn.SaveChanges();
                Audit.AddDataAudit(Audit.AuditActionTypes.AddNew, "Acc_AccountCategory", this);
                this.FromDbAccountCategory(dbAccountCategory);
                return new DataSaveResult() { SaveStatus = true };
            }
            catch (Exception ex)
            {
                return new DataSaveResult() { SaveStatus = false };
            }
        }

        public DataDeleteResult Delete()
        {
            Acc_AccountCategory dbAccountCategory;
            try
            {
                NewAppsCnn newAppsCnn = new NewAppsCnn(AppSettings.CrAppSettings.NewAppsConnectionString);
                var dbAccountCategorys = from u in newAppsCnn.Acc_AccountCategory where u.CategoryId == this.CategoryId select u;
                if (dbAccountCategorys.Count() > 0)
                {
                    dbAccountCategory = dbAccountCategorys.First();
                    newAppsCnn.Acc_AccountCategory.Remove(dbAccountCategory);
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
