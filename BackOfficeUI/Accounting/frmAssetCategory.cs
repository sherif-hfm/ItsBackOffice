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
    public partial class frmAssetCatogry : frmBaseDB
    {
        private AssetCatogry CrAssetCatogry;

        public frmAssetCatogry()
        {
            InitializeComponent();
        }

        private void frmAssetCatogry_Load(object sender, EventArgs e)
        {
            LoadAssetCatogryTree();
            trvAssetCatogryTree.ContextMenuStrip = this.TreeViewContext;
        }

        #region Functions for loading data from or to controls
        private void ShowGUI()
        {
            if (CrAssetCatogry != null)
            {
                txtNameAr.Text = CrAssetCatogry.AstCatName_Ara;
                txtNameEng.Text = CrAssetCatogry.AstCatName_Eng;
                txtNo.Text = CrAssetCatogry.AstCatId.ToString();
                chkIsDiable.Checked = CrAssetCatogry.IsDisable;
            }
            else
            {
                txtNameAr.Text = "";
                txtNameEng.Text = "";
                chkIsDiable.Checked = false;
                LoadAssetCatogryTree();
            }
        }


        private void LoadAssetCatogryTree()
        {
            List<AssetCatogry> Acc_List = AssetCatogry.GetAllAssetCatogryTree();
            // Call function here for bind treeview
            trvAssetCatogryTree.Nodes.Clear();
            CreateTreeView(Acc_List, null, null);
        }

        // recursion function
        private void CreateTreeView(List<AssetCatogry> source, int? parentID, TreeNode parentNode)
        {

            List<AssetCatogry> newSource = AssetCatogry.GetAllAssetCatogryTree();
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
                newnode.Tag = i.AstCatId.ToString();
                if (parentNode == null)
                {
                    trvAssetCatogryTree.Nodes.Add(newnode);
                }
                else
                {
                    parentNode.Nodes.Add(newnode);
                }
                CreateTreeView(source, i.AstCatId, newnode);
            }
        }

        private void GetDataFromGUI()
        {
            CrAssetCatogry.AstCatName_Ara = txtNameAr.Text;
            CrAssetCatogry.AstCatName_Eng = txtNameEng.Text;
            if (CrAssetCatogry.IsNew == true && trvAssetCatogryTree.SelectedNode != null && CrAssetCatogry.IsCopy == false)
                CrAssetCatogry.ParentId = Convert.ToInt32(trvAssetCatogryTree.SelectedNode.Tag);
            CrAssetCatogry.IsDisable = chkIsDiable.Checked;
        }

        #endregion

        #region Form events

        private void frmAssetCatogry_Save(object sender, ref bool _status)
        {
            GetDataFromGUI();
            DataSaveResult saveResult = CrAssetCatogry.Save();
            if (saveResult.SaveStatus == false)
            {
                _status = false;
            }
            else
            {
                CrAssetCatogry = null;
                ShowGUI();
            }
            trvAssetCatogryTree.Enabled = true;
        }

        private void frmAssetCatogry_Edit(object sender, ref bool _status)
        {
            CrAssetCatogry = AssetCatogry.FindByAstCatId(Convert.ToInt32(trvAssetCatogryTree.SelectedNode.Tag));
            if (CrAssetCatogry == null)
            {
                _status = false;
            }
            else
            {
                if (CrAssetCatogry.IsNew == true)
                {
                    _status = false;
                }
                else
                {
                    ShowGUI();
                }
            }
            trvAssetCatogryTree.Enabled = false;
        }

        private void frmAssetCatogry_Delete(object sender, ref bool _status)
        {
            CrAssetCatogry = AssetCatogry.FindByAstCatId(Convert.ToInt32(trvAssetCatogryTree.SelectedNode.Tag));
            DataDeleteResult result = CrAssetCatogry.Delete();

            _status = result.DeleteStatus;
            if (result.DeleteStatus == false)
            {
                MessageBox.Show(result.ErrorMessage);
            }
            else
            {
                CrAssetCatogry = null;
                ShowGUI();
            }
            trvAssetCatogryTree.Enabled = true;
        }

        private void frmAssetCatogry_Cancel(object sender)
        {
            CrAssetCatogry = null;
            ShowGUI();
            trvAssetCatogryTree.Enabled = true;
        }

        private void frmAssetCatogry_AddNew(object sender, ref bool _status)
        {
            CrAssetCatogry = new BackOfficeBL.Accounting.AssetCatogry();
        }

        #endregion



        private void trvAssetCatogryTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string AssetCatogryNo = trvAssetCatogryTree.SelectedNode != null ? trvAssetCatogryTree.SelectedNode.Tag.ToString() : "";
            if (AssetCatogryNo != "")
            {
                CrAssetCatogry = AssetCatogry.FindByAstCatId(Convert.ToInt32(trvAssetCatogryTree.SelectedNode.Tag.ToString()));
                ShowGUI();
            }
            trvAssetCatogryTree.Focus();
        }

        private void trvAssetCatogryTree_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            var treeNodeAtMousePosition = trvAssetCatogryTree.GetNodeAt(trvAssetCatogryTree.PointToClient(Control.MousePosition));
            var selectedTreeNode = trvAssetCatogryTree.SelectedNode;
            if (treeNodeAtMousePosition != null)
            {
                if (treeNodeAtMousePosition != selectedTreeNode)
                    trvAssetCatogryTree.SelectedNode = treeNodeAtMousePosition;
            }
            TreeViewContext.Text = trvAssetCatogryTree.SelectedNode.Text;
            trvAssetCatogryTree.Focus();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrAssetCatogry = new BackOfficeBL.Accounting.AssetCatogry();
            if (trvAssetCatogryTree.SelectedNode != null && trvAssetCatogryTree.SelectedNode.ToString() != "")
            {
                var parent = AssetCatogry.FindByAstCatId(Convert.ToInt32(trvAssetCatogryTree.SelectedNode.Tag.ToString()));
                CrAssetCatogry.ParentId = (Convert.ToInt32(trvAssetCatogryTree.SelectedNode.Tag.ToString()));
            }
            ShowGUI();
            this.FormStatus = FormStatusEnum.AddNew;
            trvAssetCatogryTree.Enabled = false;
        }


        private void copyAndPasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (trvAssetCatogryTree.SelectedNode != null && trvAssetCatogryTree.SelectedNode.ToString() != "")
            {
                CrAssetCatogry = AssetCatogry.FindByAstCatId(Convert.ToInt32(trvAssetCatogryTree.SelectedNode.Tag.ToString()));
                CrAssetCatogry.IsNew = true;
                CrAssetCatogry.IsCopy = true;
                CrAssetCatogry.AstCatId = Convert.ToInt32(null);
                ShowGUI();
                this.FormStatus = FormStatusEnum.Edit;
                trvAssetCatogryTree.Enabled = false;
            }
        }


    }
}
