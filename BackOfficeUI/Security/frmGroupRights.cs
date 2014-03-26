using BackOfficeUI.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BackOfficeBL.Security;
using BackOfficeUI.Security.SecurityControls;
namespace BackOfficeUI.Security
{
    public partial class frmGroupRights : frmBaseDB
    {
        private Group CrGroup = null;

        public frmGroupRights()
        {
            InitializeComponent();
        }

        private void frmGroupRights_Load(object sender, EventArgs e)
        {
            LoadAllForms();
            treeMenu.ContextMenuStrip = this.menu;
        }

        private void LoadAllForms()
        {
            List<BackOfficeBL.Security.MenuItem> allForms = BackOfficeBL.Security.MenuItem.LoadAllForms();
            foreach (var form in allForms)
            {
                SecurityTreeNode node = new SecurityTreeNode();
                node.Name = form.MenuID;
                node.Text = form.Text;
                node.MenuItem = form;
                node.GroupAllowedFunctions = 0;
                if (string.IsNullOrEmpty(form.ParentMenuID) == true)
                    treeMenu.Nodes.Add(node);
                else
                {
                    TreeNode[] prntNodes= treeMenu.Nodes.Find(form.ParentMenuID, true);
                    if (prntNodes.Length > 0)
                    {
                        var prntNode = prntNodes.First();
                        prntNode.Nodes.Add(node);
                    }
                }
            }
        }

        private void treeMenu_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Checked == true)
            {
                if (e.Node.Parent != null)
                    e.Node.Parent.Checked = true;
            }
            else
            {
                UnSelectAllChildNodes((SecurityTreeNode)e.Node);
            }
        }

        private void menuItemSelectAllNodes_Click(object sender, EventArgs e)
        {
            if (treeMenu.SelectedNode != null)
            {
                var node = treeMenu.SelectedNode;
                SelectAllChildNodes((SecurityTreeNode)node);
            }
        }

        private void SelectAllChildNodes(SecurityTreeNode _node)
        {
            foreach (SecurityTreeNode node in _node.Nodes)
            {
                SelectAllChildNodes(node);
                node.Checked = true;
            }
        }

        private void UnSelectAllChildNodes(SecurityTreeNode _node)
        {
            foreach (SecurityTreeNode node in _node.Nodes)
            {
                UnSelectAllChildNodes(node);
                node.Checked = false;
            }
        }

        private void frmGroupRights_DataMove(object sender, MoveCommandEnum _moveCommand)
        {
            Group group = null;
            switch (_moveCommand)
            {
                case MoveCommandEnum.MoveFirst:
                    group = Group.GetGroup(BackOfficeBL.General.MoveCommandEnum.MoveFirst, CrGroup);
                    break;
                case MoveCommandEnum.MovePrev:
                    group = Group.GetGroup(BackOfficeBL.General.MoveCommandEnum.MovePrev, CrGroup);
                    break;
                case MoveCommandEnum.MoveNext:
                    group = Group.GetGroup(BackOfficeBL.General.MoveCommandEnum.MoveNext, CrGroup);
                    break;
                case MoveCommandEnum.MoveLast:
                    group = Group.GetGroup(BackOfficeBL.General.MoveCommandEnum.MoveLast, CrGroup);
                    break;
            }
            if (group != null)
            {
                CrGroup = group;
                ShowGUI();
            }
        }

        private void ShowGUI()
        {
            if (CrGroup != null)
            {
                txtGroupID.Text = CrGroup.GroupID;
                txtGroupName.Text = CrGroup.Name;

                CrGroup.LoadGroupRights();
            }
        }

        private void ApplayGroupRightToNode(SecurityTreeNode _node)
        { 
        
        }
    }
}
