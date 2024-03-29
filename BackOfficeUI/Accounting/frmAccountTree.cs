﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BackOfficeUI.Controls;
using BackOfficeBL;
using BackOfficeBL.Accounting;

namespace BackOfficeUI.Accounting
{
    public partial class frmAccountTree : frmBaseDB
    {
        private BackOfficeBL.Accounting.Account CrAccount;
        private BackOfficeBL.Accounting.Accounttype CrAccounttype;
        private BackOfficeBL.Accounting.AccountCategory CrAccountCategory;
        IControl Parent;
        public frmAccountTree()
        {
            InitializeComponent();
        }

        private void frmAccountTree_Load(object sender, EventArgs e)
        {
            LoadAccountTree();
            LoadLookup();
            trvAccountTree.ContextMenuStrip = this.TreeViewContext;
        }

        #region Functions for loading data from or to controls
        private void ShowGUI()
        {
            if (CrAccount != null)
            {
                txtAccountNameAr.Text = CrAccount.AccountName_Ar;
                txtAccountNameEng.Text = CrAccount.AccountName_Eng;
                txtAccountNo.Text = CrAccount.AccountID;
                cmbAccountType.SelectedValue = CrAccount.AccountTypeId != null ? CrAccount.AccountTypeId : 1;
                cmbAccountCategory.SelectedValue = CrAccount.AccountCategoryId != null ? CrAccount.AccountCategoryId : 1;
                chkStopAccount.Checked = CrAccount.IsDisableAccount != null ? CrAccount.IsDisableAccount : false;
                chkSubAccount.Checked = CrAccount.IsSubAccount != null ? CrAccount.IsSubAccount : false;
                ///
                txtAccountRef1.Text = CrAccount.AccountRef1;
                txtAccountRef2.Text = CrAccount.AccountRef2;
            }
            else
            {
                txtAccountNameAr.Text = "";
                txtAccountNameEng.Text = "";
                txtAccountNo.Text = "";
                chkStopAccount.Checked = false;
                chkSubAccount.Checked = false;
                txtAccountRef1.Text = "";
                txtAccountRef2.Text = "";
                LoadAccountTree();
            }
        }

        private void LoadLookup()
        {
            cmbAccountType.Items.Clear();
            cmbAccountCategory.Items.Clear();
            cmbAccountType.ValueMember = "TypeID";
            cmbAccountType.DisplayMember = "Name";
            cmbAccountType.DataSource = Accounttype.GetAllAccounttype();
            cmbAccountCategory.ValueMember = "CategoryId";
            cmbAccountCategory.DisplayMember = "Name";
            cmbAccountCategory.DataSource = AccountCategory.GetAllAccountCategory();
        }

        private void LoadAccountTree()
        {
            List<Account> Acc_List = Account.GetAllAccountTree();
            // Call function here for bind treeview
            trvAccountTree.Nodes.Clear();
            CreateTreeView(Acc_List, "", null);
        }

        // recursion function
        private void CreateTreeView(List<Account> source, string parentID, TreeNode parentNode)
        {

            List<Account> newSource = new List<Account>();
            if (parentID == "")
            {
                newSource = source.FindAll(a => a.ParentId == null);
            }
            else
            {
                newSource = source.FindAll(a => a.ParentId == parentID);
            }
            foreach (var i in newSource)
            {
                TreeNode newnode = new TreeNode(i.NameAndNo);
                newnode.Name = i.AccountID;
                newnode.Tag = i.AccountID;
                if (parentNode == null)
                {
                    trvAccountTree.Nodes.Add(newnode);
                }
                else
                {
                    parentNode.Nodes.Add(newnode);
                }
                CreateTreeView(source, i.AccountID, newnode);
            }
        }

        private void GetDataFromGUI()
        {
            CrAccount.AccountName_Ar = txtAccountNameAr.Text;
            CrAccount.AccountName_Eng = txtAccountNameEng.Text;
            CrAccount.AccountTypeId = int.Parse(cmbAccountType.SelectedValue.ToString());
            CrAccount.AccountCategoryId = int.Parse(cmbAccountCategory.SelectedValue.ToString());
            if (CrAccount.IsNew == true && trvAccountTree.SelectedNode != null && CrAccount.IsCopy == false)
                CrAccount.ParentId = trvAccountTree.SelectedNode.Tag.ToString();
            CrAccount.AccountID = txtAccountNo.Text;
            CrAccount.IsDisableAccount = chkStopAccount.Checked;
            CrAccount.IsSubAccount = chkSubAccount.Checked;
            CrAccount.AccountRef1 = txtAccountRef1.Text;
            CrAccount.AccountRef2 = txtAccountRef2.Text;
        }

        #endregion

        #region Form events

        private void frmAccountTree_Save(object sender, ref bool _status)
        {
            GetDataFromGUI();
            DataSaveResult saveResult = CrAccount.Save();
            if (saveResult.SaveStatus == false)
            {
                _status = false;
            }
            else
            {
                CrAccount = null;
                ShowGUI();
                //trvAccountTree.Enabled = true;
                cmbAccountType.Enabled = true;
            }
        }

        private void frmAccountTree_Edit(object sender, ref bool _status)
        {
            CrAccount = Account.FindByAccountID(trvAccountTree.SelectedNode.Tag.ToString());
            if (CrAccount == null)
            {
                _status = false;
            }
            else
            {
                if (CrAccount.IsNew == true)
                {
                    _status = false;
                }
                else
                {
                    ShowGUI();
                }
            }
        }

