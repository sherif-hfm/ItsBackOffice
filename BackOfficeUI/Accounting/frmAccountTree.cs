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

        public frmAccountTree()
        {
            InitializeComponent();
        }

        private void frmAccountTree_Load(object sender, EventArgs e)
        {
            LoadAccountTree();
        }

        private void ShowGUI()
        {
            if (CrAccount != null)
            {

                txtAccountNameAr.Text = CrAccount.AccountName_Ar;
                txtAccountNameEng.Text = CrAccount.AccountName_Eng;
                cmbCostCenter.SelectedValue = CrAccount.AccountTypeId.ToString();
                //txtAccountNameAr.Text                               =        CrAccount.AccountLevel     ;    
                txtAccountNo.Text = CrAccount.AccountCategoryId.ToString();
                //txtAccountNameAr.Text                               =        CrAccount.IsSubAccount     ;    
                chkStopAccount.Checked = CrAccount.IsDisableAccount;
                //txtAccountNameAr.Text                               =        CrAccount.ParentId         ;    
            }
        }
        private void LoadAccountTree()
        {
            List<Account> Acc_List = Account.GetAllAccountTree();
            // Call function here for bind treeview
            CreateTreeView(Acc_List, 0, null);
        }

        // recursion function
        private void CreateTreeView(List<Account> source, int parentID, TreeNode parentNode)
        {

            List<Account> newSource = Account.GetAllAccountTree();
            if (parentID == 0)
            {
                newSource = source.FindAll(a => a.ParentId.Equals(null));
            }
            else
            {
                newSource = source.FindAll(a => a.ParentId.Equals(parentID));
            }
            foreach (var i in newSource)
            {
                TreeNode newnode = new TreeNode(i.Name);
                if (parentNode == null)
                {
                    trvAccountTree.Nodes.Add(newnode);
                }
                else
                {
                    parentNode.Nodes.Add(newnode);
                }
                int AccountId = int.Parse(i.AccountID);
                CreateTreeView(source, AccountId, newnode);
            }
        }


        private void GetDataFromGUI()
        {
            CrAccount.AccountName_Ar = txtAccountNameAr.Text;
            CrAccount.AccountName_Eng = txtAccountNameEng.Text;
            CrAccount.AccountTypeId = int.Parse(cmbCostCenter.SelectedValue.ToString());
            //CrAccount.AccountLevel = txtAccountNameAr.Text;
            CrAccount.AccountCategoryId = int.Parse(txtAccountNo.Text);
            //CrAccount.IsSubAccount = txtAccountNameAr.Text;
            CrAccount.IsDisableAccount = chkStopAccount.Checked;
            //CrAccount.ParentId = txtAccountNameAr.Text;
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

        }

        private void frmAccountTree_Delete(object sender, ref bool _status)
        {

        }

        private void frmAccountTree_Cancel(object sender)
        {

        }

        private void frmAccountTree_AddNew(object sender, ref bool _status)
        {
            CrAccount = new BackOfficeBL.Accounting.Account();
        }
    }
}
