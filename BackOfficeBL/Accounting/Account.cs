using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BackOfficeDAL;
using System.Globalization;
using BackOfficeAudit;

namespace BackOfficeBL.Accounting
{
    public class Account
    {
        public string AccountID { get; set; }
        public string Name { get { return GetAccountName(); } }
        public string NameAndNo { get { return GetAccountNameAndNo(); } }
        public bool IsDisable { get; set; }
        public string AccountName_Ar { get; set; }
        public string AccountName_Eng { get; set; }

        public string AccountRef1 { get; set; }
        public string AccountRef2 { get; set; }

        public int AccountTypeId { get; set; }
        public int AccountLevel { get; set; }
        public int? AccountCategoryId { get; set; }
        public bool IsSubAccount { get; set; }
        public bool IsDisableAccount { get; set; }
        public string ParentId { get; set; }
        public bool IsNew { get; set; }
        public bool IsCopy { get; set; }

        public static string getNewId(string ParentId, bool IsSubAccount)
        {
            string AccountId = "";
            NewAppsCnn newAppsCnn = new NewAppsCnn(AppSettings.CrAppSettings.NewAppsConnectionString);
            var dbAccounts = from g in newAppsCnn.Acc_Accounts where g.AccountID != null || g.AccountID != "" select g;
            if (ParentId == null || ParentId == "")
            {
                var PChild = (from ac in dbAccounts where ac.ParentId == "" || ac.ParentId == null select ac).ToList();
                AccountId = string.Format("{0}", PChild.Count + 1);
            }
            else if (IsSubAccount)
            {
                char[] array = new char[6];
                var PrntVal = FindByAccountID(ParentId);
                var PChild = (from ac in dbAccounts where ac.ParentId == ParentId && ac.IsSubAccount == IsSubAccount select ac).ToList();

                int ArrCount = 0;
                string NwId = (PChild.Count + 1).ToString();
                for (int idx = array.Length - 1; idx > -1; idx--)
                {
                    if (ArrCount < NwId.Length)
                    {
                        array[idx] = NwId[ArrCount];
                        ArrCount++;
                    }
                    else
                    {
                        array[idx] = '0';
                    }
                }
                AccountId = string.Format("{0}{1}", ParentId, (new string(array)));
            }
            else
            {
                char[] array = new char[2];
                var PrntVal = FindByAccountID(ParentId);
                var PChild = (from ac in dbAccounts where ac.ParentId == ParentId select ac).ToList();
                int ArrCount = 0;
                string NwId=(PChild.Count + 1).ToString();
                for (int idx = array.Length - 1; idx > -1; idx--)
                {
                    if (ArrCount < NwId.Length)
                    {
                        array[idx] = NwId[ArrCount];
                        ArrCount++;
                    }
                    else
                    {
                        array[idx] = '0';
                    }
                }
                AccountId = string.Format("{0}{1}", ParentId, (new string(array)));
            }
            return AccountId;
        }

        public static List<Account> GetAllAccountTree()
        {
            List<Account> result = new List<Account>();
            NewAppsCnn newAppsCnn = new NewAppsCnn(AppSettings.CrAppSettings.NewAppsConnectionString);
            var dbAccounts = from g in newAppsCnn.Acc_Accounts where g.AccountID != null || g.AccountID != "" select g;
            foreach (var dbAccount in dbAccounts)
            {
                Account account = new Account();
                account.FromDbAccount(dbAccount);
                result.Add(account);
            }
            return result;
        }

        private static int getNodeLevel(int IntCount, string AccountId)
        {
            var CurrAccount = FindByAccountID(AccountId);
            
            if (CurrAccount==null)
            {
                return IntCount;
            }
            else if (CurrAccount.ParentId == null || CurrAccount.ParentId == "")
            {
                return ++IntCount;
            }
            else
            {
                return getNodeLevel(++IntCount, CurrAccount.ParentId);
            }
        }
        public static Account FindByAccountID(string _VaidationID)
        {
            NewAppsCnn newAppsCnn = new NewAppsCnn(AppSettings.CrAppSettings.NewAppsConnectionString);
            var dbAccounts = from u in newAppsCnn.Acc_Accounts where u.AccountID == _VaidationID select u;
            if (dbAccounts.Count() > 0)
            {
                Acc_Accounts dbAccount = dbAccounts.First();
                Account account = new Account();
                account.FromDbAccount(dbAccount);
                account.IsNew = false;
                account.IsCopy = false;
                return account;
            }
            else
                return null;
        }
        public Account()
        {
            this.IsNew = true;
            this.IsCopy = false;
        }

        private string GetAccountNameAndNo()
        {
            CultureInfo cultureinfo = CultureInfo.CurrentUICulture;
            switch (cultureinfo.Name)
            {
                case "en-US":
                    return this.AccountName_Eng + " - " + this.AccountID;
                case "ar-KW":
                    return this.AccountName_Ar + " - " + this.AccountID;
                default:
                    return this.AccountName_Eng + " - " + this.AccountID;
            }
        }

