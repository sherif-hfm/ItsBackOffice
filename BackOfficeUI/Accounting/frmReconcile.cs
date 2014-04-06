using BackOfficeBL;
using BackOfficeBL.Accounting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BackOfficeUI.Accounting
{
    public partial class frmReconcile : BackOfficeUI.Controls.frmBaseDB
    {
        private BackOfficeBL.Accounting.Reconcile CrReconcile;

        public frmReconcile(string AccountId)
        {
            InitializeComponent();
            this.AllowedFunctions=2;
            CrReconcile = Reconcile.FindByReconcileID(AccountId);
            LoadDataGrid();
        }

        #region Functions for loading data from or to controls
        private void ShowGUI()
        {
            if (CrReconcile != null)
            {
                txtReconcileAccountName.Text = CrReconcile.ReconcileAccountName;
                txtAccountNo.Text = CrReconcile.ReconcileAccountId;
                txtReconcilationValue.Value = CrReconcile.ReconcilationValue??0;
                txtDiffreneceInBook.Value = CrReconcile.DiffreneceInBook??0;
                txtAccountBalance.Value = CrReconcile.AccountBalance;
                txtReconciledLastDate.Value = CrReconcile.ReconciledLastDate??DateTime.Now;
                txtReconciledLastBal.Value = CrReconcile.ReconciledLastBal??0;
                txtCurrentStatemantAmount.Value = CrReconcile.CurrentStatemantAmount;
                txtCurrentStatementDate.Value = CrReconcile.CurrentStatementDate;
            }
            else
            {
                txtReconcileAccountName.Text = "";
                txtReconcilationValue.Value = 0;
                txtAccountNo.Text = "";
                txtDiffreneceInBook.Value = 0;
                txtAccountBalance.Value = 0;
                txtReconciledLastDate.Value = DateTime.Now;
                txtReconciledLastBal.Value = 0;
                txtCurrentStatemantAmount.Value = 0;
                txtCurrentStatementDate.Value = DateTime.Now;
            }
        }


        private void GetDataFromGUI()
        {
            CrReconcile.ReconcileAccountName = txtReconcileAccountName.Text;
            CrReconcile.ReconcileAccountId = txtAccountNo.Text;
            CrReconcile.ReconcilationValue = Convert.ToDecimal(txtReconcilationValue.Value);
            CrReconcile.DiffreneceInBook = Convert.ToDecimal(txtDiffreneceInBook.Value);
            CrReconcile.AccountBalance = Convert.ToDecimal(txtAccountBalance.Value);
            CrReconcile.ReconciledLastDate = Convert.ToDateTime(txtReconciledLastDate.Value);
            CrReconcile.ReconciledLastBal = Convert.ToDecimal(txtReconciledLastBal.Value);
            CrReconcile.CurrentStatemantAmount = Convert.ToDecimal(txtCurrentStatemantAmount.Value);
            CrReconcile.CurrentStatementDate = Convert.ToDateTime(txtCurrentStatementDate.Value);


            List<DataGridViewRow> rows_with_checked_column = new List<DataGridViewRow>();
            CrReconcile.ReconcilationDtlLst = new List<ReconcilationDtl>();
            foreach (DataGridViewRow row in dgrdVouchers.Rows)
            {
                if (Convert.ToBoolean(row.Cells["Cheked"].Value) == true)
                {
                    ReconcilationDtl DObj = new ReconcilationDtl(){
                        VoucherId = Convert.ToString(row.Cells["TransactionId"].Value)
                    };
                    CrReconcile.ReconcilationDtlLst.Add(DObj);
                }
            }
        }

        private void LoadDataGrid()
        {
            if(CrReconcile.VoucherDtlLst.Count != 0)
            {
                dgrdVouchers.AutoGenerateColumns = false;
                dgrdVouchers.DataSource = null;
                Cheked.DataPropertyName = "Cheked";
                TransActionDate.DataPropertyName = "VoucherDate";
                TransactionId.DataPropertyName = "VoucherId";
                TransactionType.DataPropertyName = "VoucherTypeName";
                Debit.DataPropertyName = "TotalDtlDebitAmount";
                Credit.DataPropertyName = "TotalCreditAmount";
                SettlementAmount.DataPropertyName = "SettlementAmount";
                dgrdVouchers.DataSource = CrReconcile.VoucherDtlLst;

            }
        }
        #endregion

        private void frmReconcile_Load(object sender, EventArgs e)
        {
            ShowGUI();
        }

        private void frmReconcile_Save(object sender, ref bool _status)
        {
            GetDataFromGUI();
            DataSaveResult saveResult = CrReconcile.Save();
            if (saveResult.SaveStatus == false)
            {
                _status = false;
            }
            else
            {
                CrReconcile = null;
                ShowGUI();
            }
        }

    }
}
