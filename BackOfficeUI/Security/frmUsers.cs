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
    public partial class frmUsers : frmBaseDB
    {
        private BackOfficeBL.Security.User CrUser;
        
        public frmUsers()
        {
            InitializeComponent();
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            LoadGroups();
        }

        private void frmUsers_DataMove(object sender, MoveCommandEnum _moveCommand)
        {
            BackOfficeBL.Security.User user = null;
            switch (_moveCommand)
            { 
                case MoveCommandEnum.MoveFirst:
                    user = BackOfficeBL.Security.User.GetFirst();
                    break;
                case MoveCommandEnum.MoveLast:
                    user = BackOfficeBL.Security.User.GetLast();
                    break;
                case MoveCommandEnum.MoveNext:
                    user = BackOfficeBL.Security.User.GetNext(CrUser);
                    break;
                case MoveCommandEnum.MovePrev:
                    user = BackOfficeBL.Security.User.GetPrev(CrUser);
                    break;
            }
            if (user != null)
            {
                CrUser = user;
                ShowGUI();
            }
        }

        private void LoadGroups()
        {
            lstGroups.DataSource = Group.GetAllGroups();
            lstGroups.DisplayMember = "Name";
            lstGroups.ValueMember = "GroupID";
            lstGroups.SelectedItems.Clear();
        }

        private void ShowGUI()
        {
            if (CrUser != null)
            {
                txtUserCode.Text = CrUser.UserID.ToString();
                txtUserLogin.Text = CrUser.UserLogin;
                txtUserPassword.Text = CrUser.Password;
                txtUserName_Ara.Text = CrUser.Name_Ara;
                txtUserName_Eng.Text = CrUser.Name_Eng;
                chkIsAdmin.Checked = CrUser.IsAdmin;
                lstGroups.SelectedItems.Clear();
                for(int index=0 ;index < lstGroups.Items.Count  ; index++)
                {
                    Group group = (Group)lstGroups.Items[index];
                    var userGroup = CrUser.Groups.Find(g => g.GroupID == group.GroupID);
                    if (userGroup != null)
                        lstGroups.SetSelected(index, true);
                }
            }
        }

        private void GetDataFromGUI()
        {
            CrUser.UserLogin = txtUserLogin.Text;
            CrUser.Password = txtUserPassword.Text;
            CrUser.Name_Ara = txtUserName_Ara.Text;
            CrUser.Name_Eng = txtUserName_Eng.Text;
            CrUser.IsAdmin = chkIsAdmin.Checked;
            CrUser.Groups.Clear();
            CrUser.Groups.AddRange(lstGroups.SelectedItems.OfType<Group>());
        }

        private void frmUsers_Save(object sender, ref bool _status)
        {
            GetDataFromGUI();
            DataSaveResult saveResult = CrUser.Save();
            if (saveResult.SaveStatus == false)
                _status = false;
            else
                ShowGUI();
        }

        private void frmUsers_AddNew(object sender, ref bool _status)
        {
            CrUser = new BackOfficeBL.Security.User();
        }

        private void frmUsers_Delete(object sender, ref bool _status)
        {
            if (CrUser == null)
            {
                _status = false;
                return;
            }
            else
            {
                if (CrUser.IsNew == true)
                {
                    _status = false;
                    return;
                }
            }

            DataDeleteResult result = CrUser.Delete();
            _status = result.DeleteStatus;
            if (result.DeleteStatus == false)
                MessageBox.Show(result.ErrorMessage);
            else
                CrUser = null;
        }

        private void btnSelectNone_Click(object sender, EventArgs e)
        {
            lstGroups.SelectedItems.Clear();
        }

        private void frmUsers_Edit(object sender, ref bool _status)
        {
            if (CrUser == null)
                _status = false;
            else
                if (CrUser.IsNew == true)
                    _status = false;
        }

        private void frmUsers_Find(object sender, Dictionary<string, object> _findFields)
        {
            CrUser = User.FindByUserID((int)_findFields["UserID"]);
            ShowGUI();
        }
        
    }
}
