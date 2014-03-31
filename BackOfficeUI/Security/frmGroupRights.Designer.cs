namespace BackOfficeUI.Security
{
    partial class frmGroupRights
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
            this.components = new System.ComponentModel.Container();
            this.treeMenu = new BackOfficeUI.Controls.TreeView();
            this.lblGroupName = new BackOfficeUI.Controls.Label();
            this.lblGroupId = new BackOfficeUI.Controls.Label();
            this.txtGroupName = new BackOfficeUI.Controls.TextBox();
            this.txtGroupID = new BackOfficeUI.Controls.TextBox();
            this.lstRights = new BackOfficeUI.Controls.CheckedListBox();
            this.menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemSelectAllNodes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemApplyRights = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeMenu
            // 
            this.treeMenu.BackColor = System.Drawing.Color.White;
            this.treeMenu.CheckBoxes = true;
            this.treeMenu.Clearable = false;
            this.treeMenu.ContextSearchId = 0;
            this.treeMenu.IsRequired = false;
            this.treeMenu.Location = new System.Drawing.Point(12, 141);
            this.treeMenu.LockedInModes = 0;
            this.treeMenu.Name = "treeMenu";
            this.treeMenu.Size = new System.Drawing.Size(326, 334);
            this.treeMenu.TabIndex = 2;
            this.treeMenu.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeMenu_AfterCheck);
            this.treeMenu.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeMenu_AfterSelect);
            // 
            // lblGroupName
            // 
            this.lblGroupName.AutoSize = true;
            this.lblGroupName.Clearable = true;
            this.lblGroupName.ContextSearchId = 0;
            this.lblGroupName.IsRequired = false;
            this.lblGroupName.Location = new System.Drawing.Point(11, 112);
            this.lblGroupName.LockedInModes = 25;
            this.lblGroupName.Name = "lblGroupName";
            this.lblGroupName.Size = new System.Drawing.Size(99, 19);
            this.lblGroupName.TabIndex = 19;
            this.lblGroupName.Text = "Group Name";
            // 
            // lblGroupId
            // 
            this.lblGroupId.AutoSize = true;
            this.lblGroupId.Clearable = true;
            this.lblGroupId.ContextSearchId = 0;
            this.lblGroupId.IsRequired = false;
            this.lblGroupId.Location = new System.Drawing.Point(11, 75);
            this.lblGroupId.LockedInModes = 25;
            this.lblGroupId.Name = "lblGroupId";
            this.lblGroupId.Size = new System.Drawing.Size(94, 19);
            this.lblGroupId.TabIndex = 18;
            this.lblGroupId.Text = "Group Code";
            // 
            // txtGroupName
            // 
            this.txtGroupName.BackColor = System.Drawing.Color.White;
            this.txtGroupName.Clearable = true;
            this.txtGroupName.ContextSearchId = 0;
            this.txtGroupName.IsRequired = true;
            this.txtGroupName.Location = new System.Drawing.Point(112, 108);
            this.txtGroupName.LockedInModes = 25;
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Size = new System.Drawing.Size(226, 27);
            this.txtGroupName.TabIndex = 17;
            // 
            // txtGroupID
            // 
            this.txtGroupID.BackColor = System.Drawing.Color.White;
            this.txtGroupID.Clearable = true;
            this.txtGroupID.ContextSearchId = 0;
            this.txtGroupID.IsRequired = true;
            this.txtGroupID.Location = new System.Drawing.Point(112, 75);
            this.txtGroupID.LockedInModes = 29;
            this.txtGroupID.Name = "txtGroupID";
            this.txtGroupID.Size = new System.Drawing.Size(142, 27);
            this.txtGroupID.TabIndex = 16;
            // 
            // lstRights
            // 
            this.lstRights.CheckOnClick = true;
            this.lstRights.Clearable = false;
            this.lstRights.ContextSearchId = 0;
            this.lstRights.FormattingEnabled = true;
            this.lstRights.IsRequired = false;
            this.lstRights.Location = new System.Drawing.Point(344, 141);
            this.lstRights.LockedInModes = 25;
            this.lstRights.Name = "lstRights";
            this.lstRights.Size = new System.Drawing.Size(235, 334);
            this.lstRights.TabIndex = 20;
            this.lstRights.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lstRights_ItemCheck);
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemSelectAllNodes,
            this.menuItemApplyRights});
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(209, 48);
            // 
            // menuItemSelectAllNodes
            // 
            this.menuItemSelectAllNodes.Name = "menuItemSelectAllNodes";
            this.menuItemSelectAllNodes.Size = new System.Drawing.Size(208, 22);
            this.menuItemSelectAllNodes.Text = "Select All Nodes";
            this.menuItemSelectAllNodes.Click += new System.EventHandler(this.menuItemSelectAllNodes_Click);
            // 
            // menuItemApplyRights
            // 
            this.menuItemApplyRights.Name = "menuItemApplyRights";
            this.menuItemApplyRights.Size = new System.Drawing.Size(208, 22);
            this.menuItemApplyRights.Text = "Apply Rights To Child Nodes";
            // 
            // frmGroupRights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 526);
            this.Controls.Add(this.lstRights);
            this.Controls.Add(this.lblGroupName);
            this.Controls.Add(this.lblGroupId);
            this.Controls.Add(this.txtGroupName);
            this.Controls.Add(this.txtGroupID);
            this.Controls.Add(this.treeMenu);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmGroupRights";
            this.Text = "frmGroupRights";
            this.Edit += new BackOfficeUI.Controls.frmBaseDB.EditDelegate(this.frmGroupRights_Edit);
            this.Save += new BackOfficeUI.Controls.frmBaseDB.SaveDelegate(this.frmGroupRights_Save);
            this.DataMove += new BackOfficeUI.Controls.frmBaseDB.DataMoveDelegate(this.frmGroupRights_DataMove);
            this.Cancel += new BackOfficeUI.Controls.frmBaseDB.CancelDelegate(this.frmGroupRights_Cancel);
            this.DataRefresh += new BackOfficeUI.Controls.frmBaseDB.DataRefreshDelegate(this.frmGroupRights_DataRefresh);
            this.Load += new System.EventHandler(this.frmGroupRights_Load);
            this.Controls.SetChildIndex(this.treeMenu, 0);
            this.Controls.SetChildIndex(this.txtGroupID, 0);
            this.Controls.SetChildIndex(this.txtGroupName, 0);
            this.Controls.SetChildIndex(this.lblGroupId, 0);
            this.Controls.SetChildIndex(this.lblGroupName, 0);
            this.Controls.SetChildIndex(this.lstRights, 0);
            this.menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.TreeView treeMenu;
        private Controls.Label lblGroupName;
        private Controls.Label lblGroupId;
        private Controls.TextBox txtGroupName;
        private Controls.TextBox txtGroupID;
        private Controls.CheckedListBox lstRights;
        private System.Windows.Forms.ContextMenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem menuItemSelectAllNodes;
        private System.Windows.Forms.ToolStripMenuItem menuItemApplyRights;
    }
}