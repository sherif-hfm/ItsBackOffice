using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BackOfficeUI.Accounting
{
    public partial class frmReconcile : BackOfficeUI.Controls.frmBaseDB
    {
        private BackOfficeBL.Accounting.Reconcile CrReconcile;

        public frmReconcile(string AccountId)
        {
            InitializeComponent();
        }

        private void frmReconcile_Find(object sender, Dictionary<string, object> _findFields)
        {
            var accountId = _findFields["AccountID"];
        }

    }
}
