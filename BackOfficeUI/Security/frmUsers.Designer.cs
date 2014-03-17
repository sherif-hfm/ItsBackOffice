namespace BackOfficeUI.Security
{
    partial class frmUsers
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
            this.txtUserCode = new BackOfficeUI.Controls.TextBox();
            this.txtUserName_Ara = new BackOfficeUI.Controls.TextBox();
            this.txtUserPassword = new BackOfficeUI.Controls.TextBox();
            this.txtUserName_Eng = new BackOfficeUI.Controls.TextBox();
            this.lblUserCode = new BackOfficeUI.Controls.Label();
            this.lblUserLogin = new BackOfficeUI.Controls.Label();
            this.lblUserPassword = new BackOfficeUI.Controls.Label();
            this.lblUserName_Ara = new BackOfficeUI.Controls.Label();
            this.lblUserName_Eng = new BackOfficeUI.Controls.Label();
            this.chkIsAdmin = new BackOfficeUI.Controls.CheckBox();
            this.lstGroups = new BackOfficeUI.Controls.ListBox();
            this.btnSelectNone = new BackOfficeUI.Controls.Button();
            this.SuspendLayout();
            // 
            // txtUserLogin
            // 
            this.txtUserLogin.BackColor = System.Drawing.Color.White;
            this.txtUserLogin.IsRequired = true;
            this.txtUserLogin.Location = new System.Drawing.Point(121, 102);
            this.txtUserLogin.LockedInModes = 25;
            this.txtUserLogin.Name = "txtUserLogin";
            this.txtUserLogin.Size = new System.Drawing.Size(232, 27);
            this.txtUserLogin.TabIndex = 1;
            // 
            // txtUserCode
            // 
            this.txtUserCode.BackColor = System.Drawing.Color.White;
            this.txtUserCode.IsRequired = false;
            this.txtUserCode.Location = new System.Drawing.Point(121, 69);
            this.txtUserCode.LockedInModes = 31;
            this.txtUserCode.Name = "txtUserCode";
            this.txtUserCode.Size = new System.Drawing.Size(100, 27);
            this.txtUserCode.TabIndex = 0;
            // 
            // txtUserName_Ara
            // 
            this.txtUserName_Ara.BackColor = System.Drawing.Color.White;
            this.txtUserName_Ara.IsRequired = true;
            this.txtUserName_Ara.Location = new System.Drawing.Point(121, 135);
            this.txtUserName_Ara.LockedInModes = 25;
            this.txtUserName_Ara.Name = "txtUserName_Ara";
            this.txtUserName_Ara.Size = new System.Drawing.Size(232, 27);
            this.txtUserName_Ara.TabIndex = 3;
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.BackColor = System.Drawing.Color.White;
            this.txtUserPassword.IsRequired = true;
            this.txtUserPassword.Location = new System.Drawing.Point(121, 201);
            this.txtUserPassword.LockedInModes = 25;
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.Size = new System.Drawing.Size(232, 27);
            this.txtUserPassword.TabIndex = 2;
            // 
            // txtUserName_Eng
            // 
            this.txtUserName_Eng.BackColor = System.Drawing.Color.White;
            this.txtUserName_Eng.IsRequired = true;
            this.txtUserName_Eng.Location = new System.Drawing.Point(121, 168);
            this.txtUserName_Eng.LockedInModes = 25;
            this.txtUserName_Eng.Name = "txtUserName_Eng";
            this.txtUserName_Eng.Size = new System.Drawing.Size(232, 27);
            this.txtUserName_Eng.TabIndex = 4;
            // 
            // lblUserCode
            // 
            this.lblUserCode.AutoSize = true;
            this.lblUserCode.IsRequired = false;
            this.lblUserCode.Location = new System.Drawing.Point(26, 69);
            this.lblUserCode.LockedInModes = 25;
            this.lblUserCode.Name = "lblUserCode";
            this.lblUserCode.Size = new System.Drawing.Size(82, 19);
            this.lblUserCode.TabIndex = 5;
            this.lblUserCode.Text = "User Code";
            // 
            // lblUserLogin
            // 
            this.lblUserLogin.AutoSize = true;
            this.lblUserLogin.IsRequired = false;
            this.lblUserLogin.Location = new System.Drawing.Point(26, 102);
            this.lblUserLogin.LockedInModes = 25;
            this.lblUserLogin.Name = "lblUserLogin";
            this.lblUserLogin.Size = new System.Drawing.Size(85, 19);
            this.lblUserLogin.TabIndex = 6;
            this.lblUserLogin.Text = "User Login";
            // 
            // lblUserPassword
            // 
            this.lblUserPassword.AutoSize = true;
            this.lblUserPassword.IsRequired = false;
            this.lblUserPassword.Location = new System.Drawing.Point(19, 204);
            this.lblUserPassword.LockedInModes = 25;
            this.lblUserPassword.Name = "lblUserPassword";
            this.lblUserPassword.Size = new System.Drawing.Size(76, 19);
            this.lblUserPassword.TabIndex = 7;
            this.lblUserPassword.Text = "Password";
            // 
            // lblUserName_Ara
            // 
            this.lblUserName_Ara.AutoSize = true;
            this.lblUserName_Ara.IsRequired = false;
            this.lblUserName_Ara.Location = new System.Drawing.Point(30, 139);
            this.lblUserName_Ara.LockedInModes = 25;
            this.lblUserName_Ara.Name = "lblUserName_Ara";
            this.lblUserName_Ara.Size = new System.Drawing.Size(80, 19);
            this.lblUserName_Ara.TabIndex = 8;
            this.lblUserName_Ara.Text = "Name Ara";
            // 
            // lblUserName_Eng
            // 
            this.lblUserName_Eng.AutoSize = true;
            this.lblUserName_Eng.IsRequired = false;
            this.lblUserName_Eng.Location = new System.Drawing.Point(19, 171);
            this.lblUserName_Eng.LockedInModes = 25;
            this.lblUserName_Eng.Name = "lblUserName_Eng";
            this.lblUserName_Eng.Size = new System.Drawing.Size(82, 19);
            this.lblUserName_Eng.TabIndex = 9;
            this.lblUserName_Eng.Text = "Name Eng";
            // 
            // chkIsAdmin
            // 
            this.chkIsAdmin.AutoCheck = false;
            this.chkIsAdmin.AutoSize = true;
            this.chkIsAdmin.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIsAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkIsAdmin.IsRequired = false;
            this.chkIsAdmin.Location = new System.Drawing.Point(253, 69);
            this.chkIsAdmin.LockedInModes = 25;
            this.chkIsAdmin.Name = "chkIsAdmin";
            this.chkIsAdmin.Size = new System.Drawing.Size(100, 23);
            this.chkIsAdmin.TabIndex = 10;
            this.chkIsAdmin.Text = "Is Admin";
            this.chkIsAdmin.UseVisualStyleBackColor = true;
            // 
            // lstGroups
            // 
            this.lstGroups.BackColor = System.Drawing.Color.White;
            this.lstGroups.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstGroups.ForeColor = System.Drawing.Color.Black;
            this.lstGroups.FormattingEnabled = true;
            this.lstGroups.IsRequired = false;
            this.lstGroups.ItemHeight = 19;
            this.lstGroups.Location = new System.Drawing.Point(369, 69);
            this.lstGroups.LockedInModes = 25;
            this.lstGroups.Name = "lstGroups";
            this.lstGroups.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstGroups.Size = new System.Drawing.Size(187, 156);
            this.lstGroups.Sorted = true;
            this.lstGroups.TabIndex = 11;
            // 
            // btnSelectNone
            // 
            this.btnSelectNone.IsRequired = false;
            this.btnSelectNone.Location = new System.Drawing.Point(369, 231);
            this.btnSelectNone.LockedInModes = 25;
            this.btnSelectNone.Name = "btnSelectNone";
            this.btnSelectNone.Size = new System.Drawing.Size(187, 30);
            this.btnSelectNone.TabIndex = 12;
            this.btnSelectNone.Text = "Select None";
            this.btnSelectNone.UseVisualStyleBackColor = true;
            this.btnSelectNone.Click += new System.EventHandler(this.btnSelectNone_Click);
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 299);
            this.Controls.Add(this.btnSelectNone);
            this.Controls.Add(this.lstGroups);
            this.Controls.Add(this.chkIsAdmin);
            this.Controls.Add(this.lblUserName_Eng);
            this.Controls.Add(this.lblUserName_Ara);
            this.Controls.Add(this.lblUserPassword);
            this.Controls.Add(this.lblUserLogin);
            this.Controls.Add(this.lblUserCode);
            this.Controls.Add(this.txtUserName_Eng);
            this.Controls.Add(this.txtUserName_Ara);
            this.Controls.Add(this.txtUserPassword);
            this.Controls.Add(this.txtUserLogin);
            this.Controls.Add(this.txtUserCode);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmUsers";
            this.Text = "frmUsers";
            this.AddNew += new BackOfficeUI.Controls.frmBaseDB.AddNewDelegate(this.frmUsers_AddNew);
            this.Edit += new BackOfficeUI.Controls.frmBaseDB.EditDelegate(this.frmUsers_Edit);
            this.Delete += new BackOfficeUI.Controls.frmBaseDB.DeleteDelegate(this.frmUsers_Delete);
            this.Save += new BackOfficeUI.Controls.frmBaseDB.SaveDelegate(this.frmUsers_Save);
            this.DataMove += new BackOfficeUI.Controls.frmBaseDB.DataMoveDelegate(this.frmUsers_DataMove);
            this.Find += new BackOfficeUI.Controls.frmBaseDB.FindDelegate(this.frmUsers_Find);
            this.Load += new System.EventHandler(this.frmUsers_Load);
            this.Controls.SetChildIndex(this.txtUserCode, 0);
            this.Controls.SetChildIndex(this.txtUserLogin, 0);
            this.Controls.SetChildIndex(this.txtUserPassword, 0);
            this.Controls.SetChildIndex(this.txtUserName_Ara, 0);
            this.Controls.SetChildIndex(this.txtUserName_Eng, 0);
            this.Controls.SetChildIndex(this.lblUserCode, 0);
            this.Controls.SetChildIndex(this.lblUserLogin, 0);
            this.Controls.SetChildIndex(this.lblUserPassword, 0);
            this.Controls.SetChildIndex(this.lblUserName_Ara, 0);
            this.Controls.SetChildIndex(this.lblUserName_Eng, 0);
            this.Controls.SetChildIndex(this.chkIsAdmin, 0);
            this.Controls.SetChildIndex(this.lstGroups, 0);
            this.Controls.SetChildIndex(this.btnSelectNone, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.TextBox txtUserLogin;
        private Controls.TextBox txtUserCode;
        private Controls.TextBox txtUserName_Ara;
        private Controls.TextBox txtUserPassword;
        private Controls.TextBox txtUserName_Eng;
        private Controls.Label lblUserCode;
        private Controls.Label lblUserLogin;
        private Controls.Label lblUserPassword;
        private Controls.Label lblUserName_Ara;
        private Controls.Label lblUserName_Eng;
        private Controls.CheckBox chkIsAdmin;
        private Controls.ListBox lstGroups;
        private Controls.Button btnSelectNone;



    }
}