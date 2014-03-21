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
            trvAccountTree.UnLock();
            LoadAccountTree();
            LoadLookup();
        }

        private void ShowGUI()
        {
            if (CrAccount != null)
            {
                txtAccountNameAr.Text = CrAccount.AccountName_Ar;
                txtAccountNameEng.Text = CrAccount.AccountName_Eng;
                cmbAccountType.SelectedValue = CrAccount.AccountTypeId.ToString();
                txtAccountNo.Text = CrAccount.AccountID;
                cmbAccountCategory.SelectedValue = CrAccount.AccountCategoryId.ToString(); 
                chkStopAccount.Checked = CrAccount.IsDisableAccount;
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
            CreateTreeView(Acc_List, "" , null);
        }

        // recursion function
        private void CreateTreeView(List<Account> source, string parentID, TreeNode parentNode)
        {

            List<Account> newSource = Account.GetAllAccountTree();
            if (parentID == "")
            {
                newSource = source.FindAll(a => a.ParentId== null );
            }
            else
            {
                newSource = source.FindAll(a => a.ParentId== parentID);
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
            CrAccount.ParentId = trvAccountTree.SelectedNode.Tag.ToString();
            CrAccount.AccountID = txtAccountNo.Text;
            CrAccount.IsDisableAccount = chkStopAccount.Checked;
        }

        private void frmAccountTree_Save(object sender, ref bool _status)
        {
            GetDataFromGUI();
            DataSaveResult saveResult = CrAccount.Save();
            if (saveResult.SaveStatus == false)
                _status = false;
            else
                ShowGUI();
        }

        private void frmAccountTree_Edit(object sender, ref bool _status)
        {
            if (CrAccount == null)
                _status = false;
            else
                if (CrAccount.IsNew == true)
                    _status = false;

        }

        private void frmAccountTree_Delete(object sender, ref bool _status)
        {
            if (CrAccount == null)
            {
                _status = false;
                return;
            }
            else
            {
                if (CrAccount.IsNew == true)
                {
                    _status = false;
                    return;
                }
            }

            DataDeleteResult result = CrAccount.Delete();
            _status = result.DeleteStatus;
            if (result.DeleteStatus == false)
                MessageBox.Show(result.ErrorMessage);
            else
                CrAccount = null;
        }

        private void frmAccountTree_Cancel(object sender)
        {

        }

        private void frmAccountTree_AddNew(object sender, ref bool _status)
        {
            CrAccount = new BackOfficeBL.Accounting.Account();
            CrAccounttype = new BackOfficeBL.Accounting.Accounttype();
            CrAccountCategory = new BackOfficeBL.Accounting.AccountCategory();
        }

    }
}
