﻿using BackOfficeAudit;
using BackOfficeDAL;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace BackOfficeBL.Accounting
{
    public class CostCenter
    {
        public int CostCenterId { get; set; }
        public string Name { get { return GetCostCenterName(); } }
        public string CostCenterName_Ara { get; set; }
        public string CostCenterName_Eng { get; set; }
        public decimal CostOpenBalance { get; set; }
        public decimal ClosingBalance { get; set; }
        public bool IsDisable { get; set; }
        public int? ParentId { get; set; }
        public bool IsNew { get; set; }
        public bool IsCopy { get; set; }



        private static int getNodeLevel(int IntCount, int? CostCenterId)
        {
            var CurrCostCenter = FindByCostCenterId(CostCenterId);
            if (CurrCostCenter == null)
            {
                return IntCount;
            }
            else if (CurrCostCenter.ParentId == null )
            {
                return ++IntCount;
            }
            else
            {
                return getNodeLevel(++IntCount, CurrCostCenter.ParentId);
            }
        }

        public static List<CostCenter> GetAllCostCenterTree()
        {
            List<CostCenter> result = new List<CostCenter>();
            NewAppsCnn newAppsCnn = new NewAppsCnn(AppSettings.CrAppSettings.NewAppsConnectionString);
            var dbCostCenters = from g in newAppsCnn.Acc_CostCenter select g;
            foreach (var dbCostCenter in dbCostCenters)
            {
                CostCenter account = new CostCenter();
                account.FromDbCostCenter(dbCostCenter);
                result.Add(account);
            }
            return result;
        }

        public static List<CostCenter> GetAllCmbCostCenter()
        {
            List<CostCenter> result = new List<CostCenter>();
            NewAppsCnn newAppsCnn = new NewAppsCnn(AppSettings.CrAppSettings.NewAppsConnectionString);
            var dbCostCenters = from g in newAppsCnn.Acc_CostCenter where g.IsDisable==false select g;
            foreach (var dbCostCenter in dbCostCenters)
            {
                CostCenter account = new CostCenter();
                account.FromDbCostCenter(dbCostCenter);
                result.Add(account);
            }
            return result;
        }
        public static CostCenter FindByCostCenterId(int? _VaidationID)
        {
            NewAppsCnn newAppsCnn = new NewAppsCnn(AppSettings.CrAppSettings.NewAppsConnectionString);
            var dbCostCenters = from u in newAppsCnn.Acc_CostCenter where u.CostCenterId == _VaidationID select u;
            if (dbCostCenters.Count() > 0)
            {
                Acc_CostCenter dbCostCenter = dbCostCenters.First();
                CostCenter account = new CostCenter();
                account.FromDbCostCenter(dbCostCenter);
                account.IsNew = false;
                account.IsCopy = false;
                return account;
            }
            else
                return null;
        }
        public CostCenter()
        {
            this.IsNew = true;
            this.IsCopy = false;
        }

        private string GetCostCenterNameAndNo()
        {
            CultureInfo cultureinfo = CultureInfo.CurrentUICulture;
            switch (cultureinfo.Name)
            {
                case "en-US":
                    return this.CostCenterName_Eng + " - " + this.CostCenterId;
                case "ar-KW":
                    return this.CostCenterName_Ara + " - " + this.CostCenterId;
                default:
                    return this.CostCenterName_Eng + " - " + this.CostCenterId;
            }
        }

        private string GetCostCenterName()
        {
            CultureInfo cultureinfo = CultureInfo.CurrentUICulture;
            switch (cultureinfo.Name)
            {
                case "en-US":
                    return this.CostCenterName_Eng;
                case "ar-KW":
                    return this.CostCenterName_Ara;
                default:
                    return this.CostCenterName_Eng;
            }
        }

        public void FromDbCostCenter(Acc_CostCenter _dbCostCenter)
        {
            this.CostCenterId = _dbCostCenter.CostCenterId;
            this.CostCenterName_Ara = _dbCostCenter.CostCenterName_Ara;
            this.CostCenterName_Eng = _dbCostCenter.CostCenterName_Eng;
            this.CostOpenBalance = _dbCostCenter.CostOpenBalance.Value;
            this.ClosingBalance = _dbCostCenter.ClosingBalance.Value;
            this.IsDisable = _dbCostCenter.IsDisable;
            this.ParentId = _dbCostCenter.ParentId;
            this.IsNew = false;
            this.IsCopy = false;
        }

        public void ToDbCostCenter(Acc_CostCenter _dbCostCenter)
        {
            _dbCostCenter.CostCenterId = this.CostCenterId;
            _dbCostCenter.CostCenterName_Ara = this.CostCenterName_Ara;
            _dbCostCenter.CostCenterName_Eng = this.CostCenterName_Eng;
            _dbCostCenter.CostOpenBalance = this.CostOpenBalance;
            _dbCostCenter.ClosingBalance = this.ClosingBalance;
            _dbCostCenter.IsDisable = this.IsDisable;
            if (this.IsNew == true)
            {
                _dbCostCenter.ParentId = this.ParentId;
            }
            this.IsCopy = false;
        }

        public DataSaveResult Save()
        {
            this.IsCopy = false;
            Acc_CostCenter dbCostCenter;
            try
            {
                NewAppsCnn newAppsCnn = new NewAppsCnn(AppSettings.CrAppSettings.NewAppsConnectionString);
                var dbCostCenters = from u in newAppsCnn.Acc_CostCenter where u.CostCenterId == this.CostCenterId select u;
                if (dbCostCenters.Count() > 0)
                {
                    dbCostCenter = dbCostCenters.First();
                    this.ToDbCostCenter(dbCostCenter);
                }
                else
                {
                    dbCostCenter = new Acc_CostCenter();
                    this.ToDbCostCenter(dbCostCenter);
                    newAppsCnn.Acc_CostCenter.Add(dbCostCenter);
                }
                newAppsCnn.SaveChanges();
                Audit.AddDataAudit(Audit.AuditActionTypes.AddNew, "Acc_CostCenter", this);
                this.FromDbCostCenter(dbCostCenter);
                return new DataSaveResult() { SaveStatus = true};
            }
            catch (Exception ex)
            {
                return new DataSaveResult() { SaveStatus = false ,ErrorMessage= ex.Message };
            }
        }

        public DataDeleteResult Delete()
        {
            this.IsCopy = false;
            Acc_CostCenter dbCostCenter;
            try
            {
                NewAppsCnn newAppsCnn = new NewAppsCnn(AppSettings.CrAppSettings.NewAppsConnectionString);
                var dbCostCenters = from u in newAppsCnn.Acc_CostCenter where u.CostCenterId == this.CostCenterId select u;
                if (dbCostCenters.Count() > 0)
                {
                    dbCostCenter = dbCostCenters.First();
                    var dbAccountChilds = from u in newAppsCnn.Acc_CostCenter where u.ParentId == this.CostCenterId select u;
                    if (dbAccountChilds.Count() == 0 && DontHaveTransaction())//Transaction Condition
                    {
                        newAppsCnn.Acc_CostCenter.Remove(dbCostCenter);
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
