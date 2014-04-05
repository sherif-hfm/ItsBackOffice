namespace BackOfficeUI.Accounting
{
    partial class frmChequeBook
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
            BackOfficeUI.Controls.Label lblStartNumber;
            BackOfficeUI.Controls.Label lblnumEnd;
            this.dgrdChequeBook = new System.Windows.Forms.DataGridView();
            this.clmChequeBookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCheuqeBookName_Ara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCheuqeBookName_Eng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmChequeStartNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmChequeEndNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtArabicName = new BackOfficeUI.Controls.TextBox();
            this.lbl_ArabicName = new BackOfficeUI.Controls.Label();
            this.txtEnglishName = new BackOfficeUI.Controls.TextBox();
            this.cbxCurrency = new BackOfficeUI.Controls.ComboBox();
            this.lblCurrency = new BackOfficeUI.Controls.Label();
            this.cbxBanckAccounts = new BackOfficeUI.Controls.ComboBox();
            this.lblDepitAccount = new BackOfficeUI.Controls.Label();
            this.chkIsDisabled = new BackOfficeUI.Controls.CheckBox();
            this.numStart = new BackOfficeUI.Controls.NumericUpDown();
            this.numEnd = new BackOfficeUI.Controls.NumericUpDown();
            lblEnglishName = new BackOfficeUI.Controls.Label();
            lblStartNumber = new BackOfficeUI.Controls.Label();
            lblnumEnd = new BackOfficeUI.Controls.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdChequeBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEnd)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEnglishName
            // 
            lblEnglishName.AutoSize = true;
            lblEnglishName.Clearable = true;
            lblEnglishName.ContextSearchId = 0;
            lblEnglishName.IsRequired = false;
            lblEnglishName.Location = new System.Drawing.Point(10, 248);
            lblEnglishName.LockedInModes = 25;
            lblEnglishName.Name = "lblEnglishName";
            lblEnglishName.Size = new System.Drawing.Size(106, 19);
            lblEnglishName.TabIndex = 7;
            lblEnglishName.Text = "English Name";
            // 
            // lblStartNumber
            // 
            lblStartNumber.AutoSize = true;
            lblStartNumber.Clearable = true;
            lblStartNumber.ContextSearchId = 0;
            lblStartNumber.IsRequired = false;
            lblStartNumber.Location = new System.Drawing.Point(10, 281);
            lblStartNumber.LockedInModes = 25;
            lblStartNumber.Name = "lblStartNumber";
            lblStartNumber.Size = new System.Drawing.Size(104, 19);
            lblStartNumber.TabIndex = 45;
            lblStartNumber.Text = "Start Number";
            // 
            // lblnumEnd
            // 
            lblnumEnd.AutoSize = true;
            lblnumEnd.Clearable = true;
            lblnumEnd.ContextSearchId = 0;
            lblnumEnd.IsRequired = false;
            lblnumEnd.Location = new System.Drawing.Point(445, 285);
            lblnumEnd.LockedInModes = 25;
            lblnumEnd.Name = "lblnumEnd";
            lblnumEnd.Size = new System.Drawing.Size(98, 19);
            lblnumEnd.TabIndex = 46;
            lblnumEnd.Text = "End Number";
            // 
            // dgrdChequeBook
            // 
            this.dgrdChequeBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrdChequeBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmChequeBookID,
            this.clmCheuqeBookName_Ara,
            this.clmCheuqeBookName_Eng,
            this.clmChequeStartNo,
            this.clmChequeEndNo});
            this.dgrdChequeBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgrdChequeBook.Location = new System.Drawing.Point(0, 44);
            this.dgrdChequeBook.MultiSelect = false;
            this.dgrdChequeBook.Name = "dgrdChequeBook";
            this.dgrdChequeBook.ReadOnly = true;
            this.dgrdChequeBook.RowHeadersVisible = false;
            this.dgrdChequeBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrdChequeBook.Size = new System.Drawing.Size(859, 150);
            this.dgrdChequeBook.TabIndex = 2;
            this.dgrdChequeBook.SelectionChanged += new System.EventHandler(this.dgrdChequeBook_SelectionChanged);
            // 
            // clmChequeBookID
            // 
            this.clmChequeBookID.HeaderText = "";
            this.clmChequeBookID.Name = "clmChequeBookID";
            this.clmChequeBookID.ReadOnly = true;
            this.clmChequeBookID.Visible = false;
            this.clmChequeBookID.Width = 5;
            // 
            // clmCheuqeBookName_Ara
            // 
            this.clmCheuqeBookName_Ara.HeaderText = "Arabic Names";
            this.clmCheuqeBookName_Ara.Name = "clmCheuqeBookName_Ara";
            this.clmCheuqeBookName_Ara.ReadOnly = true;
            this.clmCheuqeBookName_Ara.Width = 180;
            // 
            // clmCheuqeBookName_Eng
            // 
            this.clmCheuqeBookName_Eng.HeaderText = "English Name";
            this.clmCheuqeBookName_Eng.Name = "clmCheuqeBookName_Eng";
            this.clmCheuqeBookName_Eng.ReadOnly = true;
            this.clmCheuqeBookName_Eng.Width = 140;
            // 
            // clmChequeStartNo
            // 
            this.clmChequeStartNo.HeaderText = "Cheque Start No ";
            this.clmChequeStartNo.Name = "clmChequeStartNo";
            this.clmChequeStartNo.ReadOnly = true;
            this.clmChequeStartNo.Width = 120;
            // 
            // clmChequeEndNo
            // 
            this.clmChequeEndNo.HeaderText = "Cheque End No";
            this.clmChequeEndNo.Name = "clmChequeEndNo";
            this.clmChequeEndNo.ReadOnly = true;
            // 
            // txtArabicName
            // 
            this.txtArabicName.BackColor = System.Drawing.Color.White;
            this.txtArabicName.Clearable = true;
            this.txtArabicName.ContextSearchId = 0;
            this.txtArabicName.IsRequired = true;
            this.txtArabicName.Location = new System.Drawing.Point(118, 211);
            this.txtArabicName.LockedInModes = 25;
            this.txtArabicName.MaxLength = 50;
            this.txtArabicName.Name = "txtArabicName";
            this.txtArabicName.Size = new System.Drawing.Size(311, 27);
            this.txtArabicName.TabIndex = 3;
            // 
            // lbl_ArabicName
            // 
            this.lbl_ArabicName.AutoSize = true;
            this.lbl_ArabicName.Clearable = true;
            this.lbl_ArabicName.ContextSearchId = 0;
            this.lbl_ArabicName.IsRequired = false;
            this.lbl_ArabicName.Location = new System.Drawing.Point(10, 215);
            this.lbl_ArabicName.LockedInModes = 25;
            this.lbl_ArabicName.Name = "lbl_ArabicName";
            this.lbl_ArabicName.Size = new System.Drawing.Size(100, 19);
            this.lbl_ArabicName.TabIndex = 5;
            this.lbl_ArabicName.Text = "Arabic Name";
            // 
            // txtEnglishName
            // 
            this.txtEnglishName.BackColor = System.Drawing.Color.White;
            this.txtEnglishName.Clearable = true;
            this.txtEnglishName.ContextSearchId = 0;
            this.txtEnglishName.IsRequired = true;
            this.txtEnglishName.Location = new System.Drawing.Point(118, 244);
            this.txtEnglishName.LockedInModes = 25;
            this.txtEnglishName.MaxLength = 50;
            this.txtEnglishName.Name = "txtEnglishName";
            this.txtEnglishName.Size = new System.Drawing.Size(311, 27);
            this.txtEnglishName.TabIndex = 6;
            // 
            // cbxCurrency
            // 
            this.cbxCurrency.BackColor = System.Drawing.Color.White;
            this.cbxCurrency.Clearable = true;
            this.cbxCurrency.ContextSearchId = 0;
            this.cbxCurrency.DefaultIndex = -1;
            this.cbxCurrency.FormattingEnabled = true;
            this.cbxCurrency.IsRequired = true;
            this.cbxCurrency.Location = new System.Drawing.Point(564, 211);
            this.cbxCurrency.LockedInModes = 25;
            this.cbxCurrency.Name = "cbxCurrency";
            this.cbxCurrency.Size = new System.Drawing.Size(121, 27);
            this.cbxCurrency.TabIndex = 34;
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Clearable = true;
            this.lblCurrency.ContextSearchId = 0;
            this.lblCurrency.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCurrency.IsRequired = false;
            this.lblCurrency.Location = new System.Drawing.Point(445, 215);
            this.lblCurrency.LockedInModes = 25;
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(72, 19);
            this.lblCurrency.TabIndex = 35;
            this.lblCurrency.Text = "Currency";
            // 
            // cbxBanckAccounts
            // 
            this.cbxBanckAccounts.BackColor = System.Drawing.Color.White;
            this.cbxBanckAccounts.Clearable = true;
            this.cbxBanckAccounts.ContextSearchId = 0;
            this.cbxBanckAccounts.DefaultIndex = -1;
            this.cbxBanckAccounts.FormattingEnabled = true;
            this.cbxBanckAccounts.IsRequired = true;
            this.cbxBanckAccounts.Location = new System.Drawing.Point(564, 248);
            this.cbxBanckAccounts.LockedInModes = 25;
            this.cbxBanckAccounts.Name = "cbxBanckAccounts";
            this.cbxBanckAccounts.Size = new System.Drawing.Size(228, 27);
            this.cbxBanckAccounts.TabIndex = 40;
            // 
            // lblDepitAccount
            // 
            this.lblDepitAccount.AutoSize = true;
            this.lblDepitAccount.Clearable = true;
            this.lblDepitAccount.ContextSearchId = 0;
            this.lblDepitAccount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDepitAccount.IsRequired = false;
            this.lblDepitAccount.Location = new System.Drawing.Point(445, 252);
            this.lblDepitAccount.LockedInModes = 25;
            this.lblDepitAccount.Name = "lblDepitAccount";
            this.lblDepitAccount.Size = new System.Drawing.Size(112, 19);
            this.lblDepitAccount.TabIndex = 41;
            this.lblDepitAccount.Text = "Banck Account";
            // 
            // chkIsDisabled
            // 
            this.chkIsDisabled.AutoSize = true;
            this.chkIsDisabled.Clearable = true;
            this.chkIsDisabled.ContextSearchId = 0;
            this.chkIsDisabled.ForeColor = System.Drawing.Color.Black;
            this.chkIsDisabled.IsRequired = false;
            this.chkIsDisabled.Location = new System.Drawing.Point(694, 213);
            this.chkIsDisabled.LockedInModes = 25;
            this.chkIsDisabled.Name = "chkIsDisabled";
            this.chkIsDisabled.Size = new System.Drawing.Size(106, 23);
            this.chkIsDisabled.TabIndex = 42;
            this.chkIsDisabled.Text = "Is Disabled";
            this.chkIsDisabled.UseVisualStyleBackColor = true;
            // 
            // numStart
            // 
            this.numStart.BackColor = System.Drawing.Color.White;
            this.numStart.Clearable = true;
            this.numStart.ContextSearchId = 0;
            this.numStart.IsRequired = true;
            this.numStart.Location = new System.Drawing.Point(118, 277);
            this.numStart.LockedInModes = 25;
            this.numStart.Name = "numStart";
            this.numStart.Size = new System.Drawing.Size(215, 27);
            this.numStart.TabIndex = 43;
            // 
            // numEnd
            // 
            this.numEnd.BackColor = System.Drawing.Color.White;
            this.numEnd.Clearable = true;
            this.numEnd.ContextSearchId = 0;
            this.numEnd.IsRequired = true;
            this.numEnd.Location = new System.Drawing.Point(564, 281);
            this.numEnd.LockedInModes = 25;
            this.numEnd.Name = "numEnd";
            this.numEnd.Size = new System.Drawing.Size(215, 27);
            this.numEnd.TabIndex = 47;
            // 
            // frmChequeBook
            // 
            this.AllowedFunctions = 25;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 401);
            this.Controls.Add(this.numEnd);
            this.Controls.Add(lblnumEnd);
            this.Controls.Add(lblStartNumber);
            this.Controls.Add(this.numStart);
            this.Controls.Add(this.chkIsDisabled);
            this.Controls.Add(this.cbxBanckAccounts);
            this.Controls.Add(this.lblDepitAccount);
            this.Controls.Add(this.cbxCurrency);
            this.Controls.Add(this.lblCurrency);
            this.Controls.Add(lblEnglishName);
            this.Controls.Add(this.txtEnglishName);
            this.Controls.Add(this.lbl_ArabicName);
            this.Controls.Add(this.txtArabicName);
            this.Controls.Add(this.dgrdChequeBook);
            this.Name = "frmChequeBook";
            this.Text = "frmChequeBook";
            this.AddNew += new BackOfficeUI.Controls.frmBaseDB.AddNewDelegate(this.frmChequeBook_AddNew);
            this.Edit += new BackOfficeUI.Controls.frmBaseDB.EditDelegate(this.frmChequeBook_Edit);
            this.Delete += new BackOfficeUI.Controls.frmBaseDB.DeleteDelegate(this.frmChequeBook_Delete);
            this.Save += new BackOfficeUI.Controls.frmBaseDB.SaveDelegate(this.frmChequeBook_Save);
            this.DataMove += new BackOfficeUI.Controls.frmBaseDB.DataMoveDelegate(this.frmChequeBook_DataMove);
            this.Cancel += new BackOfficeUI.Controls.frmBaseDB.CancelDelegate(this.frmChequeBook_Cancel);
            this.DataRefresh += new BackOfficeUI.Controls.frmBaseDB.DataRefreshDelegate(this.frmChequeBook_DataRefresh);
            this.Load += new System.EventHandler(this.frmChequeBook_Load);
            this.Controls.SetChildIndex(this.dgrdChequeBook, 0);
            this.Controls.SetChildIndex(this.txtArabicName, 0);
            this.Controls.SetChildIndex(this.lbl_ArabicName, 0);
            this.Controls.SetChildIndex(this.txtEnglishName, 0);
            this.Controls.SetChildIndex(lblEnglishName, 0);
            this.Controls.SetChildIndex(this.lblCurrency, 0);
            this.Controls.SetChildIndex(this.cbxCurrency, 0);
            this.Controls.SetChildIndex(this.lblDepitAccount, 0);
            this.Controls.SetChildIndex(this.cbxBanckAccounts, 0);
            this.Controls.SetChildIndex(this.chkIsDisabled, 0);
            this.Controls.SetChildIndex(this.numStart, 0);
            this.Controls.SetChildIndex(lblStartNumber, 0);
            this.Controls.SetChildIndex(lblnumEnd, 0);
            this.Controls.SetChildIndex(this.numEnd, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgrdChequeBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEnd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrdChequeBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmChequeBookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCheuqeBookName_Ara;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCheuqeBookName_Eng;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmChequeStartNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmChequeEndNo;
        private Controls.TextBox txtArabicName;
        private Controls.Label lbl_ArabicName;
        private Controls.TextBox txtEnglishName;
        private Controls.ComboBox cbxCurrency;
        private Controls.Label lblCurrency;
        private Controls.ComboBox cbxBanckAccounts;
        private Controls.Label lblDepitAccount;
        private Controls.CheckBox chkIsDisabled;
        private Controls.NumericUpDown numStart;
        private Controls.NumericUpDown numEnd;

    }
}