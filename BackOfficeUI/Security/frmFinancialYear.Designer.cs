namespace BackOfficeUI.Security
{
    partial class frmFinancialYear
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
            this.comboBoxFinancialYear = new BackOfficeUI.Controls.ComboBox();
            this.btnExit = new BackOfficeUI.Controls.Button();
            this.btnLogin = new BackOfficeUI.Controls.Button();
            this.label1 = new BackOfficeUI.Controls.Label();
            this.SuspendLayout();
            // 
            // comboBoxFinancialYear
            // 
            this.comboBoxFinancialYear.BackColor = System.Drawing.Color.White;
            this.comboBoxFinancialYear.Clearable = true;
            this.comboBoxFinancialYear.DefaultIndex = -1;
            this.comboBoxFinancialYear.FormattingEnabled = true;
            this.comboBoxFinancialYear.IsRequired = false;
            this.comboBoxFinancialYear.Location = new System.Drawing.Point(223, 57);
            this.comboBoxFinancialYear.LockedInModes = 25;
            this.comboBoxFinancialYear.Name = "comboBoxFinancialYear";
            this.comboBoxFinancialYear.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFinancialYear.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Clearable = true;
            this.btnExit.IsRequired = false;
            this.btnExit.Location = new System.Drawing.Point(237, 125);
            this.btnExit.LockedInModes = 25;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(107, 31);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Clearable = true;
            this.btnLogin.IsRequired = false;
            this.btnLogin.Location = new System.Drawing.Point(53, 125);
            this.btnLogin.LockedInModes = 25;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(107, 31);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Enter";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Clearable = true;
            this.label1.IsRequired = false;
            this.label1.Location = new System.Drawing.Point(50, 65);
            this.label1.LockedInModes = 25;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Financial Year : ";
            // 
            // frmFinancialYear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 187);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.comboBoxFinancialYear);
            this.Name = "frmFinancialYear";
            this.Text = "frmFinancialYear";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.ComboBox comboBoxFinancialYear;
        private Controls.Button btnExit;
        private Controls.Button btnLogin;
        private Controls.Label label1;
    }
}