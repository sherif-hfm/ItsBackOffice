namespace BackOfficeUI.Accounting
{
    partial class frmCostCenter
    {/// <summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCostCenter));
            this.txtNo = new BackOfficeUI.Controls.TextBox();
            this.lblNo = new BackOfficeUI.Controls.Label();
            this.chkIsDiable = new BackOfficeUI.Controls.CheckBox();
            this.lblNameAr = new BackOfficeUI.Controls.Label();
            this.lblNameEng = new BackOfficeUI.Controls.Label();
            this.lblIsDisable = new BackOfficeUI.Controls.Label();
            this.txtNameAr = new BackOfficeUI.Controls.TextBox();
            this.txtNameEng = new BackOfficeUI.Controls.TextBox();
            this.lblClosingBalance = new BackOfficeUI.Controls.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtStartBalance = new BackOfficeUI.Controls.NumericUpDown();
            this.txtClosingBalance = new BackOfficeUI.Controls.NumericUpDown();
            this.lblStartBalance = new BackOfficeUI.Controls.Label();
            this.trvCostCenterTree = new BackOfficeUI.Controls.TreeView();
            this.TreeViewContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyAndPasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClosingBalance)).BeginInit();
            this.TreeViewContext.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNo
            // 
            this.txtNo.BackColor = System.Drawing.Color.White;
            this.txtNo.Clearable = true;
            resources.ApplyResources(this.txtNo, "txtNo");
            this.txtNo.IsRequired = true;
            this.txtNo.LockedInModes = 25;
            this.txtNo.Name = "txtNo";
            // 
            // lblNo
            // 
            resources.ApplyResources(this.lblNo, "lblNo");
            this.lblNo.Clearable = true;
            this.lblNo.IsRequired = false;
            this.lblNo.LockedInModes = 25;
            this.lblNo.Name = "lblNo";
            // 
            // chkIsDiable
            // 
            resources.ApplyResources(this.chkIsDiable, "chkIsDiable");
            this.chkIsDiable.Clearable = true;
            this.chkIsDiable.ForeColor = System.Drawing.Color.Black;
            this.chkIsDiable.IsRequired = false;
            this.chkIsDiable.LockedInModes = 25;
            this.chkIsDiable.Name = "chkIsDiable";
            this.chkIsDiable.UseVisualStyleBackColor = true;
            // 
            // lblNameAr
            // 
            resources.ApplyResources(this.lblNameAr, "lblNameAr");
            this.lblNameAr.Clearable = true;
            this.lblNameAr.IsRequired = false;
            this.lblNameAr.LockedInModes = 25;
            this.lblNameAr.Name = "lblNameAr";
            // 
            // lblNameEng
            // 
            resources.ApplyResources(this.lblNameEng, "lblNameEng");
            this.lblNameEng.Clearable = true;
            this.lblNameEng.IsRequired = false;
            this.lblNameEng.LockedInModes = 25;
            this.lblNameEng.Name = "lblNameEng";
            // 
            // lblIsDisable
            // 
            resources.ApplyResources(this.lblIsDisable, "lblIsDisable");
            this.lblIsDisable.Clearable = true;
            this.lblIsDisable.IsRequired = false;
            this.lblIsDisable.LockedInModes = 25;
            this.lblIsDisable.Name = "lblIsDisable";
            // 
            // txtNameAr
            // 
            this.txtNameAr.BackColor = System.Drawing.Color.White;
            this.txtNameAr.Clearable = true;
            this.txtNameAr.IsRequired = false;
            resources.ApplyResources(this.txtNameAr, "txtNameAr");
            this.txtNameAr.LockedInModes = 25;
            this.txtNameAr.Name = "txtNameAr";
            // 
            // txtNameEng
            // 
            this.txtNameEng.BackColor = System.Drawing.Color.White;
            this.txtNameEng.Clearable = true;
            this.txtNameEng.IsRequired = false;
            resources.ApplyResources(this.txtNameEng, "txtNameEng");
            this.txtNameEng.LockedInModes = 25;
            this.txtNameEng.Name = "txtNameEng";
            // 
            // lblClosingBalance
            // 
            resources.ApplyResources(this.lblClosingBalance, "lblClosingBalance");
            this.lblClosingBalance.Clearable = true;
            this.lblClosingBalance.IsRequired = false;
            this.lblClosingBalance.LockedInModes = 25;
            this.lblClosingBalance.Name = "lblClosingBalance";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtStartBalance);
            this.groupBox1.Controls.Add(this.txtClosingBalance);
            this.groupBox1.Controls.Add(this.txtNo);
            this.groupBox1.Controls.Add(this.lblNo);
            this.groupBox1.Controls.Add(this.chkIsDiable);
            this.groupBox1.Controls.Add(this.lblNameAr);
            this.groupBox1.Controls.Add(this.lblNameEng);
            this.groupBox1.Controls.Add(this.lblIsDisable);
            this.groupBox1.Controls.Add(this.txtNameAr);
            this.groupBox1.Controls.Add(this.txtNameEng);
            this.groupBox1.Controls.Add(this.lblClosingBalance);
            this.groupBox1.Controls.Add(this.lblStartBalance);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // txtStartBalance
            // 
            this.txtStartBalance.BackColor = System.Drawing.Color.White;
            this.txtStartBalance.Clearable = true;
            this.txtStartBalance.IsRequired = false;
            resources.ApplyResources(this.txtStartBalance, "txtStartBalance");
            this.txtStartBalance.LockedInModes = 25;
            this.txtStartBalance.Maximum = new decimal(new int[] {
            1874919423,
            2328306,
            0,
            0});
            this.txtStartBalance.Name = "txtStartBalance";
            // 
            // txtClosingBalance
            // 
            this.txtClosingBalance.BackColor = System.Drawing.Color.White;
            this.txtClosingBalance.Clearable = true;
            this.txtClosingBalance.IsRequired = false;
            resources.ApplyResources(this.txtClosingBalance, "txtClosingBalance");
            this.txtClosingBalance.LockedInModes = 25;
            this.txtClosingBalance.Maximum = new decimal(new int[] {
            1874919423,
            2328306,
            0,
            0});
            this.txtClosingBalance.Name = "txtClosingBalance";
            // 
            // lblStartBalance
            // 
            resources.ApplyResources(this.lblStartBalance, "lblStartBalance");
            this.lblStartBalance.Clearable = true;
            this.lblStartBalance.IsRequired = false;
            this.lblStartBalance.LockedInModes = 25;
            this.lblStartBalance.Name = "lblStartBalance";
            // 
            // trvCostCenterTree
            // 
            this.trvCostCenterTree.BackColor = System.Drawing.Color.White;
            this.trvCostCenterTree.Clearable = true;
            this.trvCostCenterTree.IsRequired = false;
            resources.ApplyResources(this.trvCostCenterTree, "trvCostCenterTree");
            this.trvCostCenterTree.LockedInModes = 25;
            this.trvCostCenterTree.Name = "trvCostCenterTree";
            this.trvCostCenterTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvCostCenterTree_AfterSelect);
            this.trvCostCenterTree.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trvCostCenterTree_MouseDown);
            // 
            // TreeViewContext
            // 
            this.TreeViewContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.copyAndPasteToolStripMenuItem});
            this.TreeViewContext.Name = "TreeViewContext";
            resources.ApplyResources(this.TreeViewContext, "TreeViewContext");
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            resources.ApplyResources(this.addToolStripMenuItem, "addToolStripMenuItem");
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // copyAndPasteToolStripMenuItem
            // 
            this.copyAndPasteToolStripMenuItem.Name = "copyAndPasteToolStripMenuItem";
            resources.ApplyResources(this.copyAndPasteToolStripMenuItem, "copyAndPasteToolStripMenuItem");
            this.copyAndPasteToolStripMenuItem.Click += new System.EventHandler(this.copyAndPasteToolStripMenuItem_Click);
            // 
            // frmCostCenter
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.trvCostCenterTree);
            this.Name = "frmCostCenter";
            this.AddNew += new BackOfficeUI.Controls.frmBaseDB.AddNewDelegate(this.frmCostCenter_AddNew);
            this.Edit += new BackOfficeUI.Controls.frmBaseDB.EditDelegate(this.frmCostCenter_Edit);
            this.Delete += new BackOfficeUI.Controls.frmBaseDB.DeleteDelegate(this.frmCostCenter_Delete);
            this.Save += new BackOfficeUI.Controls.frmBaseDB.SaveDelegate(this.frmCostCenter_Save);
            this.Cancel += new BackOfficeUI.Controls.frmBaseDB.CancelDelegate(this.frmCostCenter_Cancel);
            this.Find += new BackOfficeUI.Controls.frmBaseDB.FindDelegate(this.frmCostCenterTree_Find);
            this.Load += new System.EventHandler(this.frmCostCenter_Load);
            this.Controls.SetChildIndex(this.trvCostCenterTree, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClosingBalance)).EndInit();
            this.TreeViewContext.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.TextBox txtNo;
        private Controls.Label lblNo;
        private Controls.CheckBox chkIsDiable;
        private Controls.Label lblNameAr;
        private Controls.Label lblNameEng;
        private Controls.Label lblIsDisable;
        private Controls.TextBox txtNameAr;
        private Controls.TextBox txtNameEng;
        private Controls.Label lblClosingBalance;
        private System.Windows.Forms.GroupBox groupBox1;
        private Controls.Label lblStartBalance;
        private Controls.TreeView trvCostCenterTree;
        private System.Windows.Forms.ContextMenuStrip TreeViewContext;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyAndPasteToolStripMenuItem;
        private Controls.NumericUpDown txtClosingBalance;
        private Controls.NumericUpDown txtStartBalance;


    }
}
