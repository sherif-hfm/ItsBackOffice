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

        public string BudgetAccountId { get; set; }
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

        public int? BudgetCostCenterId { get; set; }
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

        public string BudgetLocationId { get; set; }
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
            var BudgetDetail = from BudgetsDtl in newAppsCnn.Acc_BudgetsDtl
                               join Acc in newAppsCnn.Acc_Accounts on BudgetsDtl.BudgetAccountId equals Acc.AccountID
                               join CostCnter in newAppsCnn.Acc_CostCenter on BudgetsDtl.BudgetCostCenterId equals CostCnter.CostCenterId
                               join loc in newAppsCnn.Gnrl_Loctions on BudgetsDtl.BudgetLocationId equals loc.LocationId
                               where BudgetsDtl.BudgetId == BudgetID
                               select new
                               {
                                   BudgetDtlId = BudgetsDtl.BudgetDtlId,
                                   BudgetYear = BudgetsDtl.BudgetYear,
                                   BudgetAccountId = BudgetsDtl.BudgetAccountId,
                                   AccountName_Ar = Acc.AccountName_Ar,
                                   AccountName_En = Acc.AccountName_Eng,
                                   BudgetCostCenterId = BudgetsDtl.BudgetCostCenterId,
                                   CostCenterName_Ara = CostCnter.CostCenterName_Ara,
                                   CostCenterName_Eng = CostCnter.CostCenterName_Eng,
                                   BudgetLocationId = BudgetsDtl.BudgetLocationId,
                                   LocationName_Ara = loc.LocationName_Ara,
                                   LocationName_Eng = loc.LocationName_Eng,
                                   BdgtDepitAmount = BudgetsDtl.BdgtDepitAmount,
                                   BdgtCreditAmount = BudgetsDtl.BdgtCreditAmount,
                                   BdgttBalance = BudgetsDtl.BdgttBalance,
                                   BdgtFrom = BudgetsDtl.BdgtFrom,
                                   BdgtTo = BudgetsDtl.BdgtTo

                               };
            foreach (var Detail in BudgetDetail)
            {
                Budget Budgt = new Budget();
                Budgt.BudgetDtlId = Detail.BudgetDtlId;
                Budgt.BudgetYear = Detail.BudgetYear;
                Budgt.BudgetAccountId = Detail.BudgetAccountId;
                Budgt.AccountName_Ar = Detail.AccountName_Ar;
                Budgt.AccountName_Ar = Detail.AccountName_Ar;
                Budgt.BudgetCostCenterId = Detail.BudgetCostCenterId;
                Budgt.CostCenterName_Ara = Detail.CostCenterName_Ara;
                Budgt.CostCenterName_Eng = Detail.CostCenterName_Eng;
                Budgt.BudgetLocationId = Detail.BudgetLocationId;
                Budgt.LocationName_Ara = Detail.LocationName_Ara;
                Budgt.LocationName_Eng = Detail.LocationName_Eng;
                Budgt.BdgtDepitAmount = Detail.BdgtDepitAmount;
                Budgt.BdgtCreditAmount = Detail.BdgtCreditAmount;
                Budgt.BdgttBalance = Detail.BdgttBalance;
                Budgt.BdgtFrom = Detail.BdgtFrom;
                Budgt.BdgtTo = Detail.BdgtTo;
                BudgetDetailsList.Add(Budgt);
            }
            return BudgetDetailsList;
        }


    }

}
