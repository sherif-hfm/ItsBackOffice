﻿namespace BackOfficeUI.Accounting
{
    partial class frmAssetCatogry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAssetCatogry));
            this.chkIsDiable = new BackOfficeUI.Controls.CheckBox();
            this.lblNameAr = new BackOfficeUI.Controls.Label();
            this.lblNameEng = new BackOfficeUI.Controls.Label();
            this.lblIsDisable = new BackOfficeUI.Controls.Label();
            this.txtNameAr = new BackOfficeUI.Controls.TextBox();
            this.txtNameEng = new BackOfficeUI.Controls.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.trvAssetCatogryTree = new BackOfficeUI.Controls.TreeView();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkIsDiable
            // 
            resources.ApplyResources(this.chkIsDiable, "chkIsDiable");
            this.chkIsDiable.ForeColor = System.Drawing.Color.Black;
            this.chkIsDiable.IsRequired = false;
            this.chkIsDiable.LockedInModes = 25;
            this.chkIsDiable.Name = "chkIsDiable";
            this.chkIsDiable.UseVisualStyleBackColor = true;
            // 
            // lblNameAr
            // 
            resources.ApplyResources(this.lblNameAr, "lblNameAr");
            this.lblNameAr.IsRequired = false;
            this.lblNameAr.LockedInModes = 25;
            this.lblNameAr.Name = "lblNameAr";
            // 
            // lblNameEng
            // 
            resources.ApplyResources(this.lblNameEng, "lblNameEng");
            this.lblNameEng.IsRequired = false;
            this.lblNameEng.LockedInModes = 25;
            this.lblNameEng.Name = "lblNameEng";
            // 
            // lblIsDisable
            // 
            resources.ApplyResources(this.lblIsDisable, "lblIsDisable");
            this.lblIsDisable.IsRequired = false;
            this.lblIsDisable.LockedInModes = 25;
            this.lblIsDisable.Name = "lblIsDisable";
            // 
            // txtNameAr
            // 
            this.txtNameAr.BackColor = System.Drawing.Color.White;
            this.txtNameAr.IsRequired = false;
            resources.ApplyResources(this.txtNameAr, "txtNameAr");
            this.txtNameAr.LockedInModes = 25;
            this.txtNameAr.Name = "txtNameAr";
            // 
            // txtNameEng
            // 
            this.txtNameEng.BackColor = System.Drawing.Color.White;
            this.txtNameEng.IsRequired = false;
            resources.ApplyResources(this.txtNameEng, "txtNameEng");
            this.txtNameEng.LockedInModes = 25;
            this.txtNameEng.Name = "txtNameEng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkIsDiable);
            this.groupBox1.Controls.Add(this.lblNameAr);
            this.groupBox1.Controls.Add(this.lblNameEng);
            this.groupBox1.Controls.Add(this.lblIsDisable);
            this.groupBox1.Controls.Add(this.txtNameAr);
            this.groupBox1.Controls.Add(this.txtNameEng);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // trvAssetCatogryTree
            // 
            this.trvAssetCatogryTree.BackColor = System.Drawing.Color.White;
            this.trvAssetCatogryTree.IsRequired = false;
            resources.ApplyResources(this.trvAssetCatogryTree, "trvAssetCatogryTree");
            this.trvAssetCatogryTree.LockedInModes = 25;
            this.trvAssetCatogryTree.Name = "trvAssetCatogryTree";
            // 
            // frmAssetCatogry
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.trvAssetCatogryTree);
            this.Name = "frmAssetCatogry";
            this.AddNew += new BackOfficeUI.Controls.frmBaseDB.AddNewDelegate(this.frmAssetCatogry_AddNew);
            this.Edit += new BackOfficeUI.Controls.frmBaseDB.EditDelegate(this.frmAssetCatogry_Edit);
            this.Delete += new BackOfficeUI.Controls.frmBaseDB.DeleteDelegate(this.frmAssetCatogry_Delete);
            this.Save += new BackOfficeUI.Controls.frmBaseDB.SaveDelegate(this.frmAssetCatogry_Save);
            this.Cancel += new BackOfficeUI.Controls.frmBaseDB.CancelDelegate(this.frmAssetCatogry_Cancel);
            this.Load += new System.EventHandler(this.frmAssetCatogry_Load);
            this.Controls.SetChildIndex(this.trvAssetCatogryTree, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.CheckBox chkIsDiable;
        private Controls.Label lblNameAr;
        private Controls.Label lblNameEng;
        private Controls.Label lblIsDisable;
        private Controls.TextBox txtNameAr;
        private Controls.TextBox txtNameEng;
        private System.Windows.Forms.GroupBox groupBox1;
        private Controls.TreeView trvAssetCatogryTree;


    }
}
