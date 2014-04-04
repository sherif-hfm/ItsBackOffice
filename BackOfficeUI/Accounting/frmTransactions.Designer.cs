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
            this.textBoxVoucherID.LockedInModes = 25;
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
            // frmTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 401);
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
    }
}