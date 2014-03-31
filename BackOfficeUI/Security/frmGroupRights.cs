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
        private bool AllowRightsUpdates = false;

        public frmGroupRights()
        {
            InitializeComponent();
        }

        private void frmGroupRights_Load(object sender, EventArgs e)
        {
            LoadAllForms();
            LoadFormFunctions();
            treeMenu.ContextMenuStrip = this.menu;
        }

        private void LoadFormFunctions()
        {
             lstRights.DataSource= FormFunction.GetFormFunctions();
             lstRights.DisplayMember = "FunctionText";
             lstRights.ValueMember = "FunctionID";
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
                AddRemoveMenuItem((SecurityTreeNode)e.Node);
            }
            else
            {
                AddRemoveMenuItem((SecurityTreeNode)e.Node);
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
                ApplayGroupRightToNode(null);
            }
        }

        private void ApplayGroupRightToNode(List<SecurityTreeNode> _nodes)
        {
            List<SecurityTreeNode> nodes;
            if (_nodes == null)
                nodes = treeMenu.Nodes.OfType<SecurityTreeNode>().ToList();
            else
                nodes = _nodes;
            foreach (SecurityTreeNode node in nodes)
            { 
                var groupRight=CrGroup.GroupRights.Find(g=>g.MenuID==node.Name);
                if (groupRight != null)
                {
                    node.Checked = true;
                    node.GroupAllowedFunctions = groupRight.AllowedFunctions;
                    ApplayGroupRightToNode(node.Nodes.OfType<SecurityTreeNode>().ToList());
                }
                else
                {
                    node.Checked = false;
                    node.GroupAllowedFunctions = 0;
                }

            }
        }

        private void treeMenu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node != null)
                ShowMenuItemRights((SecurityTreeNode)e.Node);
        }

        private void ShowMenuItemRights(SecurityTreeNode _node)
        {
            AllowRightsUpdates = false;
            for (int rightItemIndex = 0; rightItemIndex < lstRights.Items.Count; rightItemIndex++)
            {
                var rightItem = (FormFunction)lstRights.Items[rightItemIndex];
                if ((rightItem.FunctionID & _node.MenuItem.FormAllowedFunctions & _node.GroupAllowedFunctions) > 0)
                    lstRights.SetItemChecked(rightItemIndex, true);
                else
                    lstRights.SetItemChecked(rightItemIndex, false);
            }
            AllowRightsUpdates = true;
        }

        private void frmGroupRights_DataRefresh(object sender)
        {
            if (CrGroup != null)
            {
                Group group = null;
                group = Group.GetGroup(BackOfficeBL.General.MoveCommandEnum.Refresh, CrGroup);
                if (group != null)
                {
                    CrGroup = group;
                    ShowGUI();
                }
            }
        }

        private void frmGroupRights_Cancel(object sender)
        {
            frmGroupRights_DataRefresh(this);
        }

        private void frmGroupRights_Edit(object sender, ref bool _status)
        {
            if (CrGroup == null)
            {
                _status = false;
                return;
            }
        }

        private void frmGroupRights_Save(object sender, ref bool _status)
        {
            if (CrGroup == null)
            {
                _status = false;
                return;
            }
            var saveResult= CrGroup.SaveGroupRights();
            if (saveResult.SaveStatus == false)
            {
                MessageBox.Show(saveResult.ErrorMessage, BackOfficeResources.Messages.MessageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                _status = false;
                return;
            }
        }

        private void UpdateMenuItemRights(SecurityTreeNode _node, FormFunction _formFunction,CheckState _checkStatus)
        {
            if (AllowRightsUpdates == true && _node != null && CrGroup != null)
            {
                if (_checkStatus == CheckState.Checked)
                {
                    if ((_node.MenuItem.FormAllowedFunctions & _formFunction.FunctionID) > 0)
                        _node.GroupAllowedFunctions += _formFunction.FunctionID;
                }
                else
                {
                    _node.GroupAllowedFunctions -= _formFunction.FunctionID;
                }
                var groupRight = CrGroup.GroupRights.Find(g => g.MenuID == _node.Name);
                if (groupRight != null)
                    groupRight.AllowedFunctions = _node.GroupAllowedFunctions;
            }
        }

        private void AddRemoveMenuItem(SecurityTreeNode _node)
        {
            GroupRight groupRight;
            if (_node != null && CrGroup != null)
            {
                if (_node.Checked == true)
                {
                    groupRight = CrGroup.GroupRights.Find(g => g.MenuID == _node.Name);
                    if (groupRight == null)
                    {
                        groupRight = new GroupRight() { GroupID = CrGroup.GroupID, MenuID = _node.Name, AllowedFunctions = 0 };
                        CrGroup.GroupRights.Add(groupRight);
                    }
                }
                else
                {
                    groupRight = CrGroup.GroupRights.Find(g => g.MenuID == _node.Name);
                    if (groupRight != null)
                    {
                        CrGroup.GroupRights.Remove(groupRight);
                    }
                }
            }
        }

        private void lstRights_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (treeMenu.SelectedNode != null)
            {
                FormFunction formFunction = (FormFunction)lstRights.Items[e.Index];
                UpdateMenuItemRights((SecurityTreeNode)treeMenu.SelectedNode, formFunction, e.NewValue);
            }
        }
    }
}
