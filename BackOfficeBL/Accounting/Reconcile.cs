using BackOfficeAudit;
using BackOfficeDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackOfficeBL.Accounting
{
    public class Reconcile
    {
        public string ReconcileAccountId { get; set; }
        public string ReconcileId { get; set; }
        public int ReconcileYear { get; set; }
        public decimal CurrentStatemantAmount { get; set; }
        public DateTime CurrentStatementDate { get; set; }
        public decimal? ReconciledLastBal { get; set; }
        public DateTime? ReconciledLastDate { get; set; }
        public decimal? ReconcilationValue { get; set; }
        public decimal AccountBalance { get; set; }
        public decimal? DiffreneceInBook { get; set; }
        public List<Acc_ReconcilationDtl> ReconcilationDtlLst { get; set; }
        public List<Acc_Voucher> VoucherDtlLst { get; set; }


        public void FromDbReconcilation(Acc_Reconcilation _dbReconcilation)
        {
            this.ReconcileId = _dbReconcilation.ReconcileId;
            this.ReconcileAccountId = _dbReconcilation.ReconcileAccountId;
            this.ReconcileYear = _dbReconcilation.ReconcileYear;
            this.CurrentStatemantAmount = _dbReconcilation.CurrentStatemantAmount;
            this.CurrentStatementDate = _dbReconcilation.CurrentStatementDate;
            this.ReconciledLastBal = _dbReconcilation.ReconciledLastBal;
            this.ReconciledLastDate = _dbReconcilation.ReconciledLastDate;
            this.ReconcilationValue = _dbReconcilation.ReconcilationValue;
            this.AccountBalance = _dbReconcilation.AccountBalance;
            this.DiffreneceInBook = _dbReconcilation.DiffreneceInBook;
        }

        public void ToDbReconcilation(Acc_Reconcilation _dbReconcilation)
        {
            _dbReconcilation.ReconcileId = this.ReconcileId;
            _dbReconcilation.ReconcileAccountId = this.ReconcileAccountId;
            _dbReconcilation.ReconcileYear = this.ReconcileYear;
            _dbReconcilation.CurrentStatemantAmount = this.CurrentStatemantAmount;
            _dbReconcilation.CurrentStatementDate = this.CurrentStatementDate;
            _dbReconcilation.ReconciledLastBal = this.ReconciledLastBal;
            _dbReconcilation.ReconciledLastDate = this.ReconciledLastDate;
            _dbReconcilation.ReconcilationValue = this.ReconcilationValue;
            _dbReconcilation.AccountBalance = this.AccountBalance;
            _dbReconcilation.DiffreneceInBook = this.DiffreneceInBook;
        }


        public DataSaveResult Save()
        {
            Acc_Reconcilation dbReconcilation;
            try
            {
                NewAppsCnn newAppsCnn = new NewAppsCnn(AppSettings.CrAppSettings.NewAppsConnectionString);
                var dbReconcilations = from u in newAppsCnn.Acc_Reconcilation where u.ReconcileId == this.ReconcileId select u;
                if (dbReconcilations.Count() > 0)
                {
                    dbReconcilation = dbReconcilations.First();
                    this.ToDbReconcilation(dbReconcilation);
                }
                else
                {
                    dbReconcilation = new Acc_Reconcilation();
                    this.ToDbReconcilation(dbReconcilation);
                    newAppsCnn.Acc_Reconcilation.Add(dbReconcilation);
                }
                newAppsCnn.SaveChanges();
                Audit.AddDataAudit(Audit.AuditActionTypes.AddNew, "Acc_Reconcilation", this);
                this.FromDbReconcilation(dbReconcilation);
                return new DataSaveResult() { SaveStatus = true };
            }
            catch (Exception ex)
            {
                return new DataSaveResult() { SaveStatus = false, ErrorMessage = ex.Message };
            }
        }


        public DataDeleteResult Delete()
        {
            Acc_Reconcilation dbReconcilation;
            try
            {
                NewAppsCnn newAppsCnn = new NewAppsCnn(AppSettings.CrAppSettings.NewAppsConnectionString);
                var dbReconcilations = from u in newAppsCnn.Acc_Reconcilation where u.ReconcileId == this.ReconcileId select u;
                if (dbReconcilations.Count() > 0)
                {
                    dbReconcilation = dbReconcilations.First();
                    var dbReconcilationChilds = from u in newAppsCnn.Acc_ReconcilationDtl where u.ReconcileId == this.ReconcileId select u;
                    if (dbReconcilationChilds.Count() == 0 )
                    {
                        newAppsCnn.Acc_Reconcilation.Remove(dbReconcilation);
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

    }
}
