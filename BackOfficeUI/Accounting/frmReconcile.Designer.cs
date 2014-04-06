namespace BackOfficeUI.Accounting
{
    partial class frmReconcile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReconcile));
            this.lblAccountNo = new BackOfficeUI.Controls.Label();
            this.label2 = new BackOfficeUI.Controls.Label();
            this.lblCurrentBanckStatementBalance = new BackOfficeUI.Controls.Label();
            this.lblBanckStatementDate = new BackOfficeUI.Controls.Label();
            this.lblLastBanckStatementDate = new BackOfficeUI.Controls.Label();
            this.lblAccountStatement = new BackOfficeUI.Controls.Label();
            this.lblBalance = new BackOfficeUI.Controls.Label();
            this.lblDifferenceInbook = new BackOfficeUI.Controls.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtReconciledLastDate = new BackOfficeUI.Controls.DateTimePicker();
            this.txtCurrentStatementDate = new BackOfficeUI.Controls.DateTimePicker();
            this.txtDiffreneceInBook = new BackOfficeUI.Controls.NumericUpDown();
            this.txtAccountBalance = new BackOfficeUI.Controls.NumericUpDown();
            this.txtReconcilationValue = new BackOfficeUI.Controls.NumericUpDown();
            this.txtCurrentStatemantAmount = new BackOfficeUI.Controls.NumericUpDown();
            this.txtReconciledLastBal = new BackOfficeUI.Controls.NumericUpDown();
            this.txtReconcileAccountName = new BackOfficeUI.Controls.TextBox();
            this.txtAccountNo = new BackOfficeUI.Controls.TextBox();
            this.dgrdVouchers = new BackOfficeUI.Controls.DataGridView();
            this.Cheked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TransActionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SettlementAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiffreneceInBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReconcilationValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCurrentStatemantAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReconciledLastBal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdVouchers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAccountNo
            // 
            resources.ApplyResources(this.lblAccountNo, "lblAccountNo");
            this.lblAccountNo.Clearable = true;
            this.lblAccountNo.ContextSearchId = 0;
            this.lblAccountNo.IsRequired = false;
            this.lblAccountNo.LockedInModes = 25;
            this.lblAccountNo.Name = "lblAccountNo";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Clearable = true;
            this.label2.ContextSearchId = 0;
            this.label2.IsRequired = false;
            this.label2.LockedInModes = 25;
            this.label2.Name = "label2";
            // 
            // lblCurrentBanckStatementBalance
            // 
            resources.ApplyResources(this.lblCurrentBanckStatementBalance, "lblCurrentBanckStatementBalance");
            this.lblCurrentBanckStatementBalance.Clearable = true;
            this.lblCurrentBanckStatementBalance.ContextSearchId = 0;
            this.lblCurrentBanckStatementBalance.IsRequired = false;
            this.lblCurrentBanckStatementBalance.LockedInModes = 25;
            this.lblCurrentBanckStatementBalance.Name = "lblCurrentBanckStatementBalance";
            // 
            // lblBanckStatementDate
            // 
            resources.ApplyResources(this.lblBanckStatementDate, "lblBanckStatementDate");
            this.lblBanckStatementDate.Clearable = true;
            this.lblBanckStatementDate.ContextSearchId = 0;
            this.lblBanckStatementDate.IsRequired = false;
            this.lblBanckStatementDate.LockedInModes = 25;
            this.lblBanckStatementDate.Name = "lblBanckStatementDate";
            // 
            // lblLastBanckStatementDate
            // 
            resources.ApplyResources(this.lblLastBanckStatementDate, "lblLastBanckStatementDate");
            this.lblLastBanckStatementDate.Clearable = true;
            this.lblLastBanckStatementDate.ContextSearchId = 0;
            this.lblLastBanckStatementDate.IsRequired = false;
            this.lblLastBanckStatementDate.LockedInModes = 25;
            this.lblLastBanckStatementDate.Name = "lblLastBanckStatementDate";
            // 
            // lblAccountStatement
            // 
            resources.ApplyResources(this.lblAccountStatement, "lblAccountStatement");
            this.lblAccountStatement.Clearable = true;
            this.lblAccountStatement.ContextSearchId = 0;
            this.lblAccountStatement.IsRequired = false;
            this.lblAccountStatement.LockedInModes = 25;
            this.lblAccountStatement.Name = "lblAccountStatement";
            // 
            // lblBalance
            // 
            resources.ApplyResources(this.lblBalance, "lblBalance");
            this.lblBalance.Clearable = true;
            this.lblBalance.ContextSearchId = 0;
            this.lblBalance.IsRequired = false;
            this.lblBalance.LockedInModes = 25;
            this.lblBalance.Name = "lblBalance";
            // 
            // lblDifferenceInbook
            // 
            resources.ApplyResources(this.lblDifferenceInbook, "lblDifferenceInbook");
            this.lblDifferenceInbook.Clearable = true;
            this.lblDifferenceInbook.ContextSearchId = 0;
            this.lblDifferenceInbook.IsRequired = false;
            this.lblDifferenceInbook.LockedInModes = 25;
            this.lblDifferenceInbook.Name = "lblDifferenceInbook";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtReconciledLastDate);
            this.groupBox1.Controls.Add(this.txtCurrentStatementDate);
            this.groupBox1.Controls.Add(this.txtDiffreneceInBook);
            this.groupBox1.Controls.Add(this.txtAccountBalance);
            this.groupBox1.Controls.Add(this.txtReconcilationValue);
            this.groupBox1.Controls.Add(this.txtCurrentStatemantAmount);
            this.groupBox1.Controls.Add(this.txtReconciledLastBal);
            this.groupBox1.Controls.Add(this.txtReconcileAccountName);
            this.groupBox1.Controls.Add(this.txtAccountNo);
            this.groupBox1.Controls.Add(this.lblAccountNo);
            this.groupBox1.Controls.Add(this.lblDifferenceInbook);
            this.groupBox1.Controls.Add(this.lblBalance);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblLastBanckStatementDate);
            this.groupBox1.Controls.Add(this.lblAccountStatement);
            this.groupBox1.Controls.Add(this.lblCurrentBanckStatementBalance);
            this.groupBox1.Controls.Add(this.lblBanckStatementDate);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // txtReconciledLastDate
            // 
            this.txtReconciledLastDate.Clearable = true;
            this.txtReconciledLastDate.ContextSearchId = 0;
            this.txtReconciledLastDate.IsRequired = false;
            resources.ApplyResources(this.txtReconciledLastDate, "txtReconciledLastDate");
            this.txtReconciledLastDate.LockedInModes = 25;
            this.txtReconciledLastDate.Name = "txtReconciledLastDate";
            // 
            // txtCurrentStatementDate
            // 
            this.txtCurrentStatementDate.Clearable = true;
            this.txtCurrentStatementDate.ContextSearchId = 0;
            this.txtCurrentStatementDate.IsRequired = false;
            resources.ApplyResources(this.txtCurrentStatementDate, "txtCurrentStatementDate");
            this.txtCurrentStatementDate.LockedInModes = 25;
            this.txtCurrentStatementDate.Name = "txtCurrentStatementDate";
            // 
            // txtDiffreneceInBook
            // 
            this.txtDiffreneceInBook.BackColor = System.Drawing.Color.White;
            this.txtDiffreneceInBook.Clearable = true;
            this.txtDiffreneceInBook.ContextSearchId = 0;
            this.txtDiffreneceInBook.IsRequired = false;
            resources.ApplyResources(this.txtDiffreneceInBook, "txtDiffreneceInBook");
            this.txtDiffreneceInBook.LockedInModes = 25;
            this.txtDiffreneceInBook.Name = "txtDiffreneceInBook";
            // 
            // txtAccountBalance
            // 
            this.txtAccountBalance.BackColor = System.Drawing.Color.White;
            this.txtAccountBalance.Clearable = true;
            this.txtAccountBalance.ContextSearchId = 0;
            this.txtAccountBalance.IsRequired = false;
            resources.ApplyResources(this.txtAccountBalance, "txtAccountBalance");
            this.txtAccountBalance.LockedInModes = 25;
            this.txtAccountBalance.Name = "txtAccountBalance";
            // 
            // txtReconcilationValue
            // 
            this.txtReconcilationValue.BackColor = System.Drawing.Color.White;
            this.txtReconcilationValue.Clearable = true;
            this.txtReconcilationValue.ContextSearchId = 0;
            this.txtReconcilationValue.IsRequired = false;
            resources.ApplyResources(this.txtReconcilationValue, "txtReconcilationValue");
            this.txtReconcilationValue.LockedInModes = 25;
            this.txtReconcilationValue.Name = "txtReconcilationValue";
            // 
            // txtCurrentStatemantAmount
            // 
            this.txtCurrentStatemantAmount.BackColor = System.Drawing.Color.White;
            this.txtCurrentStatemantAmount.Clearable = true;
            this.txtCurrentStatemantAmount.ContextSearchId = 0;
            this.txtCurrentStatemantAmount.IsRequired = false;
            resources.ApplyResources(this.txtCurrentStatemantAmount, "txtCurrentStatemantAmount");
            this.txtCurrentStatemantAmount.LockedInModes = 25;
            this.txtCurrentStatemantAmount.Name = "txtCurrentStatemantAmount";
            // 
            // txtReconciledLastBal
            // 
            this.txtReconciledLastBal.BackColor = System.Drawing.Color.White;
            this.txtReconciledLastBal.Clearable = true;
            this.txtReconciledLastBal.ContextSearchId = 0;
            this.txtReconciledLastBal.IsRequired = false;
            resources.ApplyResources(this.txtReconciledLastBal, "txtReconciledLastBal");
            this.txtReconciledLastBal.LockedInModes = 25;
            this.txtReconciledLastBal.Name = "txtReconciledLastBal";
            // 
            // txtReconcileAccountName
            // 
            this.txtReconcileAccountName.BackColor = System.Drawing.Color.White;
            this.txtReconcileAccountName.Clearable = true;
            this.txtReconcileAccountName.ContextSearchId = 0;
            this.txtReconcileAccountName.IsRequired = false;
            resources.ApplyResources(this.txtReconcileAccountName, "txtReconcileAccountName");
            this.txtReconcileAccountName.LockedInModes = 25;
            this.txtReconcileAccountName.Name = "txtReconcileAccountName";
            // 
            // txtAccountNo
            // 
            this.txtAccountNo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtAccountNo.Clearable = true;
            this.txtAccountNo.ContextSearchId = 0;
            this.txtAccountNo.IsRequired = false;
            resources.ApplyResources(this.txtAccountNo, "txtAccountNo");
            this.txtAccountNo.LockedInModes = 25;
            this.txtAccountNo.Name = "txtAccountNo";
            // 
            // dgrdVouchers
            // 
            this.dgrdVouchers.AllowUserToAddRows = false;
            this.dgrdVouchers.AllowUserToDeleteRows = false;
            this.dgrdVouchers.Clearable = true;
            this.dgrdVouchers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrdVouchers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cheked,
            this.TransActionDate,
            this.TransactionId,
            this.TransactionType,
            this.Debit,
            this.Credit,
            this.SettlementAmount});
            this.dgrdVouchers.ContextSearchId = 0;
            this.dgrdVouchers.IsRequired = false;
            resources.ApplyResources(this.dgrdVouchers, "dgrdVouchers");
            this.dgrdVouchers.LockedInModes = 2;
            this.dgrdVouchers.Name = "dgrdVouchers";
            // 
            // Cheked
            // 
            resources.ApplyResources(this.Cheked, "Cheked");
            this.Cheked.Name = "Cheked";
            // 
            // TransActionDate
            // 
            resources.ApplyResources(this.TransActionDate, "TransActionDate");
            this.TransActionDate.Name = "TransActionDate";
            // 
            // TransactionId
            // 
            resources.ApplyResources(this.TransactionId, "TransactionId");
            this.TransactionId.Name = "TransactionId";
            // 
            // TransactionType
            // 
            resources.ApplyResources(this.TransactionType, "TransactionType");
            this.TransactionType.Name = "TransactionType";
            // 
            // Debit
            // 
            resources.ApplyResources(this.Debit, "Debit");
            this.Debit.Name = "Debit";
            // 
            // Credit
            // 
            resources.ApplyResources(this.Credit, "Credit");
            this.Credit.Name = "Credit";
            // 
            // SettlementAmount
            // 
            resources.ApplyResources(this.SettlementAmount, "SettlementAmount");
            this.SettlementAmount.Name = "SettlementAmount";
            // 
            // frmReconcile
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.dgrdVouchers);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmReconcile";
            this.Save += new BackOfficeUI.Controls.frmBaseDB.SaveDelegate(this.frmReconcile_Save);
            this.Load += new System.EventHandler(this.frmReconcile_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.dgrdVouchers, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiffreneceInBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReconcilationValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCurrentStatemantAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReconciledLastBal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdVouchers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.Label lblAccountNo;
        private Controls.Label label2;
        private Controls.Label lblCurrentBanckStatementBalance;
        private Controls.Label lblBanckStatementDate;
        private Controls.Label lblLastBanckStatementDate;
        private Controls.Label lblAccountStatement;
        private Controls.Label lblBalance;
        private Controls.Label lblDifferenceInbook;
        private System.Windows.Forms.GroupBox groupBox1;
        private Controls.TextBox txtAccountNo;
        private Controls.TextBox txtReconcileAccountName;
        private Controls.DataGridView dgrdVouchers;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Cheked;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransActionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Debit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credit;
        private System.Windows.Forms.DataGridViewTextBoxColumn SettlementAmount;
        private Controls.NumericUpDown txtDiffreneceInBook;
        private Controls.NumericUpDown txtAccountBalance;
        private Controls.NumericUpDown txtReconcilationValue;
        private Controls.NumericUpDown txtCurrentStatemantAmount;
        private Controls.NumericUpDown txtReconciledLastBal;
        private Controls.DateTimePicker txtReconciledLastDate;
        private Controls.DateTimePicker txtCurrentStatementDate;
    }
}
