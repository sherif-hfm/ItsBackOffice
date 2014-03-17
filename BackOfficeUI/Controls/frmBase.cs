using BackOfficeBL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BackOfficeUI.Controls
{
    public partial class frmBase : Form
    {
        public frmBase()
        {
            InitializeComponent();
        }

        private void frmBase_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var selectStatus = this.SelectNextControl(this.ActiveControl, true, true, true, false);
                if (selectStatus == false)
                    this.SelectNextControl(this.ActiveControl, true, true, true, true);
                e.SuppressKeyPress = true;
            } 
        }

        private void frmBase_KeyDown(object sender, KeyEventArgs e)
        {
            
        }


        #region ************************** Properties **************************

        public BackOfficeBL.Security.MenuItem FormMenuItem { get; set; }

        private string mFormOption = "";
        public string FormOption { get { return mFormOption; } set { mFormOption = value; } }

        private string mFormID = "";
        public string FormID { get { return mFormID; } set { mFormID = value; } }

        #endregion

        #region ************************** Methods **************************

        private void LoadFormProperties()
        {
            if (AppInfo.CurrentUser != null && DesignMode == false)
            {
                var CurrentUser = AppInfo.CurrentUser;
                var menuItem = CurrentUser.UserMenuItems.Find(m => m.MenuID == this.FormID);
                if (menuItem != null)
                {
                    this.FormMenuItem = menuItem;
                    this.FormID = menuItem.MenuID;
                    this.Text = menuItem.Text;
                    this.FormOption = menuItem.FormOption;
                }
                else
                    this.Hide();
            }
        }

        #endregion

        private void frmBase_Load(object sender, EventArgs e)
        {
            LoadFormProperties();
        }
    }
}
