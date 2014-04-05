using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using BackOfficeDAL;

namespace BackOfficeBL.Accounting
{
    public class Budget
    {
        public int BudgetId { get; set; }
        public string BudgetName_Eng { get; set; }
        public string BudgetName_Ara { get; set; }
        public int BudgetYearId { get; set; }
        public string BudgetYearName { get; set; }
        public bool IsDisable { get; set; }

        public int BudgetDtlId { get; set; }
        public int BudgetYear { get; set; }

        public int BudgetAccountId { get; set; }
        public string BudgetAccountName { get { return GetAccountName(); } }
        public string AccountName_Ar { get; set; }
        public string AccountName_En { get; set; }
        private string GetAccountName()
        {
            CultureInfo cultureinfo = CultureInfo.CurrentUICulture;
            switch (cultureinfo.Name)
            {
                case "en-US":
                    return this.AccountName_En;
                case "ar-KW":
                    return this.AccountName_Ar;
                default:
                    return this.AccountName_En;
            }
        }

        public string BudgetCostCenterId { get; set; }
        public string CostCenterName { get { return GetCostCenterName(); } }
        public string CostCenterName_Ara { get; set; }
        public string CostCenterName_Eng { get; set; }
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

        public int BudgetLocationId { get; set; }
        public string LocationName { get { return GetLocationName(); } }
        public string LocationName_Ara { get; set; }
        public string LocationName_Eng { get; set; }
        private string GetLocationName()
        {
            CultureInfo cultureinfo = CultureInfo.CurrentUICulture;
            switch (cultureinfo.Name)
            {
                case "en-US":
                    return this.LocationName_Eng;
                case "ar-KW":
                    return this.LocationName_Ara;
                default:
                    return this.LocationName_Eng;
            }
        }

        public decimal BdgtDepitAmount { get; set; }
        public decimal BdgtCreditAmount { get; set; }
        public decimal BdgttBalance { get; set; }

        public DateTime BdgtFrom { get; set; }
        public DateTime BdgtTo { get; set; }

        public static List<Budget> GetAllBugets()
        {
            List<Budget> BudgetTypeList = new List<Budget>();
            NewAppsCnn newAppsCnn = new NewAppsCnn(AppSettings.CrAppSettings.NewAppsConnectionString);
            var budgets = from bdgt in newAppsCnn.Acc_Budgets
                          join financial in newAppsCnn.Gnrl_FinancialYear on bdgt.BudgetYearId equals financial.YearId
                          select new
                          {
                              BudgetId = bdgt.BudgetId,
                              BudgetName_Ara = bdgt.BudgetName_Ara,
                              BudgetName_Eng = bdgt.BudgetName_Eng,
                              BudgetYearId = bdgt.BudgetYearId,
                              IsDisable = bdgt.IsDisable,
                              YearName = financial.YearName
                          };

            foreach (var Budgettype in budgets)
            {
                Budget BudgetType = new Budget();
                BudgetType.BudgetId = Budgettype.BudgetId;
                BudgetType.BudgetName_Ara = Budgettype.BudgetName_Ara;
                BudgetType.BudgetName_Eng = Budgettype.BudgetName_Eng;
                BudgetType.BudgetYearId = Budgettype.BudgetYearId;
                BudgetType.IsDisable = Budgettype.IsDisable;
                BudgetType.BudgetYearName = Budgettype.YearName;
                BudgetTypeList.Add(BudgetType);

            }
            return BudgetTypeList;
        }

        public static List<Budget> GetBudgetDetails(int BudgetID)
        {
            List<Budget> BudgetDetailsList = new List<Budget>();
            NewAppsCnn newAppsCnn = new NewAppsCnn(AppSettings.CrAppSettings.NewAppsConnectionString);
            //var BudgetDetail = from BudgetsDtl in newAppsCnn.Acc_BudgetsDtl
            //                   join Acc in newAppsCnn.Acc_Accounts on BudgetsDtl.BudgetAccountId equals Acc.AccountID
            //                   join CostCnter in newAppsCnn.Acc_CostCenter on BudgetsDtl.BudgetCostCenterId equals CostCnter.CostCenterId
            //                   where BudgetsDtl.BudgetId = BudgetID
            //                   select new
            //                   {
            //                   //    BudgetId = bdgt.BudgetId,
            //                   //    BudgetName_Ara = bdgt.BudgetName_Ara,
            //                   //    BudgetName_Eng = bdgt.BudgetName_Eng,
            //                   //    BudgetYearId = bdgt.BudgetYearId,
            //                   //    IsDisable = bdgt.IsDisable,
            //                   //    YearName = financial.YearName
            //                   };

            return BudgetDetailsList;
        }


    }

}
