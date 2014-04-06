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
        public string ReconcileAccountName { get; set; }
        public string ReconcileAccountName_Ar { get; set; }
        public string ReconcileAccountName_En { get; set; }
        public string ReconcileId { get; set; }
        public int ReconcileYear { get; set; }
        public decimal CurrentStatemantAmount { get; set; }
        public DateTime CurrentStatementDate { get; set; }
        public decimal? ReconciledLastBal { get; set; }
        public DateTime? ReconciledLastDate { get; set; }
        public decimal? ReconcilationValue { get; set; }
        public decimal AccountBalance { get; set; }
        public decimal? DiffreneceInBook { get; set; }
        public List<ReconcilationDtl> ReconcilationDtlLst { get; set; }
        public List<Voucher> VoucherDtlLst { get; set; }

        public Reconcile()
        {
            this.CurrentStatementDate = DateTime.Now;
        }
        public static Reconcile FindByReconcileID(string _VaidationID)
        {
            NewAppsCnn newAppsCnn = new NewAppsCnn(AppSettings.CrAppSettings.NewAppsConnectionString);
            var dbReconciles = from u in newAppsCnn.Acc_Reconcilation where u.ReconcileAccountId == _VaidationID select u;
            if (dbReconciles.Count() > 0)
            {
                Acc_Reconcilation dbAcc_Reconcilation = dbReconciles.First();
                Reconcile reconcile = new Reconcile();
                reconcile.FromDbReconcilation(dbAcc_Reconcilation);
                return reconcile;
            }
            else
            {
                Reconcile reconcile = new Reconcile();
                var clsAccount = Account.FindByAccountID(_VaidationID);
                reconcile.ReconcileAccountId = _VaidationID;
                reconcile.ReconcileAccountName = clsAccount.Name;
                reconcile.ReconcileAccountName_Ar = clsAccount.AccountName_Eng;
                reconcile.ReconcileAccountName_En = clsAccount.AccountName_Ar;
                reconcile.LoadVoucher();
                return reconcile;
            }
        }

        public void LoadVoucher()
        {
            this.VoucherDtlLst = new List<Voucher>();
            NewAppsCnn newAppsCnn = new NewAppsCnn(AppSettings.CrAppSettings.NewAppsConnectionString);
            var VoucherList = newAppsCnn.Acc_VoucherDtl.Where(a => a.AccountId == this.ReconcileAccountId).Select(a => a.Acc_Voucher).ToList();
            foreach (var itm in VoucherList)
            {
                Voucher Obj = new Voucher() { 
                Cheked=(this.ReconcileId!=null? newAppsCnn.Acc_ReconcilationDtl.Where(a=>a.ReconcileId==this.ReconcileId&&a.VoucherId==itm.VoucherId).Any():false),
                SettlementAmount="0",
                TotalCreditAmount = itm.TotalCreditAmount.ToString(),
                TotalDtlDebitAmount = itm.TotalDtlDebitAmount.ToString(),
                VoucherDate = itm.VoucherDate.ToShortDateString(),
                VoucherRefno = itm.VoucherRefno,
                VoucherId = itm.VoucherId,
                VoucherTypeName=itm.Acc_VouchersType.ShortName_Eng
                };
                this.VoucherDtlLst.Add(Obj);
            }
        }

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
            LoadVoucher();
        }

        public void ToDbReconcilation(Acc_Reconcilation _dbReconcilation)
        {
            NewAppsCnn newAppsCnn = new NewAppsCnn(AppSettings.CrAppSettings.NewAppsConnectionString);
            var RId = 1 + ((from u in newAppsCnn.Acc_Reconcilation select u.ReconcileId).ToList().LastOrDefault() == null ? 1 : (int.Parse((from u in newAppsCnn.Acc_Reconcilation select u.ReconcileId).ToList().LastOrDefault())));
            _dbReconcilation.ReconcileId = this.ReconcileId ?? RId.ToString();
            _dbReconcilation.ReconcileAccountId = this.ReconcileAccountId;
            _dbReconcilation.ReconcileYear = AppInfo.CurrentYear.YearId;
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
                    List<Acc_ReconcilationDtl> DltLst = (from u in newAppsCnn.Acc_ReconcilationDtl where u.ReconcileId == this.ReconcileId select u).ToList();
                    foreach (var itm in DltLst)
                    {
                        newAppsCnn.Acc_ReconcilationDtl.Remove(itm);
                        newAppsCnn.SaveChanges();
                    }
                    foreach (var itm in this.ReconcilationDtlLst)
                    {
                        Acc_ReconcilationDtl Obj = new Acc_ReconcilationDtl()
                        {
                            ReconcileId = dbReconcilation.ReconcileId,
                            VoucherId = itm.VoucherId,
                            VoucherNo = (from u in newAppsCnn.Acc_Voucher where u.VoucherId == itm.VoucherId select u).ToList().FirstOrDefault().VoucherRefno,
                            ReconcileDtlid = (from u in newAppsCnn.Acc_ReconcilationDtl select u.ReconcileDtlid).ToList().LastOrDefault() == null ? 1 : (1 + (from u in newAppsCnn.Acc_ReconcilationDtl select u.ReconcileDtlid).ToList().LastOrDefault())
                        };
                        newAppsCnn.Acc_ReconcilationDtl.Add(Obj);
                        newAppsCnn.SaveChanges();
                    }
                }
                else
                {
                    dbReconcilation = new Acc_Reconcilation();
                    this.ToDbReconcilation(dbReconcilation);
                    newAppsCnn.Acc_Reconcilation.Add(dbReconcilation);
                    newAppsCnn.SaveChanges();
                    foreach (var itm in this.ReconcilationDtlLst)
                    {
                        Acc_ReconcilationDtl Obj = new Acc_ReconcilationDtl() {
                            ReconcileId = dbReconcilation.ReconcileId,
                            VoucherId=itm.VoucherId,
                            VoucherNo = (from u in newAppsCnn.Acc_Voucher where u.VoucherId == itm.VoucherId select u).ToList().FirstOrDefault().VoucherRefno,
                            ReconcileDtlid = (from u in newAppsCnn.Acc_ReconcilationDtl select u.ReconcileDtlid).ToList().LastOrDefault() == null ? 1 : (from u in newAppsCnn.Acc_ReconcilationDtl select u.ReconcileDtlid).ToList().LastOrDefault()
                        };
                        newAppsCnn.Acc_ReconcilationDtl.Add(Obj);
                        newAppsCnn.SaveChanges();
                    }
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