        private string GetAccountName()
        {
            CultureInfo cultureinfo = CultureInfo.CurrentUICulture;
            switch (cultureinfo.Name)
            {
                case "en-US":
                    return this.AccountName_Eng;
                case "ar-KW":
                    return this.AccountName_Ar;
                default:
                    return this.AccountName_Eng;
            }
        }

        public void FromDbAccount(Acc_Accounts _dbAccount)
        {
            this.AccountID = _dbAccount.AccountID;
            this.AccountName_Ar = _dbAccount.AccountName_Ar;
            this.AccountName_Eng = _dbAccount.AccountName_Eng;

            this.AccountRef1 = _dbAccount.AccountRef1;
            this.AccountRef2 = _dbAccount.AccountRef2;

            this.AccountTypeId = _dbAccount.AccountTypeId;
            this.AccountLevel = _dbAccount.AccountLevel;
            this.AccountCategoryId = _dbAccount.AccountCategoryId;
            this.IsSubAccount = _dbAccount.IsSubAccount;
            this.IsDisableAccount = _dbAccount.IsDisableAccount;
            this.ParentId = _dbAccount.ParentId;
            this.IsNew = false;
            this.IsCopy = false;
        }

        public void ToDbAccount(Acc_Accounts _dbAccount)
        {
            _dbAccount.AccountID = this.AccountID;
            _dbAccount.AccountName_Ar = this.AccountName_Ar;
            _dbAccount.AccountName_Eng = this.AccountName_Eng;

            _dbAccount.AccountRef1 = this.AccountRef1;
            _dbAccount.AccountRef2 = this.AccountRef2;

            _dbAccount.AccountTypeId = this.AccountTypeId;
            _dbAccount.AccountLevel = this.AccountLevel;
            _dbAccount.AccountCategoryId = this.AccountCategoryId;
            _dbAccount.IsSubAccount = this.IsSubAccount;
            _dbAccount.IsDisableAccount = this.IsDisableAccount;
            if (this.IsNew == true)
            {
                _dbAccount.ParentId = this.ParentId;
            }
            this.IsCopy = false;
        }

        public DataSaveResult Save()
        {
            this.IsCopy = false;
            Acc_Accounts dbAccount;
            try
            {
                NewAppsCnn newAppsCnn = new NewAppsCnn(AppSettings.CrAppSettings.NewAppsConnectionString);
                var dbAccounts = from u in newAppsCnn.Acc_Accounts where u.AccountID == this.AccountID select u;
                if (dbAccounts.Count() > 0)
                {
                    dbAccount = dbAccounts.First();
                    if (this.AccountTypeId != dbAccount.AccountTypeId && (dbAccount.ParentId==null||dbAccount.ParentId==""))
                    {
                        var dbAccountChilds = from u in newAppsCnn.Acc_Accounts where u.ParentId == this.AccountID select u;
                        foreach (var itm in dbAccountChilds)
                        {
                            itm.AccountTypeId = this.AccountTypeId;
                        }
                    }
                    this.ToDbAccount(dbAccount);
                    dbAccount.AccountLevel = getNodeLevel(0, dbAccount.ParentId);
                }
                else
                {
                    dbAccount = new Acc_Accounts();
                    this.ToDbAccount(dbAccount);
                    dbAccount.AccountLevel = getNodeLevel(0, dbAccount.ParentId);
                    newAppsCnn.Acc_Accounts.Add(dbAccount);
                }
                newAppsCnn.SaveChanges();
                Audit.AddDataAudit(Audit.AuditActionTypes.AddNew, "Acc_Accounts", this);
                this.FromDbAccount(dbAccount);
                return new DataSaveResult() { SaveStatus = true };
            }
            catch (Exception ex)
            {
                return new DataSaveResult() { SaveStatus = false,ErrorMessage=ex.Message };
            }
        }


        public DataDeleteResult Delete()
        {
            this.IsCopy = false;
            Acc_Accounts dbAccount;
            try
            {
                NewAppsCnn newAppsCnn = new NewAppsCnn(AppSettings.CrAppSettings.NewAppsConnectionString);
                var dbAccounts = from u in newAppsCnn.Acc_Accounts where u.AccountID == this.AccountID select u;
                if (dbAccounts.Count() > 0)
                {
                    dbAccount = dbAccounts.First();
                    var dbAccountChilds = from u in newAppsCnn.Acc_Accounts where u.ParentId == this.AccountID select u;
                    if (dbAccountChilds.Count() == 0 && DontHaveTransaction())//Transaction Condition
                    {
                        newAppsCnn.Acc_Accounts.Remove(dbAccount);
                        newAppsCnn.SaveChanges();
                    }
                    else
                    {
                        return new DataDeleteResult() { DeleteStatus = false, ErrorMessage = "This Item has childs" };
                    }
                }
                return new DataDeleteResult() { DeleteStatus = true };
            }
            catch (Exception ex)
            {
                return new DataDeleteResult() { DeleteStatus = false, ErrorMessage = ex.Message };
            }
        }

        public bool DontHaveTransaction()
        {
            //TODO : in transaction implemantation
            return true;
        }

    }
}