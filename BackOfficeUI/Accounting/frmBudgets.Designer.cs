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
            BackOfficeUI.Controls.Label lblEnglishName;
            this.dgrdBudget = new System.Windows.Forms.DataGridView();
            this.clmBudgetId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEnglishName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmArName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIsDisabled = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgrdBudgetDetails = new System.Windows.Forms.DataGridView();
            this.clmBudgetDetailID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBudgetYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBugetAccount = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clmBugetCostCenter = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clmBugetLocation = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clmBdgtDepitAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBdgtCreditAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBdgttBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBdgtFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBdgtTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkIsDisabled = new BackOfficeUI.Controls.CheckBox();
            this.cbxYear = new BackOfficeUI.Controls.ComboBox();
            this.txtEnglishName = new BackOfficeUI.Controls.TextBox();
            this.lbl_ArabicName = new BackOfficeUI.Controls.Label();
            this.txtArabicName = new BackOfficeUI.Controls.TextBox();
            this.lblYear = new BackOfficeUI.Controls.Label();
            lblEnglishName = new BackOfficeUI.Controls.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdBudget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdBudgetDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEnglishName
            // 
            lblEnglishName.AutoSize = true;
            lblEnglishName.Clearable = true;
            lblEnglishName.ContextSearchId = 0;
            lblEnglishName.IsRequired = false;
            lblEnglishName.Location = new System.Drawing.Point(2, 243);
            lblEnglishName.LockedInModes = 25;
            lblEnglishName.Name = "lblEnglishName";
            lblEnglishName.Size = new System.Drawing.Size(106, 19);
            lblEnglishName.TabIndex = 46;
            lblEnglishName.Text = "English Name";
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
            this.dgrdBudgetDetails.Enabled = false;
            this.dgrdBudgetDetails.Location = new System.Drawing.Point(0, 275);
            this.dgrdBudgetDetails.MultiSelect = false;
            this.dgrdBudgetDetails.Name = "dgrdBudgetDetails";
            this.dgrdBudgetDetails.RowHeadersVisible = false;
            this.dgrdBudgetDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrdBudgetDetails.Size = new System.Drawing.Size(859, 178);
            this.dgrdBudgetDetails.TabIndex = 3;
            // 
            // clmBudgetDetailID
            // 
            this.clmBudgetDetailID.HeaderText = "";
            this.clmBudgetDetailID.Name = "clmBudgetDetailID";
            this.clmBudgetDetailID.Visible = false;
            this.clmBudgetDetailID.Width = 5;
            // 
            // clmBudgetYear
            // 
            this.clmBudgetYear.HeaderText = "Buget Year";
            this.clmBudgetYear.Name = "clmBudgetYear";
            this.clmBudgetYear.Width = 80;
            // 
            // clmBugetAccount
            // 
            this.clmBugetAccount.HeaderText = "Budget Account";
            this.clmBugetAccount.Name = "clmBugetAccount";
            this.clmBugetAccount.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmBugetAccount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // clmBugetCostCenter
            // 
            this.clmBugetCostCenter.HeaderText = "Buget Cost Center";
            this.clmBugetCostCenter.Name = "clmBugetCostCenter";
            this.clmBugetCostCenter.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmBugetCostCenter.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmBugetCostCenter.Width = 140;
            // 
            // clmBugetLocation
            // 
            this.clmBugetLocation.HeaderText = "Budget Location";
            this.clmBugetLocation.Name = "clmBugetLocation";
            this.clmBugetLocation.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmBugetLocation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // clmBdgtDepitAmount
            // 
            this.clmBdgtDepitAmount.HeaderText = "Depit Amount";
            this.clmBdgtDepitAmount.Name = "clmBdgtDepitAmount";
            // 
            // clmBdgtCreditAmount
            // 
            this.clmBdgtCreditAmount.HeaderText = "Credit Amount";
            this.clmBdgtCreditAmount.Name = "clmBdgtCreditAmount";
            // 
            // clmBdgttBalance
            // 
            this.clmBdgttBalance.HeaderText = "Balance";
            this.clmBdgttBalance.Name = "clmBdgttBalance";
            // 
            // clmBdgtFrom
            // 
            this.clmBdgtFrom.HeaderText = "From";
            this.clmBdgtFrom.Name = "clmBdgtFrom";
            // 
            // clmBdgtTo
            // 
            this.clmBdgtTo.HeaderText = "To";
            this.clmBdgtTo.Name = "clmBdgtTo";
            // 
            // chkIsDisabled
            // 
            this.chkIsDisabled.AutoSize = true;
            this.chkIsDisabled.Clearable = true;
            this.chkIsDisabled.ContextSearchId = 0;
            this.chkIsDisabled.ForeColor = System.Drawing.Color.Black;
            this.chkIsDisabled.IsRequired = false;
            this.chkIsDisabled.Location = new System.Drawing.Point(702, 204);
            this.chkIsDisabled.LockedInModes = 25;
            this.chkIsDisabled.Name = "chkIsDisabled";
            this.chkIsDisabled.Size = new System.Drawing.Size(106, 23);
            this.chkIsDisabled.TabIndex = 48;
            this.chkIsDisabled.Text = "Is Disabled";
            this.chkIsDisabled.UseVisualStyleBackColor = true;
            // 
            // cbxYear
            // 
            this.cbxYear.BackColor = System.Drawing.Color.White;
            this.cbxYear.Clearable = true;
            this.cbxYear.ContextSearchId = 0;
            this.cbxYear.DefaultIndex = -1;
            this.cbxYear.FormattingEnabled = true;
            this.cbxYear.IsRequired = true;
            this.cbxYear.Location = new System.Drawing.Point(535, 206);
            this.cbxYear.LockedInModes = 25;
            this.cbxYear.Name = "cbxYear";
            this.cbxYear.Size = new System.Drawing.Size(121, 27);
            this.cbxYear.TabIndex = 47;
            // 
            // txtEnglishName
            // 
            this.txtEnglishName.BackColor = System.Drawing.Color.White;
            this.txtEnglishName.Clearable = true;
            this.txtEnglishName.ContextSearchId = 0;
            this.txtEnglishName.IsRequired = true;
            this.txtEnglishName.Location = new System.Drawing.Point(110, 239);
            this.txtEnglishName.LockedInModes = 25;
            this.txtEnglishName.MaxLength = 50;
            this.txtEnglishName.Name = "txtEnglishName";
            this.txtEnglishName.Size = new System.Drawing.Size(311, 27);
            this.txtEnglishName.TabIndex = 45;
            // 
            // lbl_ArabicName
            // 
            this.lbl_ArabicName.AutoSize = true;
            this.lbl_ArabicName.Clearable = true;
            this.lbl_ArabicName.ContextSearchId = 0;
            this.lbl_ArabicName.IsRequired = false;
            this.lbl_ArabicName.Location = new System.Drawing.Point(2, 210);
            this.lbl_ArabicName.LockedInModes = 25;
            this.lbl_ArabicName.Name = "lbl_ArabicName";
            this.lbl_ArabicName.Size = new System.Drawing.Size(100, 19);
            this.lbl_ArabicName.TabIndex = 44;
            this.lbl_ArabicName.Text = "Arabic Name";
            // 
            // txtArabicName
            // 
            this.txtArabicName.BackColor = System.Drawing.Color.White;
            this.txtArabicName.Clearable = true;
            this.txtArabicName.ContextSearchId = 0;
            this.txtArabicName.IsRequired = true;
            this.txtArabicName.Location = new System.Drawing.Point(110, 206);
            this.txtArabicName.LockedInModes = 25;
            this.txtArabicName.MaxLength = 50;
            this.txtArabicName.Name = "txtArabicName";
            this.txtArabicName.Size = new System.Drawing.Size(311, 27);
            this.txtArabicName.TabIndex = 43;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Clearable = true;
            this.lblYear.ContextSearchId = 0;
            this.lblYear.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblYear.IsRequired = false;
            this.lblYear.Location = new System.Drawing.Point(458, 210);
            this.lblYear.LockedInModes = 25;
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(41, 19);
            this.lblYear.TabIndex = 49;
            this.lblYear.Text = "Year";
            // 
            // frmBudgets
            // 
            this.AllowedFunctions = 25;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 466);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.chkIsDisabled);
            this.Controls.Add(this.cbxYear);
            this.Controls.Add(lblEnglishName);
            this.Controls.Add(this.txtEnglishName);
            this.Controls.Add(this.lbl_ArabicName);
            this.Controls.Add(this.txtArabicName);
            this.Controls.Add(this.dgrdBudgetDetails);
            this.Controls.Add(this.dgrdBudget);
            this.Name = "frmBudgets";
            this.Text = "frmBudgets";
            this.AddNew += new BackOfficeUI.Controls.frmBaseDB.AddNewDelegate(this.frmBudgets_AddNew);
            this.Edit += new BackOfficeUI.Controls.frmBaseDB.EditDelegate(this.frmBudgets_Edit);
            this.Delete += new BackOfficeUI.Controls.frmBaseDB.DeleteDelegate(this.frmBudgets_Delete);
            this.Save += new BackOfficeUI.Controls.frmBaseDB.SaveDelegate(this.frmBudgets_Save);
            this.DataMove += new BackOfficeUI.Controls.frmBaseDB.DataMoveDelegate(this.frmBudgets_DataMove);
            this.Cancel += new BackOfficeUI.Controls.frmBaseDB.CancelDelegate(this.frmBudgets_Cancel);
            this.DataRefresh += new BackOfficeUI.Controls.frmBaseDB.DataRefreshDelegate(this.frmBudgets_DataRefresh);
            this.Controls.SetChildIndex(this.dgrdBudget, 0);
            this.Controls.SetChildIndex(this.dgrdBudgetDetails, 0);
            this.Controls.SetChildIndex(this.txtArabicName, 0);
            this.Controls.SetChildIndex(this.lbl_ArabicName, 0);
            this.Controls.SetChildIndex(this.txtEnglishName, 0);
            this.Controls.SetChildIndex(lblEnglishName, 0);
            this.Controls.SetChildIndex(this.cbxYear, 0);
            this.Controls.SetChildIndex(this.chkIsDisabled, 0);
            this.Controls.SetChildIndex(this.lblYear, 0);
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
        private System.Windows.Forms.DataGridViewComboBoxColumn clmBugetAccount;
        private System.Windows.Forms.DataGridViewComboBoxColumn clmBugetCostCenter;
        private System.Windows.Forms.DataGridViewComboBoxColumn clmBugetLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBdgtDepitAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBdgtCreditAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBdgttBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBdgtFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBdgtTo;
        private Controls.CheckBox chkIsDisabled;
        private Controls.ComboBox cbxYear;
        private Controls.TextBox txtEnglishName;
        private Controls.Label lbl_ArabicName;
        private Controls.TextBox txtArabicName;
        private Controls.Label lblYear;
    }
}