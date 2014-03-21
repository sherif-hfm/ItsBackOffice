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
            this.clmArVoucherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEnglishName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEliasAr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEnEliasName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VoucherTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxValidation5 = new BackOfficeUI.Controls.ComboBox();
            this.cbxValidation4 = new BackOfficeUI.Controls.ComboBox();
            this.cbxValidation3 = new BackOfficeUI.Controls.ComboBox();
            this.cbxValidation2 = new BackOfficeUI.Controls.ComboBox();
            this.cbxValidation1 = new BackOfficeUI.Controls.ComboBox();
            this.lblCheckValueAdding = new BackOfficeUI.Controls.Label();
            this.txtArExtraField1 = new BackOfficeUI.Controls.TextBox();
            this.txtArExtraField5 = new BackOfficeUI.Controls.TextBox();
            this.txtArExtraField4 = new BackOfficeUI.Controls.TextBox();
            this.txtArExtraField3 = new BackOfficeUI.Controls.TextBox();
            this.txtArExtraField2 = new BackOfficeUI.Controls.TextBox();
            this.txtEnExtraField5 = new BackOfficeUI.Controls.TextBox();
            this.txtEnExtraField2 = new BackOfficeUI.Controls.TextBox();
            this.txtEnExtraField3 = new BackOfficeUI.Controls.TextBox();
            this.txtEnExtraField4 = new BackOfficeUI.Controls.TextBox();
            this.lblExtraField2 = new BackOfficeUI.Controls.Label();
            this.lblExtraField3 = new BackOfficeUI.Controls.Label();
            this.lblExtraField4 = new BackOfficeUI.Controls.Label();
            this.lblExtraField5 = new BackOfficeUI.Controls.Label();
            this.txtEnExtraField1 = new BackOfficeUI.Controls.TextBox();
            this.lblEnglish = new BackOfficeUI.Controls.Label();
            this.lblArabic = new BackOfficeUI.Controls.Label();
            this.lblExtraField1 = new BackOfficeUI.Controls.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.txtEnDtlExtraField1 = new BackOfficeUI.Controls.TextBox();
            this.txtEnDtlExtraField5 = new BackOfficeUI.Controls.TextBox();
            this.txtEnDtlExtraField4 = new BackOfficeUI.Controls.TextBox();
            this.txtEnDtlExtraField3 = new BackOfficeUI.Controls.TextBox();
            this.txtEnDtlExtraField2 = new BackOfficeUI.Controls.TextBox();
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
            this.cbxCreditAccounts = new BackOfficeUI.Controls.ComboBox();
            this.cbxDepitAccounts = new BackOfficeUI.Controls.ComboBox();
            this.lblDepitAccount = new BackOfficeUI.Controls.Label();
            this.cbxArCurrency = new BackOfficeUI.Controls.ComboBox();
            this.cbxEnCurrency = new BackOfficeUI.Controls.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdVouchers)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgrdVouchers
            // 
            this.dgrdVouchers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrdVouchers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmVoucherCode,
            this.clmArVoucherName,
            this.clmEnglishName,
            this.clmEliasAr,
            this.clmEnEliasName,
            this.VoucherTypeID});
            resources.ApplyResources(this.dgrdVouchers, "dgrdVouchers");
            this.dgrdVouchers.Name = "dgrdVouchers";
            // 
            // clmVoucherCode
            // 
            resources.ApplyResources(this.clmVoucherCode, "clmVoucherCode");
            this.clmVoucherCode.Name = "clmVoucherCode";
            // 
            // clmArVoucherName
            // 
            resources.ApplyResources(this.clmArVoucherName, "clmArVoucherName");
            this.clmArVoucherName.Name = "clmArVoucherName";
            // 
            // clmEnglishName
            // 
            resources.ApplyResources(this.clmEnglishName, "clmEnglishName");
            this.clmEnglishName.Name = "clmEnglishName";
            // 
            // clmEliasAr
            // 
            resources.ApplyResources(this.clmEliasAr, "clmEliasAr");
            this.clmEliasAr.Name = "clmEliasAr";
            // 
            // clmEnEliasName
            // 
            resources.ApplyResources(this.clmEnEliasName, "clmEnEliasName");
            this.clmEnEliasName.Name = "clmEnEliasName";
            // 
            // VoucherTypeID
            // 
            resources.ApplyResources(this.VoucherTypeID, "VoucherTypeID");
            this.VoucherTypeID.Name = "VoucherTypeID";
            this.VoucherTypeID.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxValidation5);
            this.groupBox2.Controls.Add(this.cbxValidation4);
            this.groupBox2.Controls.Add(this.cbxValidation3);
            this.groupBox2.Controls.Add(this.cbxValidation2);
            this.groupBox2.Controls.Add(this.cbxValidation1);
            this.groupBox2.Controls.Add(this.lblCheckValueAdding);
            this.groupBox2.Controls.Add(this.txtArExtraField1);
            this.groupBox2.Controls.Add(this.txtArExtraField5);
            this.groupBox2.Controls.Add(this.txtArExtraField4);
            this.groupBox2.Controls.Add(this.txtArExtraField3);
            this.groupBox2.Controls.Add(this.txtArExtraField2);
            this.groupBox2.Controls.Add(this.txtEnExtraField5);
            this.groupBox2.Controls.Add(this.txtEnExtraField2);
            this.groupBox2.Controls.Add(this.txtEnExtraField3);
            this.groupBox2.Controls.Add(this.txtEnExtraField4);
            this.groupBox2.Controls.Add(this.lblExtraField2);
            this.groupBox2.Controls.Add(this.lblExtraField3);
            this.groupBox2.Controls.Add(this.lblExtraField4);
            this.groupBox2.Controls.Add(this.lblExtraField5);
            this.groupBox2.Controls.Add(this.txtEnExtraField1);
            this.groupBox2.Controls.Add(this.lblEnglish);
            this.groupBox2.Controls.Add(this.lblArabic);
            this.groupBox2.Controls.Add(this.lblExtraField1);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // cbxValidation5
            // 
            this.cbxValidation5.BackColor = System.Drawing.Color.White;
            this.cbxValidation5.FormattingEnabled = true;
            this.cbxValidation5.IsRequired = false;
            resources.ApplyResources(this.cbxValidation5, "cbxValidation5");
            this.cbxValidation5.LockedInModes = 25;
            this.cbxValidation5.Name = "cbxValidation5";
            // 
            // cbxValidation4
            // 
            this.cbxValidation4.BackColor = System.Drawing.Color.White;
            this.cbxValidation4.FormattingEnabled = true;
            this.cbxValidation4.IsRequired = false;
            resources.ApplyResources(this.cbxValidation4, "cbxValidation4");
            this.cbxValidation4.LockedInModes = 25;
            this.cbxValidation4.Name = "cbxValidation4";
            // 
            // cbxValidation3
            // 
            this.cbxValidation3.BackColor = System.Drawing.Color.White;
            this.cbxValidation3.FormattingEnabled = true;
            this.cbxValidation3.IsRequired = false;
            resources.ApplyResources(this.cbxValidation3, "cbxValidation3");
            this.cbxValidation3.LockedInModes = 25;
            this.cbxValidation3.Name = "cbxValidation3";
            // 
            // cbxValidation2
            // 
            this.cbxValidation2.BackColor = System.Drawing.Color.White;
            this.cbxValidation2.FormattingEnabled = true;
            this.cbxValidation2.IsRequired = false;
            resources.ApplyResources(this.cbxValidation2, "cbxValidation2");
            this.cbxValidation2.LockedInModes = 25;
            this.cbxValidation2.Name = "cbxValidation2";
            // 
            // cbxValidation1
            // 
            this.cbxValidation1.BackColor = System.Drawing.Color.White;
            this.cbxValidation1.FormattingEnabled = true;
            this.cbxValidation1.IsRequired = false;
            resources.ApplyResources(this.cbxValidation1, "cbxValidation1");
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
            // txtArExtraField1
            // 
            this.txtArExtraField1.BackColor = System.Drawing.Color.White;
            this.txtArExtraField1.IsRequired = false;
            resources.ApplyResources(this.txtArExtraField1, "txtArExtraField1");
            this.txtArExtraField1.LockedInModes = 25;
            this.txtArExtraField1.Name = "txtArExtraField1";
            // 
            // txtArExtraField5
            // 
            this.txtArExtraField5.BackColor = System.Drawing.Color.White;
            this.txtArExtraField5.IsRequired = false;
            resources.ApplyResources(this.txtArExtraField5, "txtArExtraField5");
            this.txtArExtraField5.LockedInModes = 25;
            this.txtArExtraField5.Name = "txtArExtraField5";
            // 
            // txtArExtraField4
            // 
            this.txtArExtraField4.BackColor = System.Drawing.Color.White;
            this.txtArExtraField4.IsRequired = false;
            resources.ApplyResources(this.txtArExtraField4, "txtArExtraField4");
            this.txtArExtraField4.LockedInModes = 25;
            this.txtArExtraField4.Name = "txtArExtraField4";
            // 
            // txtArExtraField3
            // 
            this.txtArExtraField3.BackColor = System.Drawing.Color.White;
            this.txtArExtraField3.IsRequired = false;
            resources.ApplyResources(this.txtArExtraField3, "txtArExtraField3");
            this.txtArExtraField3.LockedInModes = 25;
            this.txtArExtraField3.Name = "txtArExtraField3";
            // 
            // txtArExtraField2
            // 
            this.txtArExtraField2.BackColor = System.Drawing.Color.White;
            this.txtArExtraField2.IsRequired = false;
            resources.ApplyResources(this.txtArExtraField2, "txtArExtraField2");
            this.txtArExtraField2.LockedInModes = 25;
            this.txtArExtraField2.Name = "txtArExtraField2";
            // 
            // txtEnExtraField5
            // 
            this.txtEnExtraField5.BackColor = System.Drawing.Color.White;
            this.txtEnExtraField5.IsRequired = false;
            resources.ApplyResources(this.txtEnExtraField5, "txtEnExtraField5");
            this.txtEnExtraField5.LockedInModes = 25;
            this.txtEnExtraField5.Name = "txtEnExtraField5";
            // 
            // txtEnExtraField2
            // 
            this.txtEnExtraField2.BackColor = System.Drawing.Color.White;
            this.txtEnExtraField2.IsRequired = false;
            resources.ApplyResources(this.txtEnExtraField2, "txtEnExtraField2");
            this.txtEnExtraField2.LockedInModes = 25;
            this.txtEnExtraField2.Name = "txtEnExtraField2";
            // 
            // txtEnExtraField3
            // 
            this.txtEnExtraField3.BackColor = System.Drawing.Color.White;
            this.txtEnExtraField3.IsRequired = false;
            resources.ApplyResources(this.txtEnExtraField3, "txtEnExtraField3");
            this.txtEnExtraField3.LockedInModes = 25;
            this.txtEnExtraField3.Name = "txtEnExtraField3";
            // 
            // txtEnExtraField4
            // 
            this.txtEnExtraField4.BackColor = System.Drawing.Color.White;
            this.txtEnExtraField4.IsRequired = false;
            resources.ApplyResources(this.txtEnExtraField4, "txtEnExtraField4");
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
            this.txtEnExtraField1.BackColor = System.Drawing.Color.White;
            this.txtEnExtraField1.IsRequired = false;
            resources.ApplyResources(this.txtEnExtraField1, "txtEnExtraField1");
            this.txtEnExtraField1.LockedInModes = 25;
            this.txtEnExtraField1.Name = "txtEnExtraField1";
            // 
            // lblEnglish
            // 
            resources.ApplyResources(this.lblEnglish, "lblEnglish");
            this.lblEnglish.IsRequired = false;
            this.lblEnglish.LockedInModes = 25;
            this.lblEnglish.Name = "lblEnglish";
            // 
            // lblArabic
            // 
            resources.ApplyResources(this.lblArabic, "lblArabic");
            this.lblArabic.IsRequired = false;
            this.lblArabic.LockedInModes = 25;
            this.lblArabic.Name = "lblArabic";
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
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
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
            this.txtVoucherCode.BackColor = System.Drawing.Color.White;
            this.txtVoucherCode.IsRequired = false;
            resources.ApplyResources(this.txtVoucherCode, "txtVoucherCode");
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
            this.txtEnglishName.BackColor = System.Drawing.Color.White;
            this.txtEnglishName.IsRequired = false;
            resources.ApplyResources(this.txtEnglishName, "txtEnglishName");
            this.txtEnglishName.LockedInModes = 25;
            this.txtEnglishName.Name = "txtEnglishName";
            // 
            // txtArabicName
            // 
            this.txtArabicName.BackColor = System.Drawing.Color.White;
            this.txtArabicName.IsRequired = false;
            resources.ApplyResources(this.txtArabicName, "txtArabicName");
            this.txtArabicName.LockedInModes = 25;
            this.txtArabicName.Name = "txtArabicName";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbxDtlValidation5);
            this.groupBox3.Controls.Add(this.cbxDtlValidation4);
            this.groupBox3.Controls.Add(this.cbxDtlValidation3);
            this.groupBox3.Controls.Add(this.cbxDtlValidation2);
            this.groupBox3.Controls.Add(this.cbxDtlValidation1);
            this.groupBox3.Controls.Add(this.txtEnDtlExtraField1);
            this.groupBox3.Controls.Add(this.txtEnDtlExtraField5);
            this.groupBox3.Controls.Add(this.txtEnDtlExtraField4);
            this.groupBox3.Controls.Add(this.txtEnDtlExtraField3);
            this.groupBox3.Controls.Add(this.txtEnDtlExtraField2);
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
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // cbxDtlValidation5
            // 
            this.cbxDtlValidation5.BackColor = System.Drawing.Color.White;
            this.cbxDtlValidation5.FormattingEnabled = true;
            this.cbxDtlValidation5.IsRequired = false;
            resources.ApplyResources(this.cbxDtlValidation5, "cbxDtlValidation5");
            this.cbxDtlValidation5.LockedInModes = 25;
            this.cbxDtlValidation5.Name = "cbxDtlValidation5";
            // 
            // cbxDtlValidation4
            // 
            this.cbxDtlValidation4.BackColor = System.Drawing.Color.White;
            this.cbxDtlValidation4.FormattingEnabled = true;
            this.cbxDtlValidation4.IsRequired = false;
            resources.ApplyResources(this.cbxDtlValidation4, "cbxDtlValidation4");
            this.cbxDtlValidation4.LockedInModes = 25;
            this.cbxDtlValidation4.Name = "cbxDtlValidation4";
            // 
            // cbxDtlValidation3
            // 
            this.cbxDtlValidation3.BackColor = System.Drawing.Color.White;
            this.cbxDtlValidation3.FormattingEnabled = true;
            this.cbxDtlValidation3.IsRequired = false;
            resources.ApplyResources(this.cbxDtlValidation3, "cbxDtlValidation3");
            this.cbxDtlValidation3.LockedInModes = 25;
            this.cbxDtlValidation3.Name = "cbxDtlValidation3";
            // 
            // cbxDtlValidation2
            // 
            this.cbxDtlValidation2.BackColor = System.Drawing.Color.White;
            this.cbxDtlValidation2.FormattingEnabled = true;
            this.cbxDtlValidation2.IsRequired = false;
            resources.ApplyResources(this.cbxDtlValidation2, "cbxDtlValidation2");
            this.cbxDtlValidation2.LockedInModes = 25;
            this.cbxDtlValidation2.Name = "cbxDtlValidation2";
            // 
            // cbxDtlValidation1
            // 
            this.cbxDtlValidation1.BackColor = System.Drawing.Color.White;
            this.cbxDtlValidation1.FormattingEnabled = true;
            this.cbxDtlValidation1.IsRequired = false;
            resources.ApplyResources(this.cbxDtlValidation1, "cbxDtlValidation1");
            this.cbxDtlValidation1.LockedInModes = 25;
            this.cbxDtlValidation1.Name = "cbxDtlValidation1";
            // 
            // txtEnDtlExtraField1
            // 
            this.txtEnDtlExtraField1.BackColor = System.Drawing.Color.White;
            this.txtEnDtlExtraField1.IsRequired = false;
            resources.ApplyResources(this.txtEnDtlExtraField1, "txtEnDtlExtraField1");
            this.txtEnDtlExtraField1.LockedInModes = 25;
            this.txtEnDtlExtraField1.Name = "txtEnDtlExtraField1";
            // 
            // txtEnDtlExtraField5
            // 
            this.txtEnDtlExtraField5.BackColor = System.Drawing.Color.White;
            this.txtEnDtlExtraField5.IsRequired = false;
            resources.ApplyResources(this.txtEnDtlExtraField5, "txtEnDtlExtraField5");
            this.txtEnDtlExtraField5.LockedInModes = 25;
            this.txtEnDtlExtraField5.Name = "txtEnDtlExtraField5";
            // 
            // txtEnDtlExtraField4
            // 
            this.txtEnDtlExtraField4.BackColor = System.Drawing.Color.White;
            this.txtEnDtlExtraField4.IsRequired = false;
            resources.ApplyResources(this.txtEnDtlExtraField4, "txtEnDtlExtraField4");
            this.txtEnDtlExtraField4.LockedInModes = 25;
            this.txtEnDtlExtraField4.Name = "txtEnDtlExtraField4";
            // 
            // txtEnDtlExtraField3
            // 
            this.txtEnDtlExtraField3.BackColor = System.Drawing.Color.White;
            this.txtEnDtlExtraField3.IsRequired = false;
            resources.ApplyResources(this.txtEnDtlExtraField3, "txtEnDtlExtraField3");
            this.txtEnDtlExtraField3.LockedInModes = 25;
            this.txtEnDtlExtraField3.Name = "txtEnDtlExtraField3";
            // 
            // txtEnDtlExtraField2
            // 
            this.txtEnDtlExtraField2.BackColor = System.Drawing.Color.White;
            this.txtEnDtlExtraField2.IsRequired = false;
            resources.ApplyResources(this.txtEnDtlExtraField2, "txtEnDtlExtraField2");
            this.txtEnDtlExtraField2.LockedInModes = 25;
            this.txtEnDtlExtraField2.Name = "txtEnDtlExtraField2";
            // 
            // txtArDtlExtraField5
            // 
            this.txtArDtlExtraField5.BackColor = System.Drawing.Color.White;
            this.txtArDtlExtraField5.IsRequired = false;
            resources.ApplyResources(this.txtArDtlExtraField5, "txtArDtlExtraField5");
            this.txtArDtlExtraField5.LockedInModes = 25;
            this.txtArDtlExtraField5.Name = "txtArDtlExtraField5";
            // 
            // txtArDtlExtraField2
            // 
            this.txtArDtlExtraField2.BackColor = System.Drawing.Color.White;
            this.txtArDtlExtraField2.IsRequired = false;
            resources.ApplyResources(this.txtArDtlExtraField2, "txtArDtlExtraField2");
            this.txtArDtlExtraField2.LockedInModes = 25;
            this.txtArDtlExtraField2.Name = "txtArDtlExtraField2";
            // 
            // txtArDtlExtraField3
            // 
            this.txtArDtlExtraField3.BackColor = System.Drawing.Color.White;
            this.txtArDtlExtraField3.IsRequired = false;
            resources.ApplyResources(this.txtArDtlExtraField3, "txtArDtlExtraField3");
            this.txtArDtlExtraField3.LockedInModes = 25;
            this.txtArDtlExtraField3.Name = "txtArDtlExtraField3";
            // 
            // txtArDtlExtraField4
            // 
            this.txtArDtlExtraField4.BackColor = System.Drawing.Color.White;
            this.txtArDtlExtraField4.IsRequired = false;
            resources.ApplyResources(this.txtArDtlExtraField4, "txtArDtlExtraField4");
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
            this.txtArDtlExtraField1.BackColor = System.Drawing.Color.White;
            this.txtArDtlExtraField1.IsRequired = false;
            resources.ApplyResources(this.txtArDtlExtraField1, "txtArDtlExtraField1");
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
            // cbxCreditAccounts
            // 
            this.cbxCreditAccounts.BackColor = System.Drawing.Color.White;
            this.cbxCreditAccounts.FormattingEnabled = true;
            this.cbxCreditAccounts.IsRequired = false;
            resources.ApplyResources(this.cbxCreditAccounts, "cbxCreditAccounts");
            this.cbxCreditAccounts.LockedInModes = 25;
            this.cbxCreditAccounts.Name = "cbxCreditAccounts";
            // 
            // cbxDepitAccounts
            // 
            this.cbxDepitAccounts.BackColor = System.Drawing.Color.White;
            this.cbxDepitAccounts.FormattingEnabled = true;
            this.cbxDepitAccounts.IsRequired = false;
            resources.ApplyResources(this.cbxDepitAccounts, "cbxDepitAccounts");
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
            // cbxArCurrency
            // 
            this.cbxArCurrency.BackColor = System.Drawing.Color.White;
            this.cbxArCurrency.FormattingEnabled = true;
            this.cbxArCurrency.IsRequired = false;
            resources.ApplyResources(this.cbxArCurrency, "cbxArCurrency");
            this.cbxArCurrency.LockedInModes = 25;
            this.cbxArCurrency.Name = "cbxArCurrency";
            // 
            // cbxEnCurrency
            // 
            this.cbxEnCurrency.BackColor = System.Drawing.Color.White;
            this.cbxEnCurrency.FormattingEnabled = true;
            this.cbxEnCurrency.IsRequired = false;
            resources.ApplyResources(this.cbxEnCurrency, "cbxEnCurrency");
            this.cbxEnCurrency.LockedInModes = 25;
            this.cbxEnCurrency.Name = "cbxEnCurrency";
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
        private Controls.Label lblEnglish;
        private Controls.Label lblArabic;
        private Controls.Label lblExtraField2;
        private Controls.Label lblExtraField3;
        private Controls.Label lblExtraField4;
        private Controls.Label lblExtraField5;
        private Controls.TextBox txtEnExtraField2;
        private Controls.TextBox txtEnExtraField3;
        private Controls.TextBox txtEnExtraField4;
        private Controls.TextBox txtEnExtraField5;
        private Controls.TextBox txtArExtraField1;
        private Controls.TextBox txtArExtraField5;
        private Controls.TextBox txtArExtraField4;
        private Controls.TextBox txtArExtraField3;
        private Controls.TextBox txtArExtraField2;
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
        private Controls.TextBox txtEnDtlExtraField1;
        private Controls.TextBox txtEnDtlExtraField5;
        private Controls.TextBox txtEnDtlExtraField4;
        private Controls.TextBox txtEnDtlExtraField3;
        private Controls.TextBox txtEnDtlExtraField2;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn clmVoucherCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmArVoucherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEnglishName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEliasAr;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEnEliasName;
        private System.Windows.Forms.DataGridViewTextBoxColumn VoucherTypeID;
        private Controls.ComboBox cbxCreditAccounts;
        private Controls.ComboBox cbxDepitAccounts;
        private Controls.Label lblDepitAccount;
        private Controls.ComboBox cbxEnCurrency;
        private Controls.ComboBox cbxArCurrency;
    }
}