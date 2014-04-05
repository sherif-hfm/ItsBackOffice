using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BackOfficeDAL;

namespace BackOfficeBL.General
{
    public class FinancialYear
    {
        public int YearID { get; set; }
        public string YearName { get; set; }
        public DateTime YearBegin { get; set; }
        public DateTime YearEnd { get; set; }
        public bool IsClosedYear { get; set; }
        public bool IsDefaultYear { get; set; }
        public bool IsNew { get; set; }
        public int prefix { get; set; }
        public FinancialYear()
        {
            this.IsNew = true;
        }
        public static List<FinancialYear> GetAllFinancialYears()
        {
            NewAppsCnn newAppsCnn = new NewAppsCnn(AppSettings.CrAppSettings.NewAppsConnectionString);
            List<FinancialYear> FinancialYearsList = new List<FinancialYear>();
            var financialyear = newAppsCnn.Gnrl_FinancialYear.ToList();
            foreach (var financial in financialyear)
            {
                FinancialYear year = new FinancialYear();
                year.YearID = financial.YearId;
                year.YearName = financial.YearName;
                year.YearBegin = financial.YearBegin;
                year.YearEnd = financial.YearEnd;
                year.IsDefaultYear = financial.IsDefaultYear;
                year.IsClosedYear = financial.IsClosedYear;
                year.prefix = financial.prefix;

                FinancialYearsList.Add(year);
            }

            return FinancialYearsList;
        }
        public DataSaveResult Save(FinancialYear _FinancilaYear)
        {

            try
            {
                NewAppsCnn newAppsCnn = new NewAppsCnn(AppSettings.CrAppSettings.NewAppsConnectionString);


                if (_FinancilaYear.IsDefaultYear == true)
                {
                    var _Gnrl_FinancialYear = newAppsCnn.Gnrl_FinancialYear.ToList();
                    foreach (Gnrl_FinancialYear G in _Gnrl_FinancialYear)
                    {

                        G.IsDefaultYear = false;
                        //G.IsClosedYear = GnrlFinancialYear.IsClosedYear;
                        //G.YearBegin = GnrlFinancialYear.YearBegin;
                        //G.YearEnd = GnrlFinancialYear.YearEnd;
                        //G.YearId = GnrlFinancialYear.YearId;
                        //G.YearName = GnrlFinancialYear.YearName;

                    }
                }
                Gnrl_FinancialYear Gnrl_FinancialYear;
                Gnrl_FinancialYear = newAppsCnn.Gnrl_FinancialYear.Where(a => a.YearId == _FinancilaYear.YearID).FirstOrDefault();

                if (Gnrl_FinancialYear != null)
                {
                    BuildDBRecord(Gnrl_FinancialYear, _FinancilaYear);

                }

                else
                {

                    Gnrl_FinancialYear = new Gnrl_FinancialYear();
                    Gnrl_FinancialYear = BuildDBRecord(Gnrl_FinancialYear, _FinancilaYear);
                    newAppsCnn.Gnrl_FinancialYear.Add(Gnrl_FinancialYear);
                }


                newAppsCnn.SaveChanges();
                //   Audit.AddDataAudit(Audit.AuditActionTypes.AddNew, "Acc_VouchersType", this);

                return new DataSaveResult() { SaveStatus = true };
            }
            catch (Exception ex)
            {
                return new DataSaveResult() { SaveStatus = false };
            }
        }
        public DataDeleteResult Delete(int YearID)
        {
            Gnrl_FinancialYear Gnrl_FinancialYear;
            try
            {
                NewAppsCnn newAppsCnn = new NewAppsCnn(AppSettings.CrAppSettings.NewAppsConnectionString);
                var financialyear = from Year in newAppsCnn.Gnrl_FinancialYear where Year.YearId == YearID select Year;
                if (financialyear.Count() > 0)
                {
                    Gnrl_FinancialYear = financialyear.First();
                    newAppsCnn.Gnrl_FinancialYear.Remove(Gnrl_FinancialYear);
                    newAppsCnn.SaveChanges();
                }
                return new DataDeleteResult() { DeleteStatus = true };
            }
            catch (Exception ex)
            {
                return new DataDeleteResult() { DeleteStatus = false, ErrorMessage = ex.Message };
            }
        }
        private Gnrl_FinancialYear BuildDBRecord(Gnrl_FinancialYear _GnrlFinancilaYear, FinancialYear _FinancialYear)
        {
            if (_FinancialYear.YearID != -1)
            {
                _GnrlFinancilaYear.YearId = _FinancialYear.YearID;

            }
            _GnrlFinancilaYear.YearName = _FinancialYear.YearName;
            _GnrlFinancilaYear.YearEnd = _FinancialYear.YearEnd;
            _GnrlFinancilaYear.YearBegin = _FinancialYear.YearBegin;
            _GnrlFinancilaYear.IsDefaultYear = _FinancialYear.IsDefaultYear;
            _GnrlFinancilaYear.IsClosedYear = _FinancialYear.IsClosedYear;
            _GnrlFinancilaYear.prefix = _FinancialYear.prefix;
            return _GnrlFinancilaYear;
        }

    }
}
