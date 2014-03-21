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
        private VoucherType CrVoucher;

        public frmVoucher()
        {
            InitializeComponent();
        }
        #region Events
        private void frmVoucher_Load(object sender, EventArgs e)
        {
            List<VoucherType> VouchersList = Voucher.GetAllVouchers();
            LoadDataGrid(VouchersList);
            List<VoucherValidation> VotVal = Voucher.GetAllValidations();
            LoadComboValidation(VotVal);
            List<Account> AccountList = Account.GetAllAccountTree();
            LoadCreditComboAccount(AccountList);
            LoadDepitComboAccount(AccountList);
        }

        private void dgrdVouchers_SelectionChanged(object sender, EventArgs e)
        {

        }


        private void frmVoucher_AddNew(object sender, ref bool _status)
        {
            CrVoucher = new VoucherType();
        }

        private void frmVoucher_Cancel(object sender)
        {

        }

        private void frmVoucher_Edit(object sender, ref bool _status)
        {

        }

        private void frmVoucher_Delete(object sender, ref bool _status)
        {
            //if (CrVoucher == null)
            //{
            //    _status = false;
            //    return;
            //}
            //else
            //{
            //    if (CrVoucher.IsNew == true)
            //    {
            //        _status = false;
            //        return;
            //    }
            //}

            //DataDeleteResult result = CrVoucher.Delete();
            //_status = result.DeleteStatus;
            //if (result.DeleteStatus == false)
            //    MessageBox.Show(result.ErrorMessage);
            //else
            //    CrVoucher = null;
        }

        private void frmVoucher_Save(object sender, ref bool _status)
        {
            //GetDataFromGUI();
            //DataSaveResult saveResult = CrAccount.Save();
            //if (saveResult.SaveStatus == false)
            //    _status = false;
            //else
            //    ShowGUI();
        }
        #endregion
        #region Methods
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

        private void LoadCreditComboAccount(List<Account> AccountList)
        {
            if (AccountList.Count != 0)
            {
                cbxCreditAccounts.ValueMember = "AccountID";
                cbxCreditAccounts.DisplayMember = "NameAndNos";
                cbxCreditAccounts.DataSource = AccountList;
            }
        }

        private void LoadDepitComboAccount(List<Account> AccountList)
        {
            if (AccountList.Count != 0)
            {
                cbxCreditAccounts.ValueMember = "AccountID";
                cbxCreditAccounts.DisplayMember = "NameAndNos";
                cbxCreditAccounts.DataSource = AccountList;
            }
        }

        private void CollectScreenValues()
        {
            CrVoucher.CurrencyID = Convert.ToInt32(cbxEnCurrency.SelectedValue);
            CrVoucher.CriedtAccountID = cbxCreditAccounts.SelectedValue.ToString();
            CrVoucher.DepitAccountId = cbxDepitAccounts.SelectedValue.ToString();

        }

        #endregion




    }
}
