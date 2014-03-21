﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BackOfficeDAL;
using System.Globalization;

namespace BackOfficeBL.Accounting
{
    public class Account
    {
        public string AccountID { get; set; }
        public string Name { get { return GetAccountName(); } }
        public bool IsDisable { get; set; }
        public string AccountName_Ar { get; set; }
        public string AccountName_Eng { get; set; }
        public int AccountTypeId { get; set; }
        public int AccountLevel { get; set; }
        public int? AccountCategoryId { get; set; }
        public bool IsSubAccount { get; set; }
        public bool IsDisableAccount { get; set; }
        public string ParentId { get; set; }
        public bool IsNew { get; set; }

        public static List<Account> GetAllAccountTree()
        {
            List<Account> result = new List<Account>();
            NewAppsCnn newAppsCnn = new NewAppsCnn(AppSettings.CrAppSettings.NewAppsConnectionString);
            var dbAccounts = from g in newAppsCnn.Acc_Accounts select g;
            foreach (var dbAccount in dbAccounts)
            {
                Account account = new Account();
                account.FromDbAccount(dbAccount);
                result.Add(account);
            }
            return result;
        }

        public Account()
        {
            this.IsNew = true;
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
            this.AccountTypeId = _dbAccount.AccountTypeId;
            this.AccountLevel = _dbAccount.AccountLevel;
            this.AccountCategoryId = _dbAccount.AccountCategoryId;
            this.IsSubAccount = _dbAccount.IsSubAccount;
            this.IsDisableAccount = _dbAccount.IsDisableAccount;
            this.ParentId = _dbAccount.ParentId;
            this.IsNew = false;
        }

        public void ToDbAccount(Acc_Accounts _dbAccount)
        {
            _dbAccount.AccountID = this.AccountID;
            _dbAccount.AccountName_Ar = this.AccountName_Ar;
            _dbAccount.AccountName_Eng = this.AccountName_Eng;
            _dbAccount.AccountTypeId = this.AccountTypeId;
            _dbAccount.AccountLevel = this.AccountLevel;
            _dbAccount.AccountCategoryId = this.AccountCategoryId;
            _dbAccount.IsSubAccount = this.IsSubAccount;
            _dbAccount.IsDisableAccount = this.IsDisableAccount;
            _dbAccount.ParentId = this.ParentId;
        }
    }
}