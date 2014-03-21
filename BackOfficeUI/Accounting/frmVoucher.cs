using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BackOfficeUI.Controls;
using BackOfficeBL;
using BackOfficeBL.Accounting;

namespace BackOfficeUI.Accounting
{
    public partial class frmVoucher : frmBaseDB
    {
        private BackOfficeBL.Accounting.Voucher CrVoucher;
        public frmVoucher()
        {
            InitializeComponent();
        }

        private void frmVoucher_Load(object sender, EventArgs e)
        {
            List<VoucherType> vot = Voucher.GetAllVouchers();
            LoadDataGrid(vot);
            List<VoucherValidation> VotVal = Voucher.GetAllValidations();
            LoadComboValidation(VotVal);
        }

        private void LoadDataGrid(List<VoucherType> _VoucherTypeList)
        {
            if (_VoucherTypeList.Count != 0)
            {
                dgrdVouchers.AutoGenerateColumns = false;
                dgrdVouchers.DataSource = _VoucherTypeList;
                clmArVoucherName.DataPropertyName = "VoucherArName";
                clmEnglishName.DataPropertyName = "VoucherEnName";
                clmVoucherCode.DataPropertyName = "VoucherTypeId";
                clmEnEliasName.DataPropertyName = "ShortName_Eng";
                clmEliasAr.DataPropertyName = "ShortName_Ara";

            }
        }

        private void LoadComboValidation(List<VoucherValidation> _VotVal)
        {
            if (_VotVal.Count != 0)
            {
                cbxValidation1.DataSource = _VotVal;
                cbxValidation1.ValueMember = "VaidationID";
                cbxValidation1.DisplayMember = "ValidationName";
                cbxValidation1.SelectedIndex = -1;

                cbxValidation2.DataSource = _VotVal;
                cbxValidation2.ValueMember = "VaidationID";
                cbxValidation2.DisplayMember = "ValidationName";
                cbxValidation2.SelectedIndex = -1;

                cbxValidation3.DataSource = _VotVal;
                cbxValidation3.ValueMember = "VaidationID";
                cbxValidation3.DisplayMember = "ValidationName";
                cbxValidation3.SelectedIndex = -1;

                cbxValidation4.DataSource = _VotVal;
                cbxValidation4.ValueMember = "VaidationID";
                cbxValidation4.DisplayMember = "ValidationName";
                cbxValidation4.SelectedIndex = -1;

                cbxValidation5.DataSource = _VotVal;
                cbxValidation5.ValueMember = "VaidationID";
                cbxValidation5.DisplayMember = "ValidationName";
                cbxValidation5.SelectedIndex = -1;
            }

        }

        private void LoadComboAccounts()
        {
            cbxCreditAccounts.ValueMember = "AccountID";
            cbxCreditAccounts.DisplayMember = "";
            cbxCreditAccounts.DataSource = Account.GetAllAccountTree();
        }

    }
}
