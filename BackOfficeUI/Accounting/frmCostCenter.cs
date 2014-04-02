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
            trvCostCenterTree.ContextMenuStrip = this.TreeViewContext;
        }

        #region Functions for loading data from or to controls
        private void ShowGUI()
        {
            if (CrCostCenter != null)
            {
                txtNameAr.Text = CrCostCenter.CostCenterName_Ara;
                txtNameEng.Text = CrCostCenter.CostCenterName_Eng;
                txtNo.Text = CrCostCenter.CostCenterId.ToString();
                
                txtStartBalance.Value = CrCostCenter.CostOpenBalance;
                txtClosingBalance.Value = CrCostCenter.ClosingBalance;
                chkIsDiable.Checked = CrCostCenter.IsDisable;
            }
            else
            {
                txtNameAr.Text = "";
                txtNameEng.Text = "";
                chkIsDiable.Checked = false;
                txtNo.Text = "";
                txtStartBalance.Value = 0;
                txtClosingBalance.Value = 0;
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
                newnode.Name = i.CostCenterId.ToString();
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
            CrCostCenter.CostOpenBalance =txtStartBalance.Value;
            CrCostCenter.ClosingBalance = txtClosingBalance.Value;
            if (CrCostCenter.IsNew == true && trvCostCenterTree.SelectedNode != null && CrCostCenter.IsCopy==false)
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
                trvCostCenterTree.Enabled = true;
        }

        private void frmCostCenter_Cancel(object sender)
        {
            CrCostCenter = null;
            ShowGUI();
            trvCostCenterTree.Enabled = true;
        }

        private void frmCostCenter_AddNew(object sender, ref bool _status)
        {
            CrCostCenter = new BackOfficeBL.Accounting.CostCenter();
        }

        #endregion


        private void trvCostCenterTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (this.FormStatus == FormStatusEnum.Edit)
            {
                trvCostCenterTree.SelectedNode = trvCostCenterTree.Nodes.Find(trvCostCenterTree.SelectedNode.Tag.ToString(), true)[0];
                return;
            }
            string CostCenterNo = trvCostCenterTree.SelectedNode != null ? trvCostCenterTree.SelectedNode.Tag.ToString() : "";
            if (CostCenterNo != "")
            {
                CrCostCenter = CostCenter.FindByCostCenterId(Convert.ToInt32(trvCostCenterTree.SelectedNode.Tag.ToString()));
                ShowGUI();
            }
            trvCostCenterTree.Focus();
        }

        private void trvCostCenterTree_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right || this.FormStatus != FormStatusEnum.Edit)
            {
                TreeViewContext.Enabled = false;
                return;
            }
            TreeViewContext.Enabled = true;
            var treeNodeAtMousePosition = trvCostCenterTree.GetNodeAt(trvCostCenterTree.PointToClient(Control.MousePosition));
            var selectedTreeNode = trvCostCenterTree.SelectedNode;
            if (treeNodeAtMousePosition != null)
            {
                if (treeNodeAtMousePosition != selectedTreeNode)
                    trvCostCenterTree.SelectedNode = treeNodeAtMousePosition;
            }
            TreeViewContext.Text = trvCostCenterTree.SelectedNode.Text;
            trvCostCenterTree.Focus();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrCostCenter = new BackOfficeBL.Accounting.CostCenter();
            if (trvCostCenterTree.SelectedNode != null && trvCostCenterTree.SelectedNode.ToString() != "")
            {
                var parent = CostCenter.FindByCostCenterId(Convert.ToInt32(trvCostCenterTree.SelectedNode.Tag.ToString()));
                CrCostCenter.ParentId = (Convert.ToInt32(trvCostCenterTree.SelectedNode.Tag.ToString()));
            }
            ShowGUI();
            this.FormStatus = FormStatusEnum.AddNew;
        }


        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (trvCostCenterTree.SelectedNode != null && trvCostCenterTree.SelectedNode.ToString() != "")
            {
                CrCostCenter = CostCenter.FindByCostCenterId(Convert.ToInt32(trvCostCenterTree.SelectedNode.Tag));
                DataDeleteResult result = CrCostCenter.Delete();
                if (result.DeleteStatus == false)
                {
                    MessageBox.Show(result.ErrorMessage);
                }
                else
                {
                    CrCostCenter = null;
                    ShowGUI();
                    this.FormStatus = FormStatusEnum.DataPreview;
                }
            }
        }

        private void copyAndPasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (trvCostCenterTree.SelectedNode != null && trvCostCenterTree.SelectedNode.ToString() != "")
            {
                CrCostCenter = CostCenter.FindByCostCenterId(Convert.ToInt32(trvCostCenterTree.SelectedNode.Tag.ToString()));
                CrCostCenter.IsNew = true;
                CrCostCenter.IsCopy = true;
                CrCostCenter.CostCenterId = Convert.ToInt32(null);
                ShowGUI();
                this.FormStatus = FormStatusEnum.Edit;
            }
        }


        private void frmCostCenterTree_Find(object sender, Dictionary<string, object> _findFields)
        {

            var CostCenterId = _findFields["CostCenterId"];

            trvCostCenterTree.SelectedNode = trvCostCenterTree.Nodes.Find(CostCenterId.ToString(), true)[0];
        }



    }
}
