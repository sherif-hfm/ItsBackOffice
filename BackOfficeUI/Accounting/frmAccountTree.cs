using System;
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
        public frmAccountTree()
        {
            InitializeComponent();
        }

        private void frmAccountTree_Load(object sender, EventArgs e)
        {
            LoadAccountTree();
            LoadLookup();
        }

        #region Functions for loading data from or to controls
        private void ShowGUI()
        {
            if (CrAccount != null)
            {
                txtAccountNameAr.Text = CrAccount.AccountName_Ar;
                txtAccountNameEng.Text = CrAccount.AccountName_Eng;
                txtAccountNo.Text = CrAccount.AccountID;
                cmbAccountType.SelectedValue = CrAccount.AccountTypeId;
                cmbAccountCategory.SelectedValue = CrAccount.AccountCategoryId;
                chkStopAccount.Checked = CrAccount.IsDisableAccount;
            }
            else
            {
                txtAccountNameAr.Text = "";
                txtAccountNameEng.Text = "";
                txtAccountNo.Text = "";
                chkStopAccount.Checked = false;
                txtStartBalance.Text = "";
                txtDebit.Text = "";
                txtCreditor.Text = "";
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
            if (CrAccount.IsNew == true && trvAccountTree.SelectedNode!=null)
                CrAccount.ParentId = trvAccountTree.SelectedNode.Tag.ToString();
            CrAccount.AccountID = txtAccountNo.Text;
            CrAccount.IsDisableAccount = chkStopAccount.Checked;
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
            ShowGUI();
        }

        private void frmAccountTree_AddNew(object sender, ref bool _status)
        {
            CrAccount = new BackOfficeBL.Accounting.Account();
            CrAccounttype = new BackOfficeBL.Accounting.Accounttype();
            CrAccountCategory = new BackOfficeBL.Accounting.AccountCategory();
        }

        #endregion
    }
}
