namespace BackOfficeUI.Security
{
    partial class frmGroups
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
            this.chkIsDisable = new BackOfficeUI.Controls.CheckBox();
            this.lblGroupName_Eng = new BackOfficeUI.Controls.Label();
            this.lblGroupName_Ara = new BackOfficeUI.Controls.Label();
            this.lblGroupId = new BackOfficeUI.Controls.Label();
            this.txtGroupName_Eng = new BackOfficeUI.Controls.TextBox();
            this.txtGroupName_Ara = new BackOfficeUI.Controls.TextBox();
            this.txtGroupID = new BackOfficeUI.Controls.TextBox();
            this.lstAllUsers = new BackOfficeUI.Controls.ListBox();
            this.lstUsers = new BackOfficeUI.Controls.ListBox();
            this.btnAddUsers = new BackOfficeUI.Controls.Button();
            this.btnRemoveUsers = new BackOfficeUI.Controls.Button();
            this.SuspendLayout();
            // 
            // chkIsDisable
            // 
            this.chkIsDisable.AutoCheck = false;
            this.chkIsDisable.AutoSize = true;
            this.chkIsDisable.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIsDisable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkIsDisable.IsRequired = false;
            this.chkIsDisable.Location = new System.Drawing.Point(118, 187);
            this.chkIsDisable.LockedInModes = 25;
            this.chkIsDisable.Name = "chkIsDisable";
            this.chkIsDisable.Size = new System.Drawing.Size(108, 23);
            this.chkIsDisable.TabIndex = 4;
            this.chkIsDisable.Text = "Is Disable";
            this.chkIsDisable.UseVisualStyleBackColor = true;
            // 
            // lblGroupName_Eng
            // 
            this.lblGroupName_Eng.AutoSize = true;
            this.lblGroupName_Eng.IsRequired = false;
            this.lblGroupName_Eng.Location = new System.Drawing.Point(23, 150);
            this.lblGroupName_Eng.LockedInModes = 25;
            this.lblGroupName_Eng.Name = "lblGroupName_Eng";
            this.lblGroupName_Eng.Size = new System.Drawing.Size(82, 19);
            this.lblGroupName_Eng.TabIndex = 16;
            this.lblGroupName_Eng.Text = "Name Eng";
            // 
            // lblGroupName_Ara
            // 
            this.lblGroupName_Ara.AutoSize = true;
            this.lblGroupName_Ara.IsRequired = false;
            this.lblGroupName_Ara.Location = new System.Drawing.Point(23, 118);
            this.lblGroupName_Ara.LockedInModes = 25;
            this.lblGroupName_Ara.Name = "lblGroupName_Ara";
            this.lblGroupName_Ara.Size = new System.Drawing.Size(80, 19);
            this.lblGroupName_Ara.TabIndex = 15;
            this.lblGroupName_Ara.Text = "Name Ara";
            // 
            // lblGroupId
            // 
            this.lblGroupId.AutoSize = true;
            this.lblGroupId.IsRequired = false;
            this.lblGroupId.Location = new System.Drawing.Point(23, 81);
            this.lblGroupId.LockedInModes = 25;
            this.lblGroupId.Name = "lblGroupId";
            this.lblGroupId.Size = new System.Drawing.Size(94, 19);
            this.lblGroupId.TabIndex = 14;
            this.lblGroupId.Text = "Group Code";
            // 
            // txtGroupName_Eng
            // 
            this.txtGroupName_Eng.BackColor = System.Drawing.Color.White;
            this.txtGroupName_Eng.IsRequired = true;
            this.txtGroupName_Eng.Location = new System.Drawing.Point(118, 147);
            this.txtGroupName_Eng.LockedInModes = 25;
            this.txtGroupName_Eng.Name = "txtGroupName_Eng";
            this.txtGroupName_Eng.Size = new System.Drawing.Size(232, 27);
            this.txtGroupName_Eng.TabIndex = 2;
            // 
            // txtGroupName_Ara
            // 
            this.txtGroupName_Ara.BackColor = System.Drawing.Color.White;
            this.txtGroupName_Ara.IsRequired = true;
            this.txtGroupName_Ara.Location = new System.Drawing.Point(118, 114);
            this.txtGroupName_Ara.LockedInModes = 25;
            this.txtGroupName_Ara.Name = "txtGroupName_Ara";
            this.txtGroupName_Ara.Size = new System.Drawing.Size(232, 27);
            this.txtGroupName_Ara.TabIndex = 1;
            // 
            // txtGroupID
            // 
            this.txtGroupID.BackColor = System.Drawing.Color.White;
            this.txtGroupID.IsRequired = true;
            this.txtGroupID.Location = new System.Drawing.Point(118, 81);
            this.txtGroupID.LockedInModes = 29;
            this.txtGroupID.Name = "txtGroupID";
            this.txtGroupID.Size = new System.Drawing.Size(100, 27);
            this.txtGroupID.TabIndex = 0;
            // 
            // lstAllUsers
            // 
            this.lstAllUsers.BackColor = System.Drawing.Color.White;
            this.lstAllUsers.DisplayMember = "Name";
            this.lstAllUsers.FormattingEnabled = true;
            this.lstAllUsers.IsRequired = false;
            this.lstAllUsers.ItemHeight = 19;
            this.lstAllUsers.Location = new System.Drawing.Point(27, 216);
            this.lstAllUsers.LockedInModes = 25;
            this.lstAllUsers.Name = "lstAllUsers";
            this.lstAllUsers.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstAllUsers.Size = new System.Drawing.Size(268, 308);
            this.lstAllUsers.Sorted = true;
            this.lstAllUsers.TabIndex = 17;
            this.lstAllUsers.ValueMember = "UserID";
            // 
            // lstUsers
            // 
            this.lstUsers.BackColor = System.Drawing.Color.White;
            this.lstUsers.DisplayMember = "Name";
            this.lstUsers.FormattingEnabled = true;
            this.lstUsers.IsRequired = false;
            this.lstUsers.ItemHeight = 19;
            this.lstUsers.Location = new System.Drawing.Point(362, 216);
            this.lstUsers.LockedInModes = 25;
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstUsers.Size = new System.Drawing.Size(268, 308);
            this.lstUsers.Sorted = true;
            this.lstUsers.TabIndex = 18;
            this.lstUsers.ValueMember = "UserID";
            // 
            // btnAddUsers
            // 
            this.btnAddUsers.IsRequired = false;
            this.btnAddUsers.Location = new System.Drawing.Point(304, 216);
            this.btnAddUsers.LockedInModes = 25;
            this.btnAddUsers.Name = "btnAddUsers";
            this.btnAddUsers.Size = new System.Drawing.Size(46, 30);
            this.btnAddUsers.TabIndex = 19;
            this.btnAddUsers.Text = ">>";
            this.btnAddUsers.UseVisualStyleBackColor = true;
            this.btnAddUsers.Click += new System.EventHandler(this.btnAddUsers_Click);
            // 
            // btnRemoveUsers
            // 
            this.btnRemoveUsers.IsRequired = false;
            this.btnRemoveUsers.Location = new System.Drawing.Point(304, 252);
            this.btnRemoveUsers.LockedInModes = 25;
            this.btnRemoveUsers.Name = "btnRemoveUsers";
            this.btnRemoveUsers.Size = new System.Drawing.Size(46, 30);
            this.btnRemoveUsers.TabIndex = 20;
            this.btnRemoveUsers.Text = "<<";
            this.btnRemoveUsers.UseVisualStyleBackColor = true;
            this.btnRemoveUsers.Click += new System.EventHandler(this.btnRemoveUsers_Click);
            // 
            // frmGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 553);
            this.Controls.Add(this.btnRemoveUsers);
            this.Controls.Add(this.btnAddUsers);
            this.Controls.Add(this.lstUsers);
            this.Controls.Add(this.lstAllUsers);
            this.Controls.Add(this.chkIsDisable);
            this.Controls.Add(this.lblGroupName_Eng);
            this.Controls.Add(this.lblGroupName_Ara);
            this.Controls.Add(this.lblGroupId);
            this.Controls.Add(this.txtGroupName_Eng);
            this.Controls.Add(this.txtGroupName_Ara);
            this.Controls.Add(this.txtGroupID);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmGroups";
            this.Text = "frmGroups";
            this.AddNew += new BackOfficeUI.Controls.frmBaseDB.AddNewDelegate(this.frmGroups_AddNew);
            this.Edit += new BackOfficeUI.Controls.frmBaseDB.EditDelegate(this.frmGroups_Edit);
            this.Delete += new BackOfficeUI.Controls.frmBaseDB.DeleteDelegate(this.frmGroups_Delete);
            this.Save += new BackOfficeUI.Controls.frmBaseDB.SaveDelegate(this.frmGroups_Save);
            this.DataMove += new BackOfficeUI.Controls.frmBaseDB.DataMoveDelegate(this.frmGroups_DataMove);
            this.Cancel += new BackOfficeUI.Controls.frmBaseDB.CancelDelegate(this.frmGroups_Cancel);
            this.Find += new BackOfficeUI.Controls.frmBaseDB.FindDelegate(this.frmGroups_Find);
            this.Load += new System.EventHandler(this.frmGroups_Load);
            this.Controls.SetChildIndex(this.txtGroupID, 0);
            this.Controls.SetChildIndex(this.txtGroupName_Ara, 0);
            this.Controls.SetChildIndex(this.txtGroupName_Eng, 0);
            this.Controls.SetChildIndex(this.lblGroupId, 0);
            this.Controls.SetChildIndex(this.lblGroupName_Ara, 0);
            this.Controls.SetChildIndex(this.lblGroupName_Eng, 0);
            this.Controls.SetChildIndex(this.chkIsDisable, 0);
            this.Controls.SetChildIndex(this.lstAllUsers, 0);
            this.Controls.SetChildIndex(this.lstUsers, 0);
            this.Controls.SetChildIndex(this.btnAddUsers, 0);
            this.Controls.SetChildIndex(this.btnRemoveUsers, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.CheckBox chkIsDisable;
        private Controls.Label lblGroupName_Eng;
        private Controls.Label lblGroupName_Ara;
        private Controls.Label lblGroupId;
        private Controls.TextBox txtGroupName_Eng;
        private Controls.TextBox txtGroupName_Ara;
        private Controls.TextBox txtGroupID;
        private Controls.ListBox lstAllUsers;
        private Controls.ListBox lstUsers;
        private Controls.Button btnAddUsers;
        private Controls.Button btnRemoveUsers;

    }
}