        private void frmAccountTree_Delete(object sender, ref bool _status)
        {
            CrAccount = Account.FindByAccountID(trvAccountTree.SelectedNode.Tag.ToString());
            DataDeleteResult result = CrAccount.Delete();

            _status = result.DeleteStatus;
            if (result.DeleteStatus == false)
            {
                MessageBox.Show(result.ErrorMessage);
            }
            else
            {
                CrAccount = null;
                ShowGUI();
            }
        }

        private void frmAccountTree_Cancel(object sender)
        {
            CrAccount = null;
            cmbAccountType.Enabled = true;
            ShowGUI();
        }

        private void frmAccountTree_AddNew(object sender, ref bool _status)
        {
            CrAccount = new BackOfficeBL.Accounting.Account();
            CrAccounttype = new BackOfficeBL.Accounting.Accounttype();
            CrAccountCategory = new BackOfficeBL.Accounting.AccountCategory();
            txtAccountNo.Text = Account.getNewId((trvAccountTree.SelectedNode != null ? trvAccountTree.SelectedNode.Tag.ToString() : ""),false);
        }

        #endregion

        private void trvAccountTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (this.FormStatus == FormStatusEnum.Edit)
            {
                trvAccountTree.SelectedNode = trvAccountTree.Nodes.Find(trvAccountTree.SelectedNode.Tag.ToString(), true)[0];
                return;
            }
            string AccountNo = trvAccountTree.SelectedNode != null ? trvAccountTree.SelectedNode.Tag.ToString() : "";
            if (AccountNo != "")
            {
                CrAccount = Account.FindByAccountID(trvAccountTree.SelectedNode.Tag.ToString());
                ShowGUI();
            }
            trvAccountTree.Focus();
        }

        private void trvAccountTree_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right || this.FormStatus != FormStatusEnum.Edit||chkSubAccount.Checked)
            {
                TreeViewContext.Enabled = false;
                return;
            }
            TreeViewContext.Enabled = true;
            var treeNodeAtMousePosition = trvAccountTree.GetNodeAt(trvAccountTree.PointToClient(Control.MousePosition));
            var selectedTreeNode = trvAccountTree.SelectedNode;
            if (treeNodeAtMousePosition != null)
            {
                if (treeNodeAtMousePosition != selectedTreeNode)
                    trvAccountTree.SelectedNode = treeNodeAtMousePosition;
            }
            TreeViewContext.Text = trvAccountTree.SelectedNode.Text;
            trvAccountTree.Focus();
        }


        #region context menu events
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrAccount = new BackOfficeBL.Accounting.Account();
            CrAccounttype = new BackOfficeBL.Accounting.Accounttype();
            CrAccountCategory = new BackOfficeBL.Accounting.AccountCategory();
            CrAccount.AccountID = Account.getNewId(trvAccountTree.SelectedNode.Tag.ToString(),false);
            if (trvAccountTree.SelectedNode != null && trvAccountTree.SelectedNode.ToString() != "")
            {
                var parent = Account.FindByAccountID(trvAccountTree.SelectedNode.Tag.ToString());
                CrAccount.AccountTypeId = parent.AccountTypeId;
                CrAccount.ParentId = trvAccountTree.SelectedNode.ToString();
            }
            ShowGUI();
            this.FormStatus = FormStatusEnum.AddNew;
            //trvAccountTree.Enabled = false;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (trvAccountTree.SelectedNode != null && trvAccountTree.SelectedNode.ToString() != "")
            {
                CrAccount = Account.FindByAccountID(trvAccountTree.SelectedNode.Tag.ToString());
                DataDeleteResult result = CrAccount.Delete();
                if (result.DeleteStatus == false)
                {
                    MessageBox.Show(result.ErrorMessage);
                }
                else
                {
                    CrAccount = null;
                    ShowGUI();
                    this.FormStatus = FormStatusEnum.DataPreview;
                }
            }
        }

        private void copyAndPasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (trvAccountTree.SelectedNode != null && trvAccountTree.SelectedNode.ToString() != "")
            {
                CrAccount = Account.FindByAccountID(trvAccountTree.SelectedNode.Tag.ToString());
                CrAccount.AccountID = Account.getNewId(CrAccount.ParentId,CrAccount.IsSubAccount);
                CrAccount.IsNew = true;
                CrAccount.IsCopy = true;
                ShowGUI();
                this.FormStatus = FormStatusEnum.Edit;
                cmbAccountType.Enabled = false;
                //trvAccountTree.Enabled = false;
            }
        }

        private void chkSubAccount_CheckedChanged(object sender, EventArgs e)
        {
            txtAccountNo.Text = Account.getNewId(trvAccountTree.SelectedNode.Tag.ToString(), chkSubAccount.Checked);
        }
        #endregion

        #region search area
        private void frmAccountTree_Find(object sender, Dictionary<string, object> _findFields)
        {
            var accountId = _findFields["AccountID"];
            trvAccountTree.SelectedNode = trvAccountTree.Nodes.Find(accountId.ToString(), true)[0];
        }
        #endregion

        private void reconileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (trvAccountTree.SelectedNode != null && trvAccountTree.SelectedNode.ToString() != "")
            {
                var control = new frmReconcile(trvAccountTree.SelectedNode.Tag.ToString());
                control.MdiParent = this.MdiParent;
                control.Show();
                this.Close();

            }
        }



    }
}
