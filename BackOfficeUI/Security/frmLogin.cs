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
    public partial class frmLogin : frmBase
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User user = User.CheckUser(txtUserLogin.Text,txtPassword.Text);
            if (user != null)
            {
                AppInfo.CurrentUser = user;
                this.Hide();
               frmFinancialYear frm = new frmFinancialYear();
                frm.Show();
            }
            else
                MessageBox.Show("Login Error");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
