using BackOfficeDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackOfficeBL.Security
{
    public class FinancialYear
    {
        private static NewAppsCnn DBContext = new NewAppsCnn(AppSettings.CrAppSettings.NewAppsConnectionString);
        public int YearId { get; set; }
        public string YearName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsDefaultYear { get; set; }

        public static List<FinancialYear> GetAllActiveFinancialYear()
        {
            return (DBContext.Gnrl_FinancialYear.Where(Financialyear => Financialyear.IsClosedYear == false).Select(fYear => new FinancialYear { YearId = fYear.YearId, EndDate = fYear.YearEnd, StartDate = fYear.YearBegin, YearName = fYear.YearName, IsDefaultYear = fYear.IsDefaultYear })).ToList();
        }

        public static FinancialYear GetFinanicalYear(int id)
        {
            return DBContext.Gnrl_FinancialYear.Where(year => year.YearId == id).Select(fYear => new FinancialYear { YearId = fYear.YearId, EndDate = fYear.YearEnd, StartDate = fYear.YearBegin, YearName = fYear.YearName, IsDefaultYear = fYear.IsDefaultYear }).First();
        }

        public static int GetDefaultYear(List<FinancialYear> years)
        {
            return years.First(year => year.IsDefaultYear).YearId;
        }
    }
}
