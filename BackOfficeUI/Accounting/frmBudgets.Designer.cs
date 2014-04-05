namespace BackOfficeUI.Accounting
{
    partial class frmBudgets
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
            this.dgrdBudget = new System.Windows.Forms.DataGridView();
            this.clmBudgetId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEnglishName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmArName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIsDisabled = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgrdBudgetDetails = new System.Windows.Forms.DataGridView();
            this.clmBudgetDetailID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBudgetYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBugetAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBugetCostCenter = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clmBugetLocation = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clmBdgtDepitAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBdgtCreditAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBdgttBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBdgtFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBdgtTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdBudget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdBudgetDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrdBudget
            // 
            this.dgrdBudget.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrdBudget.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmBudgetId,
            this.clmEnglishName,
            this.clmArName,
            this.clmYear,
            this.clmIsDisabled});
            this.dgrdBudget.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgrdBudget.Location = new System.Drawing.Point(0, 44);
            this.dgrdBudget.MultiSelect = false;
            this.dgrdBudget.Name = "dgrdBudget";
            this.dgrdBudget.ReadOnly = true;
            this.dgrdBudget.RowHeadersVisible = false;
            this.dgrdBudget.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrdBudget.Size = new System.Drawing.Size(859, 150);
            this.dgrdBudget.TabIndex = 2;
            this.dgrdBudget.SelectionChanged += new System.EventHandler(this.dgrdBudget_SelectionChanged);
            // 
            // clmBudgetId
            // 
            this.clmBudgetId.HeaderText = "";
            this.clmBudgetId.Name = "clmBudgetId";
            this.clmBudgetId.ReadOnly = true;
            this.clmBudgetId.Visible = false;
            this.clmBudgetId.Width = 5;
            // 
            // clmEnglishName
            // 
            this.clmEnglishName.HeaderText = "English Name";
            this.clmEnglishName.Name = "clmEnglishName";
            this.clmEnglishName.ReadOnly = true;
            this.clmEnglishName.Width = 180;
            // 
            // clmArName
            // 
            this.clmArName.HeaderText = "Arabic Name";
            this.clmArName.Name = "clmArName";
            this.clmArName.ReadOnly = true;
            this.clmArName.Width = 180;
            // 
            // clmYear
            // 
            this.clmYear.HeaderText = "Budget Year";
            this.clmYear.Name = "clmYear";
            this.clmYear.ReadOnly = true;
            this.clmYear.Width = 140;
            // 
            // clmIsDisabled
            // 
            this.clmIsDisabled.HeaderText = "Is Disabled";
            this.clmIsDisabled.Name = "clmIsDisabled";
            this.clmIsDisabled.ReadOnly = true;
            // 
            // dgrdBudgetDetails
            // 
            this.dgrdBudgetDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrdBudgetDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmBudgetDetailID,
            this.clmBudgetYear,
            this.clmBugetAccount,
            this.clmBugetCostCenter,
            this.clmBugetLocation,
            this.clmBdgtDepitAmount,
            this.clmBdgtCreditAmount,
            this.clmBdgttBalance,
            this.clmBdgtFrom,
            this.clmBdgtTo});
            this.dgrdBudgetDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgrdBudgetDetails.Location = new System.Drawing.Point(0, 194);
            this.dgrdBudgetDetails.MultiSelect = false;
            this.dgrdBudgetDetails.Name = "dgrdBudgetDetails";
            this.dgrdBudgetDetails.ReadOnly = true;
            this.dgrdBudgetDetails.RowHeadersVisible = false;
            this.dgrdBudgetDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrdBudgetDetails.Size = new System.Drawing.Size(859, 150);
            this.dgrdBudgetDetails.TabIndex = 3;
            // 
            // clmBudgetDetailID
            // 
            this.clmBudgetDetailID.HeaderText = "";
            this.clmBudgetDetailID.Name = "clmBudgetDetailID";
            this.clmBudgetDetailID.ReadOnly = true;
            this.clmBudgetDetailID.Visible = false;
            this.clmBudgetDetailID.Width = 5;
            // 
            // clmBudgetYear
            // 
            this.clmBudgetYear.HeaderText = "Buget Year";
            this.clmBudgetYear.Name = "clmBudgetYear";
            this.clmBudgetYear.ReadOnly = true;
            this.clmBudgetYear.Width = 80;
            // 
            // clmBugetAccount
            // 
            this.clmBugetAccount.HeaderText = "Budget Account";
            this.clmBugetAccount.Name = "clmBugetAccount";
            this.clmBugetAccount.ReadOnly = true;
            // 
            // clmBugetCostCenter
            // 
            this.clmBugetCostCenter.HeaderText = "Buget Cost Center";
            this.clmBugetCostCenter.Name = "clmBugetCostCenter";
            this.clmBugetCostCenter.ReadOnly = true;
            this.clmBugetCostCenter.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmBugetCostCenter.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmBugetCostCenter.Width = 140;
            // 
            // clmBugetLocation
            // 
            this.clmBugetLocation.HeaderText = "Budget Location";
            this.clmBugetLocation.Name = "clmBugetLocation";
            this.clmBugetLocation.ReadOnly = true;
            this.clmBugetLocation.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmBugetLocation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // clmBdgtDepitAmount
            // 
            this.clmBdgtDepitAmount.HeaderText = "Depit Amount";
            this.clmBdgtDepitAmount.Name = "clmBdgtDepitAmount";
            this.clmBdgtDepitAmount.ReadOnly = true;
            // 
            // clmBdgtCreditAmount
            // 
            this.clmBdgtCreditAmount.HeaderText = "Credit Amount";
            this.clmBdgtCreditAmount.Name = "clmBdgtCreditAmount";
            this.clmBdgtCreditAmount.ReadOnly = true;
            // 
            // clmBdgttBalance
            // 
            this.clmBdgttBalance.HeaderText = "Balance";
            this.clmBdgttBalance.Name = "clmBdgttBalance";
            this.clmBdgttBalance.ReadOnly = true;
            // 
            // clmBdgtFrom
            // 
            this.clmBdgtFrom.HeaderText = "From";
            this.clmBdgtFrom.Name = "clmBdgtFrom";
            this.clmBdgtFrom.ReadOnly = true;
            // 
            // clmBdgtTo
            // 
            this.clmBdgtTo.HeaderText = "To";
            this.clmBdgtTo.Name = "clmBdgtTo";
            this.clmBdgtTo.ReadOnly = true;
            // 
            // frmBudgets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 401);
            this.Controls.Add(this.dgrdBudgetDetails);
            this.Controls.Add(this.dgrdBudget);
            this.Name = "frmBudgets";
            this.Text = "frmBudgets";
            this.Controls.SetChildIndex(this.dgrdBudget, 0);
            this.Controls.SetChildIndex(this.dgrdBudgetDetails, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgrdBudget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdBudgetDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrdBudget;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBudgetId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEnglishName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmArName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIsDisabled;
        private System.Windows.Forms.DataGridView dgrdBudgetDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBudgetDetailID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBudgetYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBugetAccount;
        private System.Windows.Forms.DataGridViewComboBoxColumn clmBugetCostCenter;
        private System.Windows.Forms.DataGridViewComboBoxColumn clmBugetLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBdgtDepitAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBdgtCreditAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBdgttBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBdgtFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBdgtTo;
    }
}