namespace BackOfficeUI.Accounting
{
    partial class frmAccountTree
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccountTree));
            this.trvAccountTree = new BackOfficeUI.Controls.TreeView();
            this.lblAccountNo = new BackOfficeUI.Controls.Label();
            this.lblAccountNameAr = new BackOfficeUI.Controls.Label();
            this.lblAccountNameEng = new BackOfficeUI.Controls.Label();
            this.lblAccountCategory = new BackOfficeUI.Controls.Label();
            this.txtAccountNo = new BackOfficeUI.Controls.TextBox();
            this.txtAccountNameAr = new BackOfficeUI.Controls.TextBox();
            this.txtAccountNameEng = new BackOfficeUI.Controls.TextBox();
            this.txtStartBalance = new BackOfficeUI.Controls.TextBox();
            this.lblStartBalance = new BackOfficeUI.Controls.Label();
            this.lblDebit = new BackOfficeUI.Controls.Label();
            this.txtDebit = new BackOfficeUI.Controls.TextBox();
            this.lblCreditor = new BackOfficeUI.Controls.Label();
            this.txtCreditor = new BackOfficeUI.Controls.TextBox();
            this.lblStopAccount = new BackOfficeUI.Controls.Label();
            this.lblAccountType = new BackOfficeUI.Controls.Label();
            this.chkStopAccount = new BackOfficeUI.Controls.CheckBox();
            this.cmbAccountType = new BackOfficeUI.Controls.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbAccountCategory = new BackOfficeUI.Controls.ComboBox();
            this.TreeViewContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyAndPasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.TreeViewContext.SuspendLayout();
            this.SuspendLayout();
            // 
            // trvAccountTree
            // 
            this.trvAccountTree.BackColor = System.Drawing.Color.White;
            this.trvAccountTree.Clearable = true;
            this.trvAccountTree.IsRequired = false;
            resources.ApplyResources(this.trvAccountTree, "trvAccountTree");
            this.trvAccountTree.LockedInModes = 25;
            this.trvAccountTree.Name = "trvAccountTree";
            this.trvAccountTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvAccountTree_AfterSelect);
            this.trvAccountTree.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trvAccountTree_MouseDown);
            // 
            // lblAccountNo
            // 
            resources.ApplyResources(this.lblAccountNo, "lblAccountNo");
            this.lblAccountNo.Clearable = true;
            this.lblAccountNo.IsRequired = false;
            this.lblAccountNo.LockedInModes = 25;
            this.lblAccountNo.Name = "lblAccountNo";
            // 
            // lblAccountNameAr
            // 
            resources.ApplyResources(this.lblAccountNameAr, "lblAccountNameAr");
            this.lblAccountNameAr.Clearable = true;
            this.lblAccountNameAr.IsRequired = false;
            this.lblAccountNameAr.LockedInModes = 25;
            this.lblAccountNameAr.Name = "lblAccountNameAr";
            // 
            // lblAccountNameEng
            // 
            resources.ApplyResources(this.lblAccountNameEng, "lblAccountNameEng");
            this.lblAccountNameEng.Clearable = true;
            this.lblAccountNameEng.IsRequired = false;
            this.lblAccountNameEng.LockedInModes = 25;
            this.lblAccountNameEng.Name = "lblAccountNameEng";
            // 
            // lblAccountCategory
            // 
            resources.ApplyResources(this.lblAccountCategory, "lblAccountCategory");
            this.lblAccountCategory.Clearable = true;
            this.lblAccountCategory.IsRequired = false;
            this.lblAccountCategory.LockedInModes = 25;
            this.lblAccountCategory.Name = "lblAccountCategory";
            // 
            // txtAccountNo
            // 
            this.txtAccountNo.BackColor = System.Drawing.Color.White;
            this.txtAccountNo.Clearable = false;
            resources.ApplyResources(this.txtAccountNo, "txtAccountNo");
            this.txtAccountNo.IsRequired = true;
            this.txtAccountNo.LockedInModes = 25;
            this.txtAccountNo.Name = "txtAccountNo";
            // 
            // txtAccountNameAr
            // 
            this.txtAccountNameAr.BackColor = System.Drawing.Color.White;
            this.txtAccountNameAr.Clearable = true;
            this.txtAccountNameAr.IsRequired = true;
            resources.ApplyResources(this.txtAccountNameAr, "txtAccountNameAr");
            this.txtAccountNameAr.LockedInModes = 25;
            this.txtAccountNameAr.Name = "txtAccountNameAr";
            // 
            // txtAccountNameEng
            // 
            this.txtAccountNameEng.BackColor = System.Drawing.Color.White;
            this.txtAccountNameEng.Clearable = true;
            this.txtAccountNameEng.IsRequired = true;
            resources.ApplyResources(this.txtAccountNameEng, "txtAccountNameEng");
            this.txtAccountNameEng.LockedInModes = 25;
            this.txtAccountNameEng.Name = "txtAccountNameEng";
            // 
            // txtStartBalance
            // 
            this.txtStartBalance.BackColor = System.Drawing.Color.White;
            this.txtStartBalance.Clearable = true;
            this.txtStartBalance.IsRequired = false;
            resources.ApplyResources(this.txtStartBalance, "txtStartBalance");
            this.txtStartBalance.LockedInModes = 25;
            this.txtStartBalance.Name = "txtStartBalance";
            // 
            // lblStartBalance
            // 
            resources.ApplyResources(this.lblStartBalance, "lblStartBalance");
            this.lblStartBalance.Clearable = true;
            this.lblStartBalance.IsRequired = false;
            this.lblStartBalance.LockedInModes = 25;
            this.lblStartBalance.Name = "lblStartBalance";
            // 
            // lblDebit
            // 
            resources.ApplyResources(this.lblDebit, "lblDebit");
            this.lblDebit.Clearable = true;
            this.lblDebit.IsRequired = false;
            this.lblDebit.LockedInModes = 25;
            this.lblDebit.Name = "lblDebit";
            // 
            // txtDebit
            // 
            this.txtDebit.BackColor = System.Drawing.Color.White;
            this.txtDebit.Clearable = true;
            this.txtDebit.IsRequired = false;
            resources.ApplyResources(this.txtDebit, "txtDebit");
            this.txtDebit.LockedInModes = 25;
            this.txtDebit.Name = "txtDebit";
            // 
            // lblCreditor
            // 
            resources.ApplyResources(this.lblCreditor, "lblCreditor");
            this.lblCreditor.Clearable = true;
            this.lblCreditor.IsRequired = false;
            this.lblCreditor.LockedInModes = 25;
            this.lblCreditor.Name = "lblCreditor";
            // 
            // txtCreditor
            // 
            this.txtCreditor.BackColor = System.Drawing.Color.White;
            this.txtCreditor.Clearable = true;
            this.txtCreditor.IsRequired = false;
            resources.ApplyResources(this.txtCreditor, "txtCreditor");
            this.txtCreditor.LockedInModes = 25;
            this.txtCreditor.Name = "txtCreditor";
            // 
            // lblStopAccount
            // 
            resources.ApplyResources(this.lblStopAccount, "lblStopAccount");
            this.lblStopAccount.Clearable = true;
            this.lblStopAccount.IsRequired = false;
            this.lblStopAccount.LockedInModes = 25;
            this.lblStopAccount.Name = "lblStopAccount";
            // 
            // lblAccountType
            // 
            resources.ApplyResources(this.lblAccountType, "lblAccountType");
            this.lblAccountType.Clearable = true;
            this.lblAccountType.IsRequired = false;
            this.lblAccountType.LockedInModes = 25;
            this.lblAccountType.Name = "lblAccountType";
            // 
            // chkStopAccount
            // 
            resources.ApplyResources(this.chkStopAccount, "chkStopAccount");
            this.chkStopAccount.Clearable = true;
            this.chkStopAccount.ForeColor = System.Drawing.Color.Black;
            this.chkStopAccount.IsRequired = false;
            this.chkStopAccount.LockedInModes = 25;
            this.chkStopAccount.Name = "chkStopAccount";
            this.chkStopAccount.UseVisualStyleBackColor = true;
            // 
            // cmbAccountType
            // 
            this.cmbAccountType.BackColor = System.Drawing.Color.White;
            this.cmbAccountType.Clearable = true;
            this.cmbAccountType.DefaultIndex = -1;
            this.cmbAccountType.FormattingEnabled = true;
            this.cmbAccountType.IsRequired = true;
            resources.ApplyResources(this.cmbAccountType, "cmbAccountType");
            this.cmbAccountType.LockedInModes = 25;
            this.cmbAccountType.Name = "cmbAccountType";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbAccountCategory);
            this.groupBox1.Controls.Add(this.txtAccountNo);
            this.groupBox1.Controls.Add(this.cmbAccountType);
            this.groupBox1.Controls.Add(this.lblAccountNo);
            this.groupBox1.Controls.Add(this.chkStopAccount);
            this.groupBox1.Controls.Add(this.lblAccountNameAr);
            this.groupBox1.Controls.Add(this.lblAccountType);
            this.groupBox1.Controls.Add(this.lblAccountNameEng);
            this.groupBox1.Controls.Add(this.lblStopAccount);
            this.groupBox1.Controls.Add(this.lblAccountCategory);
            this.groupBox1.Controls.Add(this.lblCreditor);
            this.groupBox1.Controls.Add(this.txtAccountNameAr);
            this.groupBox1.Controls.Add(this.txtCreditor);
            this.groupBox1.Controls.Add(this.txtAccountNameEng);
            this.groupBox1.Controls.Add(this.lblDebit);
            this.groupBox1.Controls.Add(this.txtDebit);
            this.groupBox1.Controls.Add(this.txtStartBalance);
            this.groupBox1.Controls.Add(this.lblStartBalance);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // cmbAccountCategory
            // 
            this.cmbAccountCategory.BackColor = System.Drawing.Color.White;
            this.cmbAccountCategory.Clearable = true;
            this.cmbAccountCategory.DefaultIndex = -1;
            this.cmbAccountCategory.FormattingEnabled = true;
            this.cmbAccountCategory.IsRequired = true;
            resources.ApplyResources(this.cmbAccountCategory, "cmbAccountCategory");
            this.cmbAccountCategory.LockedInModes = 25;
            this.cmbAccountCategory.Name = "cmbAccountCategory";
            // 
            // TreeViewContext
            // 
            this.TreeViewContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.copyAndPasteToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.TreeViewContext.Name = "TreeViewContext";
            resources.ApplyResources(this.TreeViewContext, "TreeViewContext");
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            resources.ApplyResources(this.addToolStripMenuItem, "addToolStripMenuItem");
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            resources.ApplyResources(this.editToolStripMenuItem, "editToolStripMenuItem");
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // copyAndPasteToolStripMenuItem
            // 
            this.copyAndPasteToolStripMenuItem.Name = "copyAndPasteToolStripMenuItem";
            resources.ApplyResources(this.copyAndPasteToolStripMenuItem, "copyAndPasteToolStripMenuItem");
            this.copyAndPasteToolStripMenuItem.Click += new System.EventHandler(this.copyAndPasteToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            resources.ApplyResources(this.pasteToolStripMenuItem, "pasteToolStripMenuItem");
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // frmAccountTree
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.trvAccountTree);
            this.Name = "frmAccountTree";
            this.AddNew += new BackOfficeUI.Controls.frmBaseDB.AddNewDelegate(this.frmAccountTree_AddNew);
            this.Edit += new BackOfficeUI.Controls.frmBaseDB.EditDelegate(this.frmAccountTree_Edit);
            this.Delete += new BackOfficeUI.Controls.frmBaseDB.DeleteDelegate(this.frmAccountTree_Delete);
            this.Save += new BackOfficeUI.Controls.frmBaseDB.SaveDelegate(this.frmAccountTree_Save);
            this.Cancel += new BackOfficeUI.Controls.frmBaseDB.CancelDelegate(this.frmAccountTree_Cancel);
            this.Find += new BackOfficeUI.Controls.frmBaseDB.FindDelegate(this.frmAccountTree_Find);
            this.Load += new System.EventHandler(this.frmAccountTree_Load);
            this.Controls.SetChildIndex(this.trvAccountTree, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.TreeViewContext.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.TreeView trvAccountTree;
        private Controls.Label lblAccountNo;
        private Controls.Label lblAccountNameAr;
        private Controls.Label lblAccountNameEng;
        private Controls.Label lblAccountCategory;
        private Controls.TextBox txtAccountNo;
        private Controls.TextBox txtAccountNameAr;
        private Controls.TextBox txtAccountNameEng;
        private Controls.TextBox txtStartBalance;
        private Controls.Label lblStartBalance;
        private Controls.Label lblDebit;
        private Controls.Label lblCreditor;
        private Controls.TextBox txtCreditor;
        private Controls.Label lblStopAccount;
        private Controls.Label lblAccountType;
        private Controls.CheckBox chkStopAccount;
        private Controls.ComboBox cmbAccountType;
        private System.Windows.Forms.GroupBox groupBox1;
        private Controls.ComboBox cmbAccountCategory;
        private Controls.TextBox txtDebit;
        private System.Windows.Forms.ContextMenuStrip TreeViewContext;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyAndPasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;

    }
}
