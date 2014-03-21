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
            this.dgrdVouchers = new System.Windows.Forms.DataGridView();
            this.lblVoucherCode = new BackOfficeUI.Controls.Label();
            this.txtVoucherCode = new BackOfficeUI.Controls.TextBox();
            this.lblArabicName = new BackOfficeUI.Controls.Label();
            this.txtArabicName = new BackOfficeUI.Controls.TextBox();
            this.lblEnglishName = new BackOfficeUI.Controls.Label();
            this.txtEnglishName = new BackOfficeUI.Controls.TextBox();
            this.lblCurrency = new BackOfficeUI.Controls.Label();
            this.txtCurrency = new BackOfficeUI.Controls.TextBox();
            this.lblVoucherName = new BackOfficeUI.Controls.Label();
            this.textBox1 = new BackOfficeUI.Controls.TextBox();
            this.lblAccountNumber = new BackOfficeUI.Controls.Label();
            this.textBox2 = new BackOfficeUI.Controls.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new BackOfficeUI.Controls.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdVouchers)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgrdVouchers
            // 
            this.dgrdVouchers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrdVouchers.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgrdVouchers.Location = new System.Drawing.Point(0, 44);
            this.dgrdVouchers.Name = "dgrdVouchers";
            this.dgrdVouchers.Size = new System.Drawing.Size(859, 150);
            this.dgrdVouchers.TabIndex = 2;
            // 
            // lblVoucherCode
            // 
            this.lblVoucherCode.AutoSize = true;
            this.lblVoucherCode.IsRequired = false;
            this.lblVoucherCode.Location = new System.Drawing.Point(761, 49);
            this.lblVoucherCode.LockedInModes = 25;
            this.lblVoucherCode.Name = "lblVoucherCode";
            this.lblVoucherCode.Size = new System.Drawing.Size(92, 19);
            this.lblVoucherCode.TabIndex = 3;
            this.lblVoucherCode.Text = "رمز المستند";
            // 
            // txtVoucherCode
            // 
            this.txtVoucherCode.BackColor = System.Drawing.Color.White;
            this.txtVoucherCode.IsRequired = false;
            this.txtVoucherCode.Location = new System.Drawing.Point(646, 45);
            this.txtVoucherCode.LockedInModes = 25;
            this.txtVoucherCode.Name = "txtVoucherCode";
            this.txtVoucherCode.Size = new System.Drawing.Size(100, 27);
            this.txtVoucherCode.TabIndex = 4;
            // 
            // lblArabicName
            // 
            this.lblArabicName.AutoSize = true;
            this.lblArabicName.IsRequired = false;
            this.lblArabicName.Location = new System.Drawing.Point(537, 49);
            this.lblArabicName.LockedInModes = 25;
            this.lblArabicName.Name = "lblArabicName";
            this.lblArabicName.Size = new System.Drawing.Size(104, 19);
            this.lblArabicName.TabIndex = 5;
            this.lblArabicName.Text = "الأسم بالعربى";
            // 
            // txtArabicName
            // 
            this.txtArabicName.BackColor = System.Drawing.Color.White;
            this.txtArabicName.IsRequired = false;
            this.txtArabicName.Location = new System.Drawing.Point(223, 45);
            this.txtArabicName.LockedInModes = 25;
            this.txtArabicName.Name = "txtArabicName";
            this.txtArabicName.Size = new System.Drawing.Size(287, 27);
            this.txtArabicName.TabIndex = 6;
            // 
            // lblEnglishName
            // 
            this.lblEnglishName.AutoSize = true;
            this.lblEnglishName.IsRequired = false;
            this.lblEnglishName.Location = new System.Drawing.Point(514, 79);
            this.lblEnglishName.LockedInModes = 25;
            this.lblEnglishName.Name = "lblEnglishName";
            this.lblEnglishName.Size = new System.Drawing.Size(127, 19);
            this.lblEnglishName.TabIndex = 7;
            this.lblEnglishName.Text = "الأسم بالأنجليزى ";
            // 
            // txtEnglishName
            // 
            this.txtEnglishName.BackColor = System.Drawing.Color.White;
            this.txtEnglishName.IsRequired = false;
            this.txtEnglishName.Location = new System.Drawing.Point(223, 75);
            this.txtEnglishName.LockedInModes = 25;
            this.txtEnglishName.Name = "txtEnglishName";
            this.txtEnglishName.Size = new System.Drawing.Size(287, 27);
            this.txtEnglishName.TabIndex = 8;
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.IsRequired = false;
            this.lblCurrency.Location = new System.Drawing.Point(166, 18);
            this.lblCurrency.LockedInModes = 25;
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(51, 19);
            this.lblCurrency.TabIndex = 9;
            this.lblCurrency.Text = "العملة";
            // 
            // txtCurrency
            // 
            this.txtCurrency.BackColor = System.Drawing.Color.White;
            this.txtCurrency.IsRequired = false;
            this.txtCurrency.Location = new System.Drawing.Point(117, 45);
            this.txtCurrency.LockedInModes = 25;
            this.txtCurrency.Name = "txtCurrency";
            this.txtCurrency.Size = new System.Drawing.Size(100, 27);
            this.txtCurrency.TabIndex = 10;
            // 
            // lblVoucherName
            // 
            this.lblVoucherName.AutoSize = true;
            this.lblVoucherName.IsRequired = false;
            this.lblVoucherName.Location = new System.Drawing.Point(409, 18);
            this.lblVoucherName.LockedInModes = 25;
            this.lblVoucherName.Name = "lblVoucherName";
            this.lblVoucherName.Size = new System.Drawing.Size(102, 19);
            this.lblVoucherName.TabIndex = 11;
            this.lblVoucherName.Text = "أسم المستند";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.IsRequired = false;
            this.textBox1.Location = new System.Drawing.Point(117, 75);
            this.textBox1.LockedInModes = 25;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 27);
            this.textBox1.TabIndex = 12;
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.IsRequired = false;
            this.lblAccountNumber.Location = new System.Drawing.Point(689, 112);
            this.lblAccountNumber.LockedInModes = 25;
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(164, 19);
            this.lblAccountNumber.TabIndex = 13;
            this.lblAccountNumber.Text = "رقم الحساب الأفتراضى";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.IsRequired = false;
            this.textBox2.Location = new System.Drawing.Point(400, 108);
            this.textBox2.LockedInModes = 25;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(287, 27);
            this.textBox2.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.lblAccountNumber);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.lblVoucherName);
            this.groupBox1.Controls.Add(this.txtCurrency);
            this.groupBox1.Controls.Add(this.lblCurrency);
            this.groupBox1.Controls.Add(this.txtEnglishName);
            this.groupBox1.Controls.Add(this.lblEnglishName);
            this.groupBox1.Controls.Add(this.txtArabicName);
            this.groupBox1.Controls.Add(this.lblArabicName);
            this.groupBox1.Controls.Add(this.txtVoucherCode);
            this.groupBox1.Controls.Add(this.lblVoucherCode);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 194);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(859, 150);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 344);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(859, 100);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "رئيسى";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.IsRequired = false;
            this.label1.Location = new System.Drawing.Point(750, 35);
            this.label1.LockedInModes = 25;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "حقل أضافى 1";
            // 
            // frmVoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 456);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgrdVouchers);
            this.Name = "frmVoucher";
            this.Text = "frmVoucher";
            this.Controls.SetChildIndex(this.dgrdVouchers, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgrdVouchers)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrdVouchers;
        private Controls.Label lblVoucherCode;
        private Controls.TextBox txtVoucherCode;
        private Controls.Label lblArabicName;
        private Controls.TextBox txtArabicName;
        private Controls.Label lblEnglishName;
        private Controls.TextBox txtEnglishName;
        private Controls.Label lblCurrency;
        private Controls.TextBox txtCurrency;
        private Controls.Label lblVoucherName;
        private Controls.TextBox textBox1;
        private Controls.Label lblAccountNumber;
        private Controls.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Controls.Label label1;
    }
}