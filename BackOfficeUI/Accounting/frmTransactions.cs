using BackOfficeBL.Accounting;
using BackOfficeUI.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BackOfficeUI.Accounting
{
    public partial class frmTransactions : frmBaseDB
    {
        
        public frmTransactions()
        {
            InitializeComponent();

            LoadLookups();

        }

        private void LoadLookups()
        {
            comboBoxVoucherType.Items.Clear();
            comboBoxVoucherType.DataSource = VoucherType.GetAllVouchers();
            comboBoxVoucherType.ValueMember = "VoucherTypeId";
            comboBoxVoucherType.DisplayMember = "VoucherName";
        }

        private void comboBoxVoucherType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
