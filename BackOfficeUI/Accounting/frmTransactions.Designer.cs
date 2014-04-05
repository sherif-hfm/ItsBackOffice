namespace BackOfficeUI.Accounting
{
    partial class frmTransactions
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
            this.labelVoucherType = new BackOfficeUI.Controls.Label();
            this.comboBoxVoucherType = new BackOfficeUI.Controls.ComboBox();
            this.labelvoucherID = new BackOfficeUI.Controls.Label();
            this.textBoxVoucherID = new BackOfficeUI.Controls.TextBox();
            this.labelDate = new BackOfficeUI.Controls.Label();
            this.dateTimePicker1 = new BackOfficeUI.Controls.DateTimePicker();
            this.dataGridView1 = new BackOfficeUI.Controls.DataGridView();
            this.AccountNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Info = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostCenter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelAccountNo = new BackOfficeUI.Controls.Label();
            this.textBoxAccountNo = new BackOfficeUI.Controls.TextBox();
            this.labelAccountName = new BackOfficeUI.Controls.Label();
            this.textBox1 = new BackOfficeUI.Controls.TextBox();
            this.labelAccountBalance = new BackOfficeUI.Controls.Label();
            this.textBox2 = new BackOfficeUI.Controls.TextBox();
            this.label1 = new BackOfficeUI.Controls.Label();
            this.textBoxCostCenterID = new BackOfficeUI.Controls.TextBox();
            this.label2 = new BackOfficeUI.Controls.Label();
            this.textBoxCostCenterName = new BackOfficeUI.Controls.TextBox();
            this.label3 = new BackOfficeUI.Controls.Label();
            this.textBoxDebit = new BackOfficeUI.Controls.TextBox();
            this.label4 = new BackOfficeUI.Controls.Label();
            this.textBoxCredit = new BackOfficeUI.Controls.TextBox();
            this.labelInfo = new BackOfficeUI.Controls.Label();
            this.textBoxInformation = new BackOfficeUI.Controls.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelVoucherType
            // 
            this.labelVoucherType.AutoSize = true;
            this.labelVoucherType.Clearable = true;
            this.labelVoucherType.ContextSearchId = 0;
            this.labelVoucherType.IsRequired = false;
            this.labelVoucherType.Location = new System.Drawing.Point(13, 61);
            this.labelVoucherType.LockedInModes = 25;
            this.labelVoucherType.Name = "labelVoucherType";
            this.labelVoucherType.Size = new System.Drawing.Size(117, 19);
            this.labelVoucherType.TabIndex = 2;
            this.labelVoucherType.Text = "Voucher Type :";
            // 
            // comboBoxVoucherType
            // 
            this.comboBoxVoucherType.BackColor = System.Drawing.Color.White;
            this.comboBoxVoucherType.Clearable = true;
            this.comboBoxVoucherType.ContextSearchId = 0;
            this.comboBoxVoucherType.DefaultIndex = -1;
            this.comboBoxVoucherType.FormattingEnabled = true;
            this.comboBoxVoucherType.IsRequired = false;
            this.comboBoxVoucherType.Location = new System.Drawing.Point(136, 58);
            this.comboBoxVoucherType.LockedInModes = 25;
            this.comboBoxVoucherType.Name = "comboBoxVoucherType";
            this.comboBoxVoucherType.Size = new System.Drawing.Size(121, 27);
            this.comboBoxVoucherType.TabIndex = 3;
            this.comboBoxVoucherType.SelectedIndexChanged += new System.EventHandler(this.comboBoxVoucherType_SelectedIndexChanged);
            // 
            // labelvoucherID
            // 
            this.labelvoucherID.AutoSize = true;
            this.labelvoucherID.Clearable = true;
            this.labelvoucherID.ContextSearchId = 0;
            this.labelvoucherID.IsRequired = false;
            this.labelvoucherID.Location = new System.Drawing.Point(281, 61);
            this.labelvoucherID.LockedInModes = 25;
            this.labelvoucherID.Name = "labelvoucherID";
            this.labelvoucherID.Size = new System.Drawing.Size(100, 19);
            this.labelvoucherID.TabIndex = 4;
            this.labelvoucherID.Text = "Voucher ID :";
            // 
            // textBoxVoucherID
            // 
            this.textBoxVoucherID.BackColor = System.Drawing.Color.White;
            this.textBoxVoucherID.Clearable = true;
            this.textBoxVoucherID.ContextSearchId = 0;
            this.textBoxVoucherID.IsRequired = false;
            this.textBoxVoucherID.Location = new System.Drawing.Point(387, 58);
            this.textBoxVoucherID.LockedInModes = 31;
            this.textBoxVoucherID.Name = "textBoxVoucherID";
            this.textBoxVoucherID.Size = new System.Drawing.Size(100, 27);
            this.textBoxVoucherID.TabIndex = 5;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Clearable = true;
            this.labelDate.ContextSearchId = 0;
            this.labelDate.IsRequired = false;
            this.labelDate.Location = new System.Drawing.Point(527, 61);
            this.labelDate.LockedInModes = 25;
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(52, 19);
            this.labelDate.TabIndex = 6;
            this.labelDate.Text = "Date :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Clearable = true;
            this.dateTimePicker1.ContextSearchId = 0;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.IsRequired = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(586, 59);
            this.dateTimePicker1.LockedInModes = 25;
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(140, 27);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Clearable = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AccountNo,
            this.Info,
            this.Debit,
            this.Credit,
            this.CostCenter});
            this.dataGridView1.ContextSearchId = 0;
            this.dataGridView1.IsRequired = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 107);
            this.dataGridView1.LockedInModes = 25;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(859, 150);
            this.dataGridView1.TabIndex = 8;
            // 
            // AccountNo
            // 
            this.AccountNo.HeaderText = "Account No";
            this.AccountNo.Name = "AccountNo";
            this.AccountNo.ReadOnly = true;
            // 
            // Info
            // 
            this.Info.HeaderText = "Info";
            this.Info.Name = "Info";
            this.Info.ReadOnly = true;
            // 
            // Debit
            // 
            this.Debit.HeaderText = "Debit";
            this.Debit.Name = "Debit";
            this.Debit.ReadOnly = true;
            // 
            // Credit
            // 
            this.Credit.HeaderText = "Credit";
            this.Credit.Name = "Credit";
            this.Credit.ReadOnly = true;
            // 
            // CostCenter
            // 
            this.CostCenter.HeaderText = "Cost Center";
            this.CostCenter.Name = "CostCenter";
            this.CostCenter.ReadOnly = true;
            // 
            // labelAccountNo
            // 
            this.labelAccountNo.AutoSize = true;
            this.labelAccountNo.Clearable = true;
            this.labelAccountNo.ContextSearchId = 0;
            this.labelAccountNo.IsRequired = false;
            this.labelAccountNo.Location = new System.Drawing.Point(4, 264);
            this.labelAccountNo.LockedInModes = 25;
            this.labelAccountNo.Name = "labelAccountNo";
            this.labelAccountNo.Size = new System.Drawing.Size(102, 19);
            this.labelAccountNo.TabIndex = 9;
            this.labelAccountNo.Text = "Account No :";
            // 
            // textBoxAccountNo
            // 
            this.textBoxAccountNo.BackColor = System.Drawing.Color.White;
            this.textBoxAccountNo.Clearable = true;
            this.textBoxAccountNo.ContextSearchId = 0;
            this.textBoxAccountNo.IsRequired = false;
            this.textBoxAccountNo.Location = new System.Drawing.Point(113, 262);
            this.textBoxAccountNo.LockedInModes = 25;
            this.textBoxAccountNo.Name = "textBoxAccountNo";
            this.textBoxAccountNo.Size = new System.Drawing.Size(144, 27);
            this.textBoxAccountNo.TabIndex = 10;
            // 
            // labelAccountName
            // 
            this.labelAccountName.AutoSize = true;
            this.labelAccountName.Clearable = true;
            this.labelAccountName.ContextSearchId = 0;
            this.labelAccountName.IsRequired = false;
            this.labelAccountName.Location = new System.Drawing.Point(260, 265);
            this.labelAccountName.LockedInModes = 25;
            this.labelAccountName.Name = "labelAccountName";
            this.labelAccountName.Size = new System.Drawing.Size(122, 19);
            this.labelAccountName.TabIndex = 11;
            this.labelAccountName.Text = "Account Name :";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Clearable = true;
            this.textBox1.ContextSearchId = 0;
            this.textBox1.IsRequired = false;
            this.textBox1.Location = new System.Drawing.Point(387, 261);
            this.textBox1.LockedInModes = 25;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 27);
            this.textBox1.TabIndex = 12;
            // 
            // labelAccountBalance
            // 
            this.labelAccountBalance.AutoSize = true;
            this.labelAccountBalance.Clearable = true;
            this.labelAccountBalance.ContextSearchId = 0;
            this.labelAccountBalance.IsRequired = false;
            this.labelAccountBalance.Location = new System.Drawing.Point(615, 265);
            this.labelAccountBalance.LockedInModes = 25;
            this.labelAccountBalance.Name = "labelAccountBalance";
            this.labelAccountBalance.Size = new System.Drawing.Size(135, 19);
            this.labelAccountBalance.TabIndex = 13;
            this.labelAccountBalance.Text = "Account Balance :";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.Clearable = true;
            this.textBox2.ContextSearchId = 0;
            this.textBox2.IsRequired = false;
            this.textBox2.Location = new System.Drawing.Point(750, 261);
            this.textBox2.LockedInModes = 25;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(86, 27);
            this.textBox2.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Clearable = true;
            this.label1.ContextSearchId = 0;
            this.label1.IsRequired = false;
            this.label1.Location = new System.Drawing.Point(4, 299);
            this.label1.LockedInModes = 25;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Cost Center No :";
            // 
            // textBoxCostCenterID
            // 
            this.textBoxCostCenterID.BackColor = System.Drawing.Color.White;
            this.textBoxCostCenterID.Clearable = true;
            this.textBoxCostCenterID.ContextSearchId = 0;
            this.textBoxCostCenterID.IsRequired = false;
            this.textBoxCostCenterID.Location = new System.Drawing.Point(133, 296);
            this.textBoxCostCenterID.LockedInModes = 25;
            this.textBoxCostCenterID.Name = "textBoxCostCenterID";
            this.textBoxCostCenterID.Size = new System.Drawing.Size(55, 27);
            this.textBoxCostCenterID.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Clearable = true;
            this.label2.ContextSearchId = 0;
            this.label2.IsRequired = false;
            this.label2.Location = new System.Drawing.Point(199, 299);
            this.label2.LockedInModes = 25;
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Cost Center :";
            // 
            // textBoxCostCenterName
            // 
            this.textBoxCostCenterName.BackColor = System.Drawing.Color.White;
            this.textBoxCostCenterName.Clearable = true;
            this.textBoxCostCenterName.ContextSearchId = 0;
            this.textBoxCostCenterName.IsRequired = false;
            this.textBoxCostCenterName.Location = new System.Drawing.Point(301, 296);
            this.textBoxCostCenterName.LockedInModes = 25;
            this.textBoxCostCenterName.Name = "textBoxCostCenterName";
            this.textBoxCostCenterName.Size = new System.Drawing.Size(119, 27);
            this.textBoxCostCenterName.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Clearable = true;
            this.label3.ContextSearchId = 0;
            this.label3.IsRequired = false;
            this.label3.Location = new System.Drawing.Point(429, 300);
            this.label3.LockedInModes = 25;
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "Debit :";
            // 
            // textBoxDebit
            // 
            this.textBoxDebit.BackColor = System.Drawing.Color.White;
            this.textBoxDebit.Clearable = true;
            this.textBoxDebit.ContextSearchId = 0;
            this.textBoxDebit.IsRequired = false;
            this.textBoxDebit.Location = new System.Drawing.Point(498, 297);
            this.textBoxDebit.LockedInModes = 25;
            this.textBoxDebit.Name = "textBoxDebit";
            this.textBoxDebit.Size = new System.Drawing.Size(111, 27);
            this.textBoxDebit.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Clearable = true;
            this.label4.ContextSearchId = 0;
            this.label4.IsRequired = false;
            this.label4.Location = new System.Drawing.Point(429, 338);
            this.label4.LockedInModes = 25;
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 19);
            this.label4.TabIndex = 21;
            this.label4.Text = "Credit :";
            // 
            // textBoxCredit
            // 
            this.textBoxCredit.BackColor = System.Drawing.Color.White;
            this.textBoxCredit.Clearable = true;
            this.textBoxCredit.ContextSearchId = 0;
            this.textBoxCredit.IsRequired = false;
            this.textBoxCredit.Location = new System.Drawing.Point(498, 330);
            this.textBoxCredit.LockedInModes = 25;
            this.textBoxCredit.Name = "textBoxCredit";
            this.textBoxCredit.Size = new System.Drawing.Size(111, 27);
            this.textBoxCredit.TabIndex = 22;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Clearable = true;
            this.labelInfo.ContextSearchId = 0;
            this.labelInfo.IsRequired = false;
            this.labelInfo.Location = new System.Drawing.Point(4, 333);
            this.labelInfo.LockedInModes = 25;
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(103, 19);
            this.labelInfo.TabIndex = 23;
            this.labelInfo.Text = "Information :";
            // 
            // textBoxInformation
            // 
            this.textBoxInformation.BackColor = System.Drawing.Color.White;
            this.textBoxInformation.Clearable = true;
            this.textBoxInformation.ContextSearchId = 0;
            this.textBoxInformation.IsRequired = false;
            this.textBoxInformation.Location = new System.Drawing.Point(113, 329);
            this.textBoxInformation.LockedInModes = 25;
            this.textBoxInformation.Name = "textBoxInformation";
            this.textBoxInformation.Size = new System.Drawing.Size(307, 27);
            this.textBoxInformation.TabIndex = 24;
            // 
            // frmTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 401);
            this.Controls.Add(this.textBoxInformation);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.textBoxCredit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxDebit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxCostCenterName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCostCenterID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labelAccountBalance);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelAccountName);
            this.Controls.Add(this.textBoxAccountNo);
            this.Controls.Add(this.labelAccountNo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.textBoxVoucherID);
            this.Controls.Add(this.labelvoucherID);
            this.Controls.Add(this.comboBoxVoucherType);
            this.Controls.Add(this.labelVoucherType);
            this.Name = "frmTransactions";
            this.Text = "frmTransactions";
            this.Controls.SetChildIndex(this.labelVoucherType, 0);
            this.Controls.SetChildIndex(this.comboBoxVoucherType, 0);
            this.Controls.SetChildIndex(this.labelvoucherID, 0);
            this.Controls.SetChildIndex(this.textBoxVoucherID, 0);
            this.Controls.SetChildIndex(this.labelDate, 0);
            this.Controls.SetChildIndex(this.dateTimePicker1, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.labelAccountNo, 0);
            this.Controls.SetChildIndex(this.textBoxAccountNo, 0);
            this.Controls.SetChildIndex(this.labelAccountName, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.labelAccountBalance, 0);
            this.Controls.SetChildIndex(this.textBox2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.textBoxCostCenterID, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.textBoxCostCenterName, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.textBoxDebit, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.textBoxCredit, 0);
            this.Controls.SetChildIndex(this.labelInfo, 0);
            this.Controls.SetChildIndex(this.textBoxInformation, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.Label labelVoucherType;
        private Controls.ComboBox comboBoxVoucherType;
        private Controls.Label labelvoucherID;
        private Controls.TextBox textBoxVoucherID;
        private Controls.Label labelDate;
        private Controls.DateTimePicker dateTimePicker1;
        private Controls.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Info;
        private System.Windows.Forms.DataGridViewTextBoxColumn Debit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credit;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostCenter;
        private Controls.Label labelAccountNo;
        private Controls.TextBox textBoxAccountNo;
        private Controls.Label labelAccountName;
        private Controls.TextBox textBox1;
        private Controls.Label labelAccountBalance;
        private Controls.TextBox textBox2;
        private Controls.Label label1;
        private Controls.TextBox textBoxCostCenterID;
        private Controls.Label label2;
        private Controls.TextBox textBoxCostCenterName;
        private Controls.Label label3;
        private Controls.TextBox textBoxDebit;
        private Controls.Label label4;
        private Controls.TextBox textBoxCredit;
        private Controls.Label labelInfo;
        private Controls.TextBox textBoxInformation;
    }
}