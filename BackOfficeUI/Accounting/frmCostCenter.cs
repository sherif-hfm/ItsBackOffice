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
    public partial class frmCostCenter : frmBaseDB
    {
        private CostCenter CrCostCenter;

        public frmCostCenter()
        {
            InitializeComponent();
        }

        private void frmCostCenter_Load(object sender, EventArgs e)
        {
            LoadCostCenterTree();
        }

        #region Functions for loading data from or to controls
        private void ShowGUI()
        {
            if (CrCostCenter != null)
            {
                txtNameAr.Text = CrCostCenter.CostCenterName_Ara;
                txtNameEng.Text = CrCostCenter.CostCenterName_Eng;
                txtNo.Text = CrCostCenter.CostCenterId.ToString();
                
                txtStartBalance.Text = CrCostCenter.CostOpenBalance.ToString();
                txtClosingBalance.Text = CrCostCenter.ClosingBalance.ToString();
                chkIsDiable.Checked = CrCostCenter.IsDisable;
            }
            else
            {
                txtNameAr.Text = "";
                txtNameEng.Text = "";
                chkIsDiable.Checked = false;
                txtNo.Text = "";
                txtStartBalance.Text = "";
                txtClosingBalance.Text = "";
                LoadCostCenterTree();
            }
        }


        private void LoadCostCenterTree()
        {
            List<CostCenter> Acc_List = CostCenter.GetAllCostCenterTree();
            // Call function here for bind treeview
            trvCostCenterTree.Nodes.Clear();
            CreateTreeView(Acc_List, null, null);
        }

        // recursion function
        private void CreateTreeView(List<CostCenter> source, int? parentID, TreeNode parentNode)
        {

            List<CostCenter> newSource = CostCenter.GetAllCostCenterTree();
            if (parentID == null)
            {
                newSource = source.FindAll(a => a.ParentId == null);
            }
            else
            {
                newSource = source.FindAll(a => a.ParentId == parentID);
            }
            foreach (var i in newSource)
            {
                TreeNode newnode = new TreeNode(i.Name);
                newnode.Tag = i.CostCenterId;
                if (parentNode == null)
                {
                    trvCostCenterTree.Nodes.Add(newnode);
                }
                else
                {
                    parentNode.Nodes.Add(newnode);
                }
                CreateTreeView(source, i.CostCenterId, newnode);
            }
        }

        private void GetDataFromGUI()
        {
            CrCostCenter.CostCenterName_Ara = txtNameAr.Text;
            CrCostCenter.CostCenterName_Eng = txtNameEng.Text;
            CrCostCenter.CostOpenBalance =decimal.Parse( txtStartBalance.Text);
            CrCostCenter.ClosingBalance = decimal.Parse(txtClosingBalance.Text);
            if (CrCostCenter.IsNew == true && trvCostCenterTree.SelectedNode!=null)
                CrCostCenter.ParentId = Convert.ToInt32(trvCostCenterTree.SelectedNode.Tag.ToString());
            CrCostCenter.IsDisable = chkIsDiable.Checked;
        }

        #endregion

        #region Form events

        private void frmCostCenter_Save(object sender, ref bool _status)
        {
            GetDataFromGUI();
            DataSaveResult saveResult = CrCostCenter.Save();
            if (saveResult.SaveStatus == false)
            {
                _status = false;
            }
            else
            {
                CrCostCenter = null;
                ShowGUI();
            }
        }

        private void frmCostCenter_Edit(object sender, ref bool _status)
        {
            CrCostCenter = CostCenter.FindByCostCenterId(Convert.ToInt32(trvCostCenterTree.SelectedNode.Tag.ToString()));
            if (CrCostCenter == null)
            {
                _status = false;
            }
            else
            {
                if (CrCostCenter.IsNew == true)
                {
                    _status = false;
                }
                else
                {
                    ShowGUI();
                }
            }
        }

        private void frmCostCenter_Delete(object sender, ref bool _status)
        {
            CrCostCenter = CostCenter.FindByCostCenterId(Convert.ToInt32(trvCostCenterTree.SelectedNode.Tag.ToString()));
            DataDeleteResult result = CrCostCenter.Delete();

            _status = result.DeleteStatus;
            if (result.DeleteStatus == false)
            {
                MessageBox.Show(result.ErrorMessage);
            }
            else
            {
                CrCostCenter = null;
                ShowGUI();
            }
        }

        private void frmCostCenter_Cancel(object sender)
        {
            CrCostCenter = null;
            ShowGUI();
        }

        private void frmCostCenter_AddNew(object sender, ref bool _status)
        {
            CrCostCenter = new BackOfficeBL.Accounting.CostCenter();
        }

        #endregion

    }
}
