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
        List<VoucherType> VouchersList;
        private VoucherType CrVoucher;
        private string VOUCHERTYPEID = null;
        int GridSelectedRow;
        //private bool IsEdit = false;
        //private bool IsAdd = false;

        public frmVoucher()
        {
            InitializeComponent();
        }

        #region Events

        private void frmVoucher_Load(object sender, EventArgs e)
        {
            LoadComboValidation(Voucher.GetAllValidations());
            LoadCreditComboAccount(Account.GetAllAccountTree());
            LoadDepitComboAccount(Account.GetAllAccountTree());
            LoadComboCurrency(Voucher.GetAllCurrency());
            VouchersList = Voucher.GetAllVouchers();
            LoadDataGrid(VouchersList);



        }

        private void dgrdVouchers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgrdVouchers.SelectedRows.Count != 0)
            {

                VOUCHERTYPEID = dgrdVouchers.SelectedRows[0].Cells[0].Value.ToString();
                VoucherType v = VouchersList.Find(a => a.VoucherTypeId == VOUCHERTYPEID);
                ShowGUI(v);
                //GetDataFromGUI();
                CrVoucher = v;
            }

        }

        private void frmVoucher_AddNew(object sender, ref bool _status)
        {
            GridSelectedRow = dgrdVouchers.SelectedRows[0].Index;
            //VOUCHERTYPEID = null;
            CrVoucher = new VoucherType();

        }

        private void frmVoucher_Cancel(object sender)
        {
            dgrdVouchers.Rows[GridSelectedRow].Selected = true;
            dgrdVouchers_SelectionChanged(dgrdVouchers, new EventArgs());
            VOUCHERTYPEID = CrVoucher.VoucherTypeId;
            ShowGUI(CrVoucher);

        }

        private void frmVoucher_Edit(object sender, ref bool _status)
        {
            GridSelectedRow = dgrdVouchers.SelectedRows[0].Index;


        }

        private void frmVoucher_Delete(object sender, ref bool _status)
        {
            Voucher vu = new Voucher();
            if (CrVoucher == null)
            {
                _status = false;
                return;
            }
            DataDeleteResult result = vu.Delete(VOUCHERTYPEID);
            _status = result.DeleteStatus;
            if (result.DeleteStatus == false)
            {
                MessageBox.Show(result.ErrorMessage);
            }
            else
            {
                CrVoucher = null;
                VouchersList = Voucher.GetAllVouchers();
                LoadDataGrid(VouchersList);
            }
        }

        private void frmVoucher_Save(object sender, ref bool _status)
        {
            Voucher vu = new Voucher();
            GetDataFromGUI();
            DataSaveResult saveResult = vu.Save(CrVoucher);
            if (saveResult.SaveStatus == false)
            {
                _status = false;

            }
            else
            {
                VouchersList = Voucher.GetAllVouchers();
                LoadDataGrid(VouchersList);
            }


        }

        private void frmVoucher_DataRefresh(object sender)
        {
            int CurrentRow = dgrdVouchers.SelectedRows[0].Index;
            VouchersList = Voucher.GetAllVouchers();
            LoadDataGrid(VouchersList);
            dgrdVouchers.Rows[CurrentRow].Selected = true;

        }

        private void frmVoucher_DataMove(object sender, MoveCommandEnum _moveCommand)
        {
            int CurrentRow;
            switch (_moveCommand)
            {

                case MoveCommandEnum.MoveFirst:
                    dgrdVouchers.Rows[dgrdVouchers.SelectedRows[0].Index].Selected = false;
                    dgrdVouchers.Rows[0].Selected = true;
                    break;
                case MoveCommandEnum.MoveLast:
                    dgrdVouchers.Rows[dgrdVouchers.SelectedRows[0].Index].Selected = false;
                    dgrdVouchers.Rows[VouchersList.Count - 1].Selected = true;
                    break;
                case MoveCommandEnum.MoveNext:
                    CurrentRow = dgrdVouchers.SelectedRows[0].Index;
                    if (CurrentRow != VouchersList.Count - 1)
                    {
                        dgrdVouchers.Rows[dgrdVouchers.SelectedRows[0].Index].Selected = false;
                        dgrdVouchers.Rows[CurrentRow + 1].Selected = true;
                    }
                    break;
                case MoveCommandEnum.MovePrev:
                    CurrentRow = dgrdVouchers.SelectedRows[0].Index;
                    if (CurrentRow != 0)
                    {
                        dgrdVouchers.Rows[dgrdVouchers.SelectedRows[0].Index].Selected = false;
                        dgrdVouchers.Rows[CurrentRow - 1].Selected = true;
                    }
                    break;
            }
        }

        #endregion

        #region Methods

        private void LoadDataGrid(List<VoucherType> _VoucherTypeList)
        {
            if (_VoucherTypeList.Count != 0)
            {
                dgrdVouchers.AutoGenerateColumns = false;
                dgrdVouchers.DataSource = null;

                clmArVoucherName.DataPropertyName = "VoucherArName";
                clmEnglishName.DataPropertyName = "VoucherEnName";
                clmVoucherCode.DataPropertyName = "VoucherTypeId";
                clmEnEliasName.DataPropertyName = "ShortName_Eng";
                clmEliasAr.DataPropertyName = "ShortName_Ara";
                dgrdVouchers.DataSource = _VoucherTypeList;

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

                cbxDtlValidation1.DataSource = _VotVal;
                cbxDtlValidation1.ValueMember = "VaidationID";
                cbxDtlValidation1.DisplayMember = "ValidationName";
                cbxDtlValidation1.SelectedIndex = -1;

                cbxDtlValidation2.DataSource = _VotVal;
                cbxDtlValidation2.ValueMember = "VaidationID";
                cbxDtlValidation2.DisplayMember = "ValidationName";
                cbxDtlValidation2.SelectedIndex = -1;

                cbxDtlValidation3.DataSource = _VotVal;
                cbxDtlValidation3.ValueMember = "VaidationID";
                cbxDtlValidation3.DisplayMember = "ValidationName";
                cbxDtlValidation3.SelectedIndex = -1;

                cbxDtlValidation4.DataSource = _VotVal;
                cbxDtlValidation4.ValueMember = "VaidationID";
                cbxDtlValidation4.DisplayMember = "ValidationName";
                cbxDtlValidation4.SelectedIndex = -1;

                cbxDtlValidation5.DataSource = _VotVal;
                cbxDtlValidation5.ValueMember = "VaidationID";
                cbxDtlValidation5.DisplayMember = "ValidationName";
                cbxDtlValidation5.SelectedIndex = -1;
            }

        }

        private void LoadCreditComboAccount(List<Account> AccountList)
        {
            if (AccountList.Count != 0)
            {
                cbxCreditAccounts.ValueMember = "AccountID";
                cbxCreditAccounts.DisplayMember = "NameAndNo";
                cbxCreditAccounts.DataSource = AccountList;
            }
        }

        private void LoadDepitComboAccount(List<Account> AccountList)
        {
            if (AccountList.Count != 0)
            {
                cbxDepitAccounts.ValueMember = "AccountID";
                cbxDepitAccounts.DisplayMember = "NameAndNo";
                cbxDepitAccounts.DataSource = AccountList;
            }
        }

        private void LoadComboCurrency(List<Currency> _CurrencyList)
        {
            if (_CurrencyList.Count != 0)
            {
                cbxArCurrency.DisplayMember = "CurrencyArName";
                cbxArCurrency.ValueMember = "CurrencyID";
                cbxArCurrency.DataSource = _CurrencyList;

                cbxEnCurrency.DisplayMember = "CurrencyEnName";
                cbxEnCurrency.ValueMember = "CurrencyID";
                cbxEnCurrency.DataSource = _CurrencyList;
            }
        }

        private void ShowGUI(VoucherType vouchertype)
        {
            if (vouchertype.CurrencyID != 0)
            {
                cbxEnCurrency.SelectedValue = vouchertype.CurrencyID;
                cbxArCurrency.SelectedValue = vouchertype.CurrencyID;
            }
            if (!string.IsNullOrEmpty(vouchertype.CriedtAccountID))
            {
                cbxCreditAccounts.SelectedValue = vouchertype.CriedtAccountID;
            }
            if (!string.IsNullOrEmpty(vouchertype.DepitAccountId))
            {
                cbxDepitAccounts.SelectedValue = vouchertype.DepitAccountId;
            }

            txtVoucherCode.Text = vouchertype.VoucherTypeId;
            txtArabicName.Text = vouchertype.VoucherArName;
            txtEnglishName.Text = vouchertype.VoucherEnName;

            txtArDtlExtraField1.Text = vouchertype.DetailExtraField1;
            txtArDtlExtraField2.Text = vouchertype.DetailExtraField2;
            txtArDtlExtraField3.Text = vouchertype.DetailExtraField3;
            txtArDtlExtraField4.Text = vouchertype.DetailExtraField4;
            txtArDtlExtraField5.Text = vouchertype.DetailExtraField5;

            txtEnExtraField1.Text = vouchertype.MainExtraField1;
            txtEnExtraField2.Text = vouchertype.MainExtraField2;
            txtEnExtraField3.Text = vouchertype.MainExtraField3;
            txtEnExtraField4.Text = vouchertype.MainExtraField4;
            txtEnExtraField5.Text = vouchertype.MainExtraField5;

            if (vouchertype.MainValidationField1 != null)
            {
                cbxValidation1.SelectedValue = vouchertype.MainValidationField1;
            }
            if (vouchertype.MainValidationField2 != null)
            {
                cbxValidation2.SelectedValue = vouchertype.MainValidationField2;
            }
            if (vouchertype.mainValidationField3 != null)
            {
                cbxValidation3.SelectedValue = vouchertype.mainValidationField3;
            }
            if (vouchertype.MainValidationField4 != null)
            {
                cbxValidation4.SelectedValue = vouchertype.MainValidationField4;
            }
            if (vouchertype.MainValidationField5 != null)
            {
                cbxValidation5.SelectedValue = vouchertype.MainValidationField5;
            }

            if (vouchertype.DtlValidationField1 != null)
            {
                cbxDtlValidation1.SelectedValue = vouchertype.DtlValidationField1;
            }
            if (vouchertype.DtlValidationField2 != null)
            {
                cbxDtlValidation2.SelectedValue = vouchertype.DtlValidationField2;
            }
            if (vouchertype.DtlValidationField3 != null)
            {
                cbxDtlValidation3.SelectedValue = vouchertype.DtlValidationField3;
            }
            if (vouchertype.DtlValidationField4 != null)
            {
                cbxDtlValidation4.SelectedValue = vouchertype.DtlValidationField4;
            }
            if (vouchertype.DtlValidationField5 != null)
            {
                cbxDtlValidation5.SelectedValue = vouchertype.DtlValidationField5;
            }
        }

        private void GetDataFromGUI()
        {
            CrVoucher = new VoucherType();
            if (cbxEnCurrency.SelectedIndex != -1)
            {
                CrVoucher.CurrencyID = Convert.ToInt32(cbxEnCurrency.SelectedValue);
            }
            if (!string.IsNullOrEmpty(txtVoucherCode.Text))
            {
                CrVoucher.VoucherTypeId = txtVoucherCode.Text;
            }
            if (cbxCreditAccounts.SelectedIndex != -1)
            {
                CrVoucher.CriedtAccountID = cbxCreditAccounts.SelectedValue.ToString();
            }
            if (cbxDepitAccounts.SelectedIndex != -1)
            {
                CrVoucher.DepitAccountId = cbxDepitAccounts.SelectedValue.ToString();
            }
            //CrVoucher.VoucherTypeId = txtVoucherCode.Text;
            CrVoucher.VoucherArName = txtArabicName.Text;
            CrVoucher.VoucherEnName = txtEnglishName.Text;

            CrVoucher.DetailExtraField1 = txtArDtlExtraField1.Text;
            CrVoucher.DetailExtraField2 = txtArDtlExtraField2.Text;
            CrVoucher.DetailExtraField3 = txtArDtlExtraField3.Text;
            CrVoucher.DetailExtraField4 = txtArDtlExtraField4.Text;
            CrVoucher.DetailExtraField5 = txtArDtlExtraField5.Text;

            CrVoucher.MainExtraField1 = txtEnExtraField1.Text;
            CrVoucher.MainExtraField2 = txtEnExtraField2.Text;
            CrVoucher.MainExtraField3 = txtEnExtraField3.Text;
            CrVoucher.MainExtraField4 = txtEnExtraField4.Text;
            CrVoucher.MainExtraField5 = txtEnExtraField5.Text;

            if (cbxValidation1.SelectedIndex != -1)
            {
                CrVoucher.MainValidationField1 = Convert.ToInt32(cbxValidation1.SelectedValue);
            }
            if (cbxValidation2.SelectedIndex != -1)
            {
                CrVoucher.MainValidationField2 = Convert.ToInt32(cbxValidation2.SelectedValue);
            }
            if (cbxValidation3.SelectedIndex != -1)
            {
                CrVoucher.mainValidationField3 = Convert.ToInt32(cbxValidation3.SelectedValue);
            }
            if (cbxValidation4.SelectedIndex != -1)
            {
                CrVoucher.MainValidationField4 = Convert.ToInt32(cbxValidation4.SelectedValue);
            }
            if (cbxValidation5.SelectedIndex != -1)
            {
                CrVoucher.MainValidationField5 = Convert.ToInt32(cbxValidation5.SelectedValue);
            }

            if (cbxDtlValidation1.SelectedIndex != -1)
            {
                CrVoucher.DtlValidationField1 = Convert.ToInt32(cbxDtlValidation1.SelectedValue);
            }
            if (cbxDtlValidation2.SelectedIndex != -1)
            {
                CrVoucher.DtlValidationField2 = Convert.ToInt32(cbxDtlValidation2.SelectedValue);
            }
            if (cbxDtlValidation3.SelectedIndex != -1)
            {
                CrVoucher.DtlValidationField3 = Convert.ToInt32(cbxDtlValidation3.SelectedValue);
            }
            if (cbxDtlValidation4.SelectedIndex != -1)
            {
                CrVoucher.DtlValidationField4 = Convert.ToInt32(cbxDtlValidation4.SelectedValue);
            }
            if (cbxDtlValidation5.SelectedIndex != -1)
            {
                CrVoucher.DtlValidationField5 = Convert.ToInt32(cbxDtlValidation5.SelectedValue);
            }
        }

        #endregion





    }
}
