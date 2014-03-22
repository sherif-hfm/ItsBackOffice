namespace BackOfficeUI.Accounting
{
    partial class frmVoucher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVoucher));
            this.dgrdVouchers = new System.Windows.Forms.DataGridView();
            this.clmVoucherCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEnglishName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmArVoucherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEnEliasName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEliasAr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxValidation5 = new BackOfficeUI.Controls.ComboBox();
            this.cbxValidation4 = new BackOfficeUI.Controls.ComboBox();
            this.cbxValidation3 = new BackOfficeUI.Controls.ComboBox();
            this.cbxValidation2 = new BackOfficeUI.Controls.ComboBox();
            this.cbxValidation1 = new BackOfficeUI.Controls.ComboBox();
            this.lblCheckValueAdding = new BackOfficeUI.Controls.Label();
            this.txtEnExtraField5 = new BackOfficeUI.Controls.TextBox();
            this.txtEnExtraField2 = new BackOfficeUI.Controls.TextBox();
            this.txtEnExtraField3 = new BackOfficeUI.Controls.TextBox();
            this.txtEnExtraField4 = new BackOfficeUI.Controls.TextBox();
            this.lblExtraField2 = new BackOfficeUI.Controls.Label();
            this.lblExtraField3 = new BackOfficeUI.Controls.Label();
            this.lblExtraField4 = new BackOfficeUI.Controls.Label();
            this.lblExtraField5 = new BackOfficeUI.Controls.Label();
            this.txtEnExtraField1 = new BackOfficeUI.Controls.TextBox();
            this.lblExtraField1 = new BackOfficeUI.Controls.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxEnCurrency = new BackOfficeUI.Controls.ComboBox();
            this.cbxArCurrency = new BackOfficeUI.Controls.ComboBox();
            this.cbxDepitAccounts = new BackOfficeUI.Controls.ComboBox();
            this.lblDepitAccount = new BackOfficeUI.Controls.Label();
            this.cbxCreditAccounts = new BackOfficeUI.Controls.ComboBox();
            this.lblCreditAccount = new BackOfficeUI.Controls.Label();
            this.lblVoucherCode = new BackOfficeUI.Controls.Label();
            this.txtVoucherCode = new BackOfficeUI.Controls.TextBox();
            this.lblVoucherName = new BackOfficeUI.Controls.Label();
            this.lblCurrency = new BackOfficeUI.Controls.Label();
            this.lblArabicName = new BackOfficeUI.Controls.Label();
            this.lblEnglishName = new BackOfficeUI.Controls.Label();
            this.txtEnglishName = new BackOfficeUI.Controls.TextBox();
            this.txtArabicName = new BackOfficeUI.Controls.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbxDtlValidation5 = new BackOfficeUI.Controls.ComboBox();
            this.cbxDtlValidation4 = new BackOfficeUI.Controls.ComboBox();
            this.cbxDtlValidation3 = new BackOfficeUI.Controls.ComboBox();
            this.cbxDtlValidation2 = new BackOfficeUI.Controls.ComboBox();
            this.cbxDtlValidation1 = new BackOfficeUI.Controls.ComboBox();
            this.txtArDtlExtraField5 = new BackOfficeUI.Controls.TextBox();
            this.txtArDtlExtraField2 = new BackOfficeUI.Controls.TextBox();
            this.txtArDtlExtraField3 = new BackOfficeUI.Controls.TextBox();
            this.txtArDtlExtraField4 = new BackOfficeUI.Controls.TextBox();
            this.lblDtlExtraField2 = new BackOfficeUI.Controls.Label();
            this.lblDtlExtraField3 = new BackOfficeUI.Controls.Label();
            this.lblDtlExtraField14 = new BackOfficeUI.Controls.Label();
            this.lblDtlExtraField5 = new BackOfficeUI.Controls.Label();
            this.txtArDtlExtraField1 = new BackOfficeUI.Controls.TextBox();
            this.lblDtlExtraField1 = new BackOfficeUI.Controls.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdVouchers)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgrdVouchers
            // 
            resources.ApplyResources(this.dgrdVouchers, "dgrdVouchers");
            this.dgrdVouchers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrdVouchers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmVoucherCode,
            this.clmEnglishName,
            this.clmArVoucherName,
            this.clmEnEliasName,
            this.clmEliasAr});
            this.dgrdVouchers.Name = "dgrdVouchers";
            this.dgrdVouchers.SelectionChanged += new System.EventHandler(this.dgrdVouchers_SelectionChanged);
            // 
            // clmVoucherCode
            // 
            resources.ApplyResources(this.clmVoucherCode, "clmVoucherCode");
            this.clmVoucherCode.Name = "clmVoucherCode";
            // 
            // clmEnglishName
            // 
            resources.ApplyResources(this.clmEnglishName, "clmEnglishName");
            this.clmEnglishName.Name = "clmEnglishName";
            // 
            // clmArVoucherName
            // 
            resources.ApplyResources(this.clmArVoucherName, "clmArVoucherName");
            this.clmArVoucherName.Name = "clmArVoucherName";
            // 
            // clmEnEliasName
            // 
            resources.ApplyResources(this.clmEnEliasName, "clmEnEliasName");
            this.clmEnEliasName.Name = "clmEnEliasName";
            // 
            // clmEliasAr
            // 
            resources.ApplyResources(this.clmEliasAr, "clmEliasAr");
            this.clmEliasAr.Name = "clmEliasAr";
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.cbxValidation5);
            this.groupBox2.Controls.Add(this.cbxValidation4);
            this.groupBox2.Controls.Add(this.cbxValidation3);
            this.groupBox2.Controls.Add(this.cbxValidation2);
            this.groupBox2.Controls.Add(this.cbxValidation1);
            this.groupBox2.Controls.Add(this.lblCheckValueAdding);
            this.groupBox2.Controls.Add(this.txtEnExtraField5);
            this.groupBox2.Controls.Add(this.txtEnExtraField2);
            this.groupBox2.Controls.Add(this.txtEnExtraField3);
            this.groupBox2.Controls.Add(this.txtEnExtraField4);
            this.groupBox2.Controls.Add(this.lblExtraField2);
            this.groupBox2.Controls.Add(this.lblExtraField3);
            this.groupBox2.Controls.Add(this.lblExtraField4);
            this.groupBox2.Controls.Add(this.lblExtraField5);
            this.groupBox2.Controls.Add(this.txtEnExtraField1);
            this.groupBox2.Controls.Add(this.lblExtraField1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // cbxValidation5
            // 
            resources.ApplyResources(this.cbxValidation5, "cbxValidation5");
            this.cbxValidation5.BackColor = System.Drawing.Color.White;
            this.cbxValidation5.FormattingEnabled = true;
            this.cbxValidation5.IsRequired = false;
            this.cbxValidation5.LockedInModes = 25;
            this.cbxValidation5.Name = "cbxValidation5";
            // 
            // cbxValidation4
            // 
            resources.ApplyResources(this.cbxValidation4, "cbxValidation4");
            this.cbxValidation4.BackColor = System.Drawing.Color.White;
            this.cbxValidation4.FormattingEnabled = true;
            this.cbxValidation4.IsRequired = false;
            this.cbxValidation4.LockedInModes = 25;
            this.cbxValidation4.Name = "cbxValidation4";
            // 
            // cbxValidation3
            // 
            resources.ApplyResources(this.cbxValidation3, "cbxValidation3");
            this.cbxValidation3.BackColor = System.Drawing.Color.White;
            this.cbxValidation3.FormattingEnabled = true;
            this.cbxValidation3.IsRequired = false;
            this.cbxValidation3.LockedInModes = 25;
            this.cbxValidation3.Name = "cbxValidation3";
            // 
            // cbxValidation2
            // 
            resources.ApplyResources(this.cbxValidation2, "cbxValidation2");
            this.cbxValidation2.BackColor = System.Drawing.Color.White;
            this.cbxValidation2.FormattingEnabled = true;
            this.cbxValidation2.IsRequired = false;
            this.cbxValidation2.LockedInModes = 25;
            this.cbxValidation2.Name = "cbxValidation2";
            // 
            // cbxValidation1
            // 
            resources.ApplyResources(this.cbxValidation1, "cbxValidation1");
            this.cbxValidation1.BackColor = System.Drawing.Color.White;
            this.cbxValidation1.FormattingEnabled = true;
            this.cbxValidation1.IsRequired = false;
            this.cbxValidation1.LockedInModes = 25;
            this.cbxValidation1.Name = "cbxValidation1";
            // 
            // lblCheckValueAdding
            // 
            resources.ApplyResources(this.lblCheckValueAdding, "lblCheckValueAdding");
            this.lblCheckValueAdding.IsRequired = false;
            this.lblCheckValueAdding.LockedInModes = 25;
            this.lblCheckValueAdding.Name = "lblCheckValueAdding";
            // 
            // txtEnExtraField5
            // 
            resources.ApplyResources(this.txtEnExtraField5, "txtEnExtraField5");
            this.txtEnExtraField5.BackColor = System.Drawing.Color.White;
            this.txtEnExtraField5.IsRequired = false;
            this.txtEnExtraField5.LockedInModes = 25;
            this.txtEnExtraField5.Name = "txtEnExtraField5";
            // 
            // txtEnExtraField2
            // 
            resources.ApplyResources(this.txtEnExtraField2, "txtEnExtraField2");
            this.txtEnExtraField2.BackColor = System.Drawing.Color.White;
            this.txtEnExtraField2.IsRequired = false;
            this.txtEnExtraField2.LockedInModes = 25;
            this.txtEnExtraField2.Name = "txtEnExtraField2";
            // 
            // txtEnExtraField3
            // 
            resources.ApplyResources(this.txtEnExtraField3, "txtEnExtraField3");
            this.txtEnExtraField3.BackColor = System.Drawing.Color.White;
            this.txtEnExtraField3.IsRequired = false;
            this.txtEnExtraField3.LockedInModes = 25;
            this.txtEnExtraField3.Name = "txtEnExtraField3";
            // 
            // txtEnExtraField4
            // 
            resources.ApplyResources(this.txtEnExtraField4, "txtEnExtraField4");
            this.txtEnExtraField4.BackColor = System.Drawing.Color.White;
            this.txtEnExtraField4.IsRequired = false;
            this.txtEnExtraField4.LockedInModes = 25;
            this.txtEnExtraField4.Name = "txtEnExtraField4";
            // 
            // lblExtraField2
            // 
            resources.ApplyResources(this.lblExtraField2, "lblExtraField2");
            this.lblExtraField2.IsRequired = false;
            this.lblExtraField2.LockedInModes = 25;
            this.lblExtraField2.Name = "lblExtraField2";
            // 
            // lblExtraField3
            // 
            resources.ApplyResources(this.lblExtraField3, "lblExtraField3");
            this.lblExtraField3.IsRequired = false;
            this.lblExtraField3.LockedInModes = 25;
            this.lblExtraField3.Name = "lblExtraField3";
            // 
            // lblExtraField4
            // 
            resources.ApplyResources(this.lblExtraField4, "lblExtraField4");
            this.lblExtraField4.IsRequired = false;
            this.lblExtraField4.LockedInModes = 25;
            this.lblExtraField4.Name = "lblExtraField4";
            // 
            // lblExtraField5
            // 
            resources.ApplyResources(this.lblExtraField5, "lblExtraField5");
            this.lblExtraField5.IsRequired = false;
            this.lblExtraField5.LockedInModes = 25;
            this.lblExtraField5.Name = "lblExtraField5";
            // 
            // txtEnExtraField1
            // 
            resources.ApplyResources(this.txtEnExtraField1, "txtEnExtraField1");
            this.txtEnExtraField1.BackColor = System.Drawing.Color.White;
            this.txtEnExtraField1.IsRequired = false;
            this.txtEnExtraField1.LockedInModes = 25;
            this.txtEnExtraField1.Name = "txtEnExtraField1";
            // 
            // lblExtraField1
            // 
            resources.ApplyResources(this.lblExtraField1, "lblExtraField1");
            this.lblExtraField1.IsRequired = false;
            this.lblExtraField1.LockedInModes = 25;
            this.lblExtraField1.Name = "lblExtraField1";
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.cbxEnCurrency);
            this.groupBox1.Controls.Add(this.cbxArCurrency);
            this.groupBox1.Controls.Add(this.cbxDepitAccounts);
            this.groupBox1.Controls.Add(this.lblDepitAccount);
            this.groupBox1.Controls.Add(this.cbxCreditAccounts);
            this.groupBox1.Controls.Add(this.lblCreditAccount);
            this.groupBox1.Controls.Add(this.lblVoucherCode);
            this.groupBox1.Controls.Add(this.txtVoucherCode);
            this.groupBox1.Controls.Add(this.lblVoucherName);
            this.groupBox1.Controls.Add(this.lblCurrency);
            this.groupBox1.Controls.Add(this.lblArabicName);
            this.groupBox1.Controls.Add(this.lblEnglishName);
            this.groupBox1.Controls.Add(this.txtEnglishName);
            this.groupBox1.Controls.Add(this.txtArabicName);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // cbxEnCurrency
            // 
            resources.ApplyResources(this.cbxEnCurrency, "cbxEnCurrency");
            this.cbxEnCurrency.BackColor = System.Drawing.Color.White;
            this.cbxEnCurrency.FormattingEnabled = true;
            this.cbxEnCurrency.IsRequired = false;
            this.cbxEnCurrency.LockedInModes = 25;
            this.cbxEnCurrency.Name = "cbxEnCurrency";
            // 
            // cbxArCurrency
            // 
            resources.ApplyResources(this.cbxArCurrency, "cbxArCurrency");
            this.cbxArCurrency.BackColor = System.Drawing.Color.White;
            this.cbxArCurrency.FormattingEnabled = true;
            this.cbxArCurrency.IsRequired = false;
            this.cbxArCurrency.LockedInModes = 25;
            this.cbxArCurrency.Name = "cbxArCurrency";
            // 
            // cbxDepitAccounts
            // 
            resources.ApplyResources(this.cbxDepitAccounts, "cbxDepitAccounts");
            this.cbxDepitAccounts.BackColor = System.Drawing.Color.White;
            this.cbxDepitAccounts.FormattingEnabled = true;
            this.cbxDepitAccounts.IsRequired = false;
            this.cbxDepitAccounts.LockedInModes = 25;
            this.cbxDepitAccounts.Name = "cbxDepitAccounts";
            // 
            // lblDepitAccount
            // 
            resources.ApplyResources(this.lblDepitAccount, "lblDepitAccount");
            this.lblDepitAccount.IsRequired = false;
            this.lblDepitAccount.LockedInModes = 25;
            this.lblDepitAccount.Name = "lblDepitAccount";
            // 
            // cbxCreditAccounts
            // 
            resources.ApplyResources(this.cbxCreditAccounts, "cbxCreditAccounts");
            this.cbxCreditAccounts.BackColor = System.Drawing.Color.White;
            this.cbxCreditAccounts.FormattingEnabled = true;
            this.cbxCreditAccounts.IsRequired = false;
            this.cbxCreditAccounts.LockedInModes = 25;
            this.cbxCreditAccounts.Name = "cbxCreditAccounts";
            // 
            // lblCreditAccount
            // 
            resources.ApplyResources(this.lblCreditAccount, "lblCreditAccount");
            this.lblCreditAccount.IsRequired = false;
            this.lblCreditAccount.LockedInModes = 25;
            this.lblCreditAccount.Name = "lblCreditAccount";
            // 
            // lblVoucherCode
            // 
            resources.ApplyResources(this.lblVoucherCode, "lblVoucherCode");
            this.lblVoucherCode.IsRequired = false;
            this.lblVoucherCode.LockedInModes = 25;
            this.lblVoucherCode.Name = "lblVoucherCode";
            // 
            // txtVoucherCode
            // 
            resources.ApplyResources(this.txtVoucherCode, "txtVoucherCode");
            this.txtVoucherCode.BackColor = System.Drawing.Color.White;
            this.txtVoucherCode.IsRequired = false;
            this.txtVoucherCode.LockedInModes = 25;
            this.txtVoucherCode.Name = "txtVoucherCode";
            // 
            // lblVoucherName
            // 
            resources.ApplyResources(this.lblVoucherName, "lblVoucherName");
            this.lblVoucherName.IsRequired = false;
            this.lblVoucherName.LockedInModes = 25;
            this.lblVoucherName.Name = "lblVoucherName";
            // 
            // lblCurrency
            // 
            resources.ApplyResources(this.lblCurrency, "lblCurrency");
            this.lblCurrency.IsRequired = false;
            this.lblCurrency.LockedInModes = 25;
            this.lblCurrency.Name = "lblCurrency";
            // 
            // lblArabicName
            // 
            resources.ApplyResources(this.lblArabicName, "lblArabicName");
            this.lblArabicName.IsRequired = false;
            this.lblArabicName.LockedInModes = 25;
            this.lblArabicName.Name = "lblArabicName";
            // 
            // lblEnglishName
            // 
            resources.ApplyResources(this.lblEnglishName, "lblEnglishName");
            this.lblEnglishName.IsRequired = false;
            this.lblEnglishName.LockedInModes = 25;
            this.lblEnglishName.Name = "lblEnglishName";
            // 
            // txtEnglishName
            // 
            resources.ApplyResources(this.txtEnglishName, "txtEnglishName");
            this.txtEnglishName.BackColor = System.Drawing.Color.White;
            this.txtEnglishName.IsRequired = false;
            this.txtEnglishName.LockedInModes = 25;
            this.txtEnglishName.Name = "txtEnglishName";
            // 
            // txtArabicName
            // 
            resources.ApplyResources(this.txtArabicName, "txtArabicName");
            this.txtArabicName.BackColor = System.Drawing.Color.White;
            this.txtArabicName.IsRequired = false;
            this.txtArabicName.LockedInModes = 25;
            this.txtArabicName.Name = "txtArabicName";
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Controls.Add(this.cbxDtlValidation5);
            this.groupBox3.Controls.Add(this.cbxDtlValidation4);
            this.groupBox3.Controls.Add(this.cbxDtlValidation3);
            this.groupBox3.Controls.Add(this.cbxDtlValidation2);
            this.groupBox3.Controls.Add(this.cbxDtlValidation1);
            this.groupBox3.Controls.Add(this.txtArDtlExtraField5);
            this.groupBox3.Controls.Add(this.txtArDtlExtraField2);
            this.groupBox3.Controls.Add(this.txtArDtlExtraField3);
            this.groupBox3.Controls.Add(this.txtArDtlExtraField4);
            this.groupBox3.Controls.Add(this.lblDtlExtraField2);
            this.groupBox3.Controls.Add(this.lblDtlExtraField3);
            this.groupBox3.Controls.Add(this.lblDtlExtraField14);
            this.groupBox3.Controls.Add(this.lblDtlExtraField5);
            this.groupBox3.Controls.Add(this.txtArDtlExtraField1);
            this.groupBox3.Controls.Add(this.lblDtlExtraField1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // cbxDtlValidation5
            // 
            resources.ApplyResources(this.cbxDtlValidation5, "cbxDtlValidation5");
            this.cbxDtlValidation5.BackColor = System.Drawing.Color.White;
            this.cbxDtlValidation5.FormattingEnabled = true;
            this.cbxDtlValidation5.IsRequired = false;
            this.cbxDtlValidation5.LockedInModes = 25;
            this.cbxDtlValidation5.Name = "cbxDtlValidation5";
            // 
            // cbxDtlValidation4
            // 
            resources.ApplyResources(this.cbxDtlValidation4, "cbxDtlValidation4");
            this.cbxDtlValidation4.BackColor = System.Drawing.Color.White;
            this.cbxDtlValidation4.FormattingEnabled = true;
            this.cbxDtlValidation4.IsRequired = false;
            this.cbxDtlValidation4.LockedInModes = 25;
            this.cbxDtlValidation4.Name = "cbxDtlValidation4";
            // 
            // cbxDtlValidation3
            // 
            resources.ApplyResources(this.cbxDtlValidation3, "cbxDtlValidation3");
            this.cbxDtlValidation3.BackColor = System.Drawing.Color.White;
            this.cbxDtlValidation3.FormattingEnabled = true;
            this.cbxDtlValidation3.IsRequired = false;
            this.cbxDtlValidation3.LockedInModes = 25;
            this.cbxDtlValidation3.Name = "cbxDtlValidation3";
            // 
            // cbxDtlValidation2
            // 
            resources.ApplyResources(this.cbxDtlValidation2, "cbxDtlValidation2");
            this.cbxDtlValidation2.BackColor = System.Drawing.Color.White;
            this.cbxDtlValidation2.FormattingEnabled = true;
            this.cbxDtlValidation2.IsRequired = false;
            this.cbxDtlValidation2.LockedInModes = 25;
            this.cbxDtlValidation2.Name = "cbxDtlValidation2";
            // 
            // cbxDtlValidation1
            // 
            resources.ApplyResources(this.cbxDtlValidation1, "cbxDtlValidation1");
            this.cbxDtlValidation1.BackColor = System.Drawing.Color.White;
            this.cbxDtlValidation1.FormattingEnabled = true;
            this.cbxDtlValidation1.IsRequired = false;
            this.cbxDtlValidation1.LockedInModes = 25;
            this.cbxDtlValidation1.Name = "cbxDtlValidation1";
            // 
            // txtArDtlExtraField5
            // 
            resources.ApplyResources(this.txtArDtlExtraField5, "txtArDtlExtraField5");
            this.txtArDtlExtraField5.BackColor = System.Drawing.Color.White;
            this.txtArDtlExtraField5.IsRequired = false;
            this.txtArDtlExtraField5.LockedInModes = 25;
            this.txtArDtlExtraField5.Name = "txtArDtlExtraField5";
            // 
            // txtArDtlExtraField2
            // 
            resources.ApplyResources(this.txtArDtlExtraField2, "txtArDtlExtraField2");
            this.txtArDtlExtraField2.BackColor = System.Drawing.Color.White;
            this.txtArDtlExtraField2.IsRequired = false;
            this.txtArDtlExtraField2.LockedInModes = 25;
            this.txtArDtlExtraField2.Name = "txtArDtlExtraField2";
            // 
            // txtArDtlExtraField3
            // 
            resources.ApplyResources(this.txtArDtlExtraField3, "txtArDtlExtraField3");
            this.txtArDtlExtraField3.BackColor = System.Drawing.Color.White;
            this.txtArDtlExtraField3.IsRequired = false;
            this.txtArDtlExtraField3.LockedInModes = 25;
            this.txtArDtlExtraField3.Name = "txtArDtlExtraField3";
            // 
            // txtArDtlExtraField4
            // 
            resources.ApplyResources(this.txtArDtlExtraField4, "txtArDtlExtraField4");
            this.txtArDtlExtraField4.BackColor = System.Drawing.Color.White;
            this.txtArDtlExtraField4.IsRequired = false;
            this.txtArDtlExtraField4.LockedInModes = 25;
            this.txtArDtlExtraField4.Name = "txtArDtlExtraField4";
            // 
            // lblDtlExtraField2
            // 
            resources.ApplyResources(this.lblDtlExtraField2, "lblDtlExtraField2");
            this.lblDtlExtraField2.IsRequired = false;
            this.lblDtlExtraField2.LockedInModes = 25;
            this.lblDtlExtraField2.Name = "lblDtlExtraField2";
            // 
            // lblDtlExtraField3
            // 
            resources.ApplyResources(this.lblDtlExtraField3, "lblDtlExtraField3");
            this.lblDtlExtraField3.IsRequired = false;
            this.lblDtlExtraField3.LockedInModes = 25;
            this.lblDtlExtraField3.Name = "lblDtlExtraField3";
            // 
            // lblDtlExtraField14
            // 
            resources.ApplyResources(this.lblDtlExtraField14, "lblDtlExtraField14");
            this.lblDtlExtraField14.IsRequired = false;
            this.lblDtlExtraField14.LockedInModes = 25;
            this.lblDtlExtraField14.Name = "lblDtlExtraField14";
            // 
            // lblDtlExtraField5
            // 
            resources.ApplyResources(this.lblDtlExtraField5, "lblDtlExtraField5");
            this.lblDtlExtraField5.IsRequired = false;
            this.lblDtlExtraField5.LockedInModes = 25;
            this.lblDtlExtraField5.Name = "lblDtlExtraField5";
            // 
            // txtArDtlExtraField1
            // 
            resources.ApplyResources(this.txtArDtlExtraField1, "txtArDtlExtraField1");
            this.txtArDtlExtraField1.BackColor = System.Drawing.Color.White;
            this.txtArDtlExtraField1.IsRequired = false;
            this.txtArDtlExtraField1.LockedInModes = 25;
            this.txtArDtlExtraField1.Name = "txtArDtlExtraField1";
            // 
            // lblDtlExtraField1
            // 
            resources.ApplyResources(this.lblDtlExtraField1, "lblDtlExtraField1");
            this.lblDtlExtraField1.IsRequired = false;
            this.lblDtlExtraField1.LockedInModes = 25;
            this.lblDtlExtraField1.Name = "lblDtlExtraField1";
            // 
            // frmVoucher
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgrdVouchers);
            this.Name = "frmVoucher";
            this.AddNew += new BackOfficeUI.Controls.frmBaseDB.AddNewDelegate(this.frmVoucher_AddNew);
            this.Edit += new BackOfficeUI.Controls.frmBaseDB.EditDelegate(this.frmVoucher_Edit);
            this.Delete += new BackOfficeUI.Controls.frmBaseDB.DeleteDelegate(this.frmVoucher_Delete);
            this.Save += new BackOfficeUI.Controls.frmBaseDB.SaveDelegate(this.frmVoucher_Save);
            this.DataMove += new BackOfficeUI.Controls.frmBaseDB.DataMoveDelegate(this.frmVoucher_DataMove);
            this.Cancel += new BackOfficeUI.Controls.frmBaseDB.CancelDelegate(this.frmVoucher_Cancel);
            this.DataRefresh += new BackOfficeUI.Controls.frmBaseDB.DataRefreshDelegate(this.frmVoucher_DataRefresh);
            this.Load += new System.EventHandler(this.frmVoucher_Load);
            this.Controls.SetChildIndex(this.dgrdVouchers, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgrdVouchers)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrdVouchers;
        private System.Windows.Forms.GroupBox groupBox2;
        private Controls.Label lblExtraField1;
        private Controls.TextBox txtEnExtraField1;
        private Controls.Label lblExtraField2;
        private Controls.Label lblExtraField3;
        private Controls.Label lblExtraField4;
        private Controls.Label lblExtraField5;
        private Controls.TextBox txtEnExtraField2;
        private Controls.TextBox txtEnExtraField3;
        private Controls.TextBox txtEnExtraField4;
        private Controls.TextBox txtEnExtraField5;
        private Controls.Label lblCheckValueAdding;
        private Controls.ComboBox cbxValidation1;
        private Controls.ComboBox cbxValidation5;
        private Controls.ComboBox cbxValidation4;
        private Controls.ComboBox cbxValidation3;
        private Controls.ComboBox cbxValidation2;
        private System.Windows.Forms.GroupBox groupBox1;
        private Controls.Label lblCreditAccount;
        private Controls.Label lblVoucherCode;
        private Controls.TextBox txtVoucherCode;
        private Controls.Label lblVoucherName;
        private Controls.Label lblCurrency;
        private Controls.Label lblArabicName;
        private Controls.Label lblEnglishName;
        private Controls.TextBox txtEnglishName;
        private Controls.TextBox txtArabicName;
        private System.Windows.Forms.GroupBox groupBox3;
        private Controls.ComboBox cbxDtlValidation5;
        private Controls.ComboBox cbxDtlValidation4;
        private Controls.ComboBox cbxDtlValidation3;
        private Controls.ComboBox cbxDtlValidation2;
        private Controls.ComboBox cbxDtlValidation1;
        private Controls.TextBox txtArDtlExtraField5;
        private Controls.TextBox txtArDtlExtraField2;
        private Controls.TextBox txtArDtlExtraField3;
        private Controls.TextBox txtArDtlExtraField4;
        private Controls.Label lblDtlExtraField2;
        private Controls.Label lblDtlExtraField3;
        private Controls.Label lblDtlExtraField14;
        private Controls.Label lblDtlExtraField5;
        private Controls.TextBox txtArDtlExtraField1;
        private Controls.Label lblDtlExtraField1;
        private Controls.ComboBox cbxCreditAccounts;
        private Controls.ComboBox cbxDepitAccounts;
        private Controls.Label lblDepitAccount;
        private Controls.ComboBox cbxEnCurrency;
        private Controls.ComboBox cbxArCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmVoucherCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEnglishName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmArVoucherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEnEliasName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEliasAr;
    }
}