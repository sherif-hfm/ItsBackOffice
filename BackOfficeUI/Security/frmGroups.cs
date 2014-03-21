using BackOfficeBL;
using BackOfficeBL.Security;
using BackOfficeUI.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BackOfficeUI.Security
{
    public partial class frmGroups : frmBaseDB
    {

        private Group CrGroup = null;

        public frmGroups()
        {
            InitializeComponent();
        }

        private void frmGroups_Load(object sender, EventArgs e)
        {
        }

        private void frmGroups_Save(object sender, ref bool _status)
        {
            GetDataFromGUI();
            DataSaveResult result = CrGroup.Save();

            if (result.SaveStatus == false)
            {
                _status = false;
                MessageBox.Show(result.ErrorMessage);
            }
            else
            {
                CrGroup = (Group)result.Data;
                ShowGUI();
            }
        }

        private void frmGroups_Find(object sender, Dictionary<string, object> _findFields)
        {
            string GroupID = (string)_findFields["GroupID"];
            Group.GetGroupByID(GroupID);
        }

        private void frmGroups_DataMove(object sender, MoveCommandEnum _moveCommand)
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

        private void frmGroups_Delete(object sender, ref bool _status)
        {
            if (CrGroup == null || CrGroup.IsNew ==true   )
            {
                _status = false;
                return;
            }
            DataDeleteResult result= CrGroup.Delete();
            if (result.DeleteStatus == false)
            {
                _status = false;
                MessageBox.Show(result.ErrorMessage);
            }
            else
                CrGroup = null;
        }

        private void frmGroups_Edit(object sender, ref bool _status)
        {
            if (CrGroup == null || CrGroup.IsNew == true)
            {
                _status = false;
                return;
            }
        }

        private void frmGroups_AddNew(object sender, ref bool _status)
        {
            CrGroup = new Group();
        }

        private void ShowGUI()
        {
            if (CrGroup != null)
            {
                txtGroupID.Text = CrGroup.GroupID;
                txtGroupName_Ara.Text = CrGroup.Name_Ara;
                txtGroupName_Eng.Text = CrGroup.Name_Eng;
                chkIsDisable.Checked = CrGroup.IsDisable;
                
                lstUsers.DataSource = null;
                lstUsers.DataSource = CrGroup.Users;
                lstUsers.DisplayMember = "Name";
                lstUsers.ValueMember = "UserID";

                lstAllUsers.DataSource = null;
                lstAllUsers.DataSource = CrGroup.GetOutGroupUsers();
                lstAllUsers.DisplayMember = "Name";
                lstAllUsers.ValueMember = "UserID";
            }
        }

        private void GetDataFromGUI()
        {
            if (CrGroup != null)
            {
                CrGroup.GroupID = txtGroupID.Text;
                CrGroup.Name_Ara = txtGroupName_Ara.Text;
                CrGroup.Name_Eng = txtGroupName_Eng.Text;
                CrGroup.IsDisable = chkIsDisable.Checked;
            }
        }

        private void frmGroups_Cancel(object sender)
        {
            ShowGUI();
        }

        private void btnAddUsers_Click(object sender, EventArgs e)
        {
            if (CrGroup != null)
            {
                var users = lstAllUsers.SelectedItems.OfType<User>().ToList();
                CrGroup.Users.AddRange(users);
                ShowGUI();
            }
        }

        private void btnRemoveUsers_Click(object sender, EventArgs e)
        {
            if (CrGroup != null)
            {
                var users = lstUsers.SelectedItems.OfType<User>().ToList();
                foreach(var user in users)
                {
                    CrGroup.Users.Remove(user);
                }
                ShowGUI();
            }
        }
    }
}
