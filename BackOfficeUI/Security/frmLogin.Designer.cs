namespace BackOfficeUI.Security
{
    partial class frmLogin
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
            this.txtUserLogin = new BackOfficeUI.Controls.TextBox();
            this.lblUserName = new BackOfficeUI.Controls.Label();
            this.btnLogin = new BackOfficeUI.Controls.Button();
            this.lblPassword = new BackOfficeUI.Controls.Label();
            this.txtPassword = new BackOfficeUI.Controls.TextBox();
            this.btnExit = new BackOfficeUI.Controls.Button();
            this.SuspendLayout();
            // 
            // txtUserLogin
            // 
            this.txtUserLogin.AcceptsReturn = true;
            this.txtUserLogin.IsRequired = false;
            this.txtUserLogin.Location = new System.Drawing.Point(130, 15);
            this.txtUserLogin.LockedInModes = 25;
            this.txtUserLogin.Name = "txtUserLogin";
            this.txtUserLogin.Size = new System.Drawing.Size(213, 30);
            this.txtUserLogin.TabIndex = 0;
            this.txtUserLogin.Text = "Admin";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.IsRequired = false;
            this.lblUserName.Location = new System.Drawing.Point(15, 18);
            this.lblUserName.LockedInModes = 25;
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(98, 23);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "User Login";
            // 
            // btnLogin
            // 
            this.btnLogin.IsRequired = false;
            this.btnLogin.Location = new System.Drawing.Point(52, 127);
            this.btnLogin.LockedInModes = 25;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(107, 31);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.IsRequired = false;
            this.lblPassword.Location = new System.Drawing.Point(15, 65);
            this.lblPassword.LockedInModes = 25;
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(88, 23);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.AcceptsReturn = true;
            this.txtPassword.IsRequired = false;
            this.txtPassword.Location = new System.Drawing.Point(130, 62);
            this.txtPassword.LockedInModes = 25;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(213, 30);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Text = "1";
            // 
            // btnExit
            // 
            this.btnExit.IsRequired = false;
            this.btnExit.Location = new System.Drawing.Point(236, 127);
            this.btnExit.LockedInModes = 25;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(107, 31);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 187);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserLogin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblUserName);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.TextBox txtUserLogin;
        private Controls.Label lblUserName;
        private Controls.Button btnLogin;
        private Controls.Label lblPassword;
        private Controls.TextBox txtPassword;
        private Controls.Button btnExit;
    }
}