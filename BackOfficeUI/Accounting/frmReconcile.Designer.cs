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
            this.textBox7 = new BackOfficeUI.Controls.TextBox();
            this.textBox8 = new BackOfficeUI.Controls.TextBox();
            this.textBox9 = new BackOfficeUI.Controls.TextBox();
            this.textBox6 = new BackOfficeUI.Controls.TextBox();
            this.textBox5 = new BackOfficeUI.Controls.TextBox();
            this.textBox4 = new BackOfficeUI.Controls.TextBox();
            this.textBox3 = new BackOfficeUI.Controls.TextBox();
            this.textBox2 = new BackOfficeUI.Controls.TextBox();
            this.textBox1 = new BackOfficeUI.Controls.TextBox();
            this.dataGridView1 = new BackOfficeUI.Controls.DataGridView();
            this.Cheked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TransActionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SettlementAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Controls.Add(this.textBox9);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
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
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.White;
            this.textBox7.Clearable = true;
            this.textBox7.ContextSearchId = 0;
            this.textBox7.IsRequired = false;
            resources.ApplyResources(this.textBox7, "textBox7");
            this.textBox7.LockedInModes = 25;
            this.textBox7.Name = "textBox7";
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.White;
            this.textBox8.Clearable = true;
            this.textBox8.ContextSearchId = 0;
            this.textBox8.IsRequired = false;
            resources.ApplyResources(this.textBox8, "textBox8");
            this.textBox8.LockedInModes = 25;
            this.textBox8.Name = "textBox8";
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.White;
            this.textBox9.Clearable = true;
            this.textBox9.ContextSearchId = 0;
            this.textBox9.IsRequired = false;
            resources.ApplyResources(this.textBox9, "textBox9");
            this.textBox9.LockedInModes = 25;
            this.textBox9.Name = "textBox9";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.White;
            this.textBox6.Clearable = true;
            this.textBox6.ContextSearchId = 0;
            this.textBox6.IsRequired = false;
            resources.ApplyResources(this.textBox6, "textBox6");
            this.textBox6.LockedInModes = 25;
            this.textBox6.Name = "textBox6";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.White;
            this.textBox5.Clearable = true;
            this.textBox5.ContextSearchId = 0;
            this.textBox5.IsRequired = false;
            resources.ApplyResources(this.textBox5, "textBox5");
            this.textBox5.LockedInModes = 25;
            this.textBox5.Name = "textBox5";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.White;
            this.textBox4.Clearable = true;
            this.textBox4.ContextSearchId = 0;
            this.textBox4.IsRequired = false;
            resources.ApplyResources(this.textBox4, "textBox4");
            this.textBox4.LockedInModes = 25;
            this.textBox4.Name = "textBox4";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.Clearable = true;
            this.textBox3.ContextSearchId = 0;
            this.textBox3.IsRequired = false;
            resources.ApplyResources(this.textBox3, "textBox3");
            this.textBox3.LockedInModes = 25;
            this.textBox3.Name = "textBox3";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.Clearable = true;
            this.textBox2.ContextSearchId = 0;
            this.textBox2.IsRequired = false;
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.LockedInModes = 25;
            this.textBox2.Name = "textBox2";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox1.Clearable = true;
            this.textBox1.ContextSearchId = 0;
            this.textBox1.IsRequired = false;
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.LockedInModes = 25;
            this.textBox1.Name = "textBox1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Clearable = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cheked,
            this.TransActionDate,
            this.TransactionId,
            this.TransactionType,
            this.Debit,
            this.Credit,
            this.SettlementAmount});
            this.dataGridView1.ContextSearchId = 0;
            this.dataGridView1.IsRequired = false;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.LockedInModes = 25;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            // 
            // Cheked
            // 
            resources.ApplyResources(this.Cheked, "Cheked");
            this.Cheked.Name = "Cheked";
            this.Cheked.ReadOnly = true;
            // 
            // TransActionDate
            // 
            resources.ApplyResources(this.TransActionDate, "TransActionDate");
            this.TransActionDate.Name = "TransActionDate";
            this.TransActionDate.ReadOnly = true;
            // 
            // TransactionId
            // 
            resources.ApplyResources(this.TransactionId, "TransactionId");
            this.TransactionId.Name = "TransactionId";
            this.TransactionId.ReadOnly = true;
            // 
            // TransactionType
            // 
            resources.ApplyResources(this.TransactionType, "TransactionType");
            this.TransactionType.Name = "TransactionType";
            this.TransactionType.ReadOnly = true;
            // 
            // Debit
            // 
            resources.ApplyResources(this.Debit, "Debit");
            this.Debit.Name = "Debit";
            this.Debit.ReadOnly = true;
            // 
            // Credit
            // 
            resources.ApplyResources(this.Credit, "Credit");
            this.Credit.Name = "Credit";
            this.Credit.ReadOnly = true;
            // 
            // SettlementAmount
            // 
            resources.ApplyResources(this.SettlementAmount, "SettlementAmount");
            this.SettlementAmount.Name = "SettlementAmount";
            this.SettlementAmount.ReadOnly = true;
            // 
            // frmReconcile
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmReconcile";
            this.Find += new BackOfficeUI.Controls.frmBaseDB.FindDelegate(this.frmReconcile_Find);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private Controls.TextBox textBox1;
        private Controls.TextBox textBox2;
        private Controls.TextBox textBox6;
        private Controls.TextBox textBox5;
        private Controls.TextBox textBox4;
        private Controls.TextBox textBox3;
        private Controls.TextBox textBox7;
        private Controls.TextBox textBox8;
        private Controls.TextBox textBox9;
        private Controls.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Cheked;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransActionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Debit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credit;
        private System.Windows.Forms.DataGridViewTextBoxColumn SettlementAmount;
    }
}
