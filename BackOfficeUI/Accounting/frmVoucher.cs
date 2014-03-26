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
        public frmVoucher()
        {
            InitializeComponent();
        }

        #region Events

        private void frmVoucher_Load(object sender, EventArgs e)
        {
            LoadComboValidation1(VoucherType.GetAllValidations());
            LoadComboValidation2(VoucherType.GetAllValidations());
            LoadComboValidation3(VoucherType.GetAllValidations());
            LoadComboValidation4(VoucherType.GetAllValidations());
            LoadComboValidation5(VoucherType.GetAllValidations());
            LoadCombodtlValidation1(VoucherType.GetAllValidations());
            LoadCombodtlValidation2(VoucherType.GetAllValidations());
            LoadCombodtlValidation3(VoucherType.GetAllValidations());
            LoadCombodtlValidation4(VoucherType.GetAllValidations());
            LoadCombodtlValidation5(VoucherType.GetAllValidations());

            LoadCreditComboAccount(Account.GetAllAccountTree());
            LoadDepitComboAccount(Account.GetAllAccountTree());
            LoadComboCurrency(VoucherType.GetAllCurrency());
            VouchersList = VoucherType.GetAllVouchers();
            LoadDataGrid(VouchersList);



        }

        private void dgrdVouchers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgrdVouchers.SelectedRows.Count != 0)
            {

                VOUCHERTYPEID = dgrdVouchers.SelectedRows[0].Cells[0].Value.ToString();
                VoucherType SelectedVoucherType = VouchersList.Find(a => a.VoucherTypeId == VOUCHERTYPEID);
                ShowGUI(SelectedVoucherType);

                CrVoucher = SelectedVoucherType;
            }

        }

        private void frmVoucher_AddNew(object sender, ref bool _status)
        {
            txtVoucherCode.Text = GetNewID();
            GridSelectedRow = dgrdVouchers.SelectedRows[0].Index;
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
            VoucherType VoucherType = new VoucherType();
            if (CrVoucher == null)
            {
                _status = false;
                return;
            }
            DataDeleteResult result = VoucherType.Delete(VOUCHERTYPEID);
            _status = result.DeleteStatus;
            if (result.DeleteStatus == false)
            {
                MessageBox.Show(result.ErrorMessage);
            }
            else
            {
                CrVoucher = null;
                VouchersList = VoucherType.GetAllVouchers();
                LoadDataGrid(VouchersList);
            }
        }

        private void frmVoucher_Save(object sender, ref bool _status)
        {
            VoucherType vu = new VoucherType();
            GetDataFromGUI();
            DataSaveResult saveResult = vu.Save(CrVoucher);
            if (saveResult.SaveStatus == false)
            {
                _status = false;

            }
            else
            {
                VouchersList = VoucherType.GetAllVouchers();
                LoadDataGrid(VouchersList);
            }


        }

        private void frmVoucher_DataRefresh(object sender)
        {
            int CurrentRow = dgrdVouchers.SelectedRows[0].Index;
            VouchersList = VoucherType.GetAllVouchers();
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

        private void LoadComboValidation1(List<VoucherType> _VoucherValidation)
        {
            if (_VoucherValidation.Count != 0)
            {
                cbxValidation1.DataSource = _VoucherValidation;
                cbxValidation1.ValueMember = "VaidationID";
                cbxValidation1.DisplayMember = "ValidationName";
                cbxValidation1.SelectedIndex = 0;

            }

        }
        private void LoadComboValidation2(List<VoucherType> _VoucherValidation)
        {
            if (_VoucherValidation.Count != 0)
            {
                cbxValidation2.DataSource = _VoucherValidation;
                cbxValidation2.ValueMember = "VaidationID";
                cbxValidation2.DisplayMember = "ValidationName";
                cbxValidation2.SelectedIndex = 0;

            }

        }
        private void LoadComboValidation3(List<VoucherType> _VoucherValidation)
        {
            if (_VoucherValidation.Count != 0)
            {
                cbxValidation3.DataSource = _VoucherValidation;
                cbxValidation3.ValueMember = "VaidationID";
                cbxValidation3.DisplayMember = "ValidationName";
                cbxValidation3.SelectedIndex = 0;

            }
        }
        private void LoadComboValidation4(List<VoucherType> _VoucherValidation)
        {
            if (_VoucherValidation.Count != 0)
            {
                cbxValidation4.DataSource = _VoucherValidation;
                cbxValidation4.ValueMember = "VaidationID";
                cbxValidation4.DisplayMember = "ValidationName";
                cbxValidation4.SelectedIndex = 0;

            }
        }
        private void LoadComboValidation5(List<VoucherType> _VoucherValidation)
        {
            if (_VoucherValidation.Count != 0)
            {
                cbxValidation5.DataSource = _VoucherValidation;
                cbxValidation5.ValueMember = "VaidationID";
                cbxValidation5.DisplayMember = "ValidationName";
                cbxValidation5.SelectedIndex = 0;

            }
        }


        private void LoadCombodtlValidation1(List<VoucherType> _VoucherValidation)
        {
            if (_VoucherValidation.Count != 0)
            {
                cbxDtlValidation1.DataSource = _VoucherValidation;
                cbxDtlValidation1.ValueMember = "VaidationID";
                cbxDtlValidation1.DisplayMember = "ValidationName";
                cbxDtlValidation1.SelectedIndex = 0;

            }
        }
        private void LoadCombodtlValidation2(List<VoucherType> _VoucherValidation)
        {
            if (_VoucherValidation.Count != 0)
            {
                cbxDtlValidation2.DataSource = _VoucherValidation;
                cbxDtlValidation2.ValueMember = "VaidationID";
                cbxDtlValidation2.DisplayMember = "ValidationName";
                cbxDtlValidation2.SelectedIndex = 0;

            }
        }
        private void LoadCombodtlValidation3(List<VoucherType> _VoucherValidation)
        {
            if (_VoucherValidation.Count != 0)
            {
                cbxDtlValidation3.DataSource = _VoucherValidation;
                cbxDtlValidation3.ValueMember = "VaidationID";
                cbxDtlValidation3.DisplayMember = "ValidationName";
                cbxDtlValidation3.SelectedIndex = 0;

            }
        }
        private void LoadCombodtlValidation4(List<VoucherType> _VoucherValidation)
        {
            if (_VoucherValidation.Count != 0)
            {
                cbxDtlValidation4.DataSource = _VoucherValidation;
                cbxDtlValidation4.ValueMember = "VaidationID";
                cbxDtlValidation4.DisplayMember = "ValidationName";
                cbxDtlValidation4.SelectedIndex = 0;

            }
        }
        private void LoadCombodtlValidation5(List<VoucherType> _VoucherValidation)
        {
            if (_VoucherValidation.Count != 0)
            {
                cbxDtlValidation5.DataSource = _VoucherValidation;
                cbxDtlValidation5.ValueMember = "VaidationID";
                cbxDtlValidation5.DisplayMember = "ValidationName";
                cbxDtlValidation5.SelectedIndex = 0;

            }
        }

        private void LoadCreditComboAccount(List<Account> _AccountList)
        {
            if (_AccountList.Count != 0)
            {
                cbxCreditAccounts.ValueMember = "AccountID";
                cbxCreditAccounts.DisplayMember = "NameAndNo";
                cbxCreditAccounts.DataSource = _AccountList;
            }
        }
        private void LoadDepitComboAccount(List<Account> _AccountList)
        {
            if (_AccountList.Count != 0)
            {
                cbxDepitAccounts.ValueMember = "AccountID";
                cbxDepitAccounts.DisplayMember = "NameAndNo";
                cbxDepitAccounts.DataSource = _AccountList;
            }
        }

        private void LoadComboCurrency(List<VoucherType> _CurrencyList)
        {
            if (_CurrencyList.Count != 0)
            {
                cbxCurrency.DisplayMember = "CurrencyName";
                cbxCurrency.ValueMember = "CurrencyID";
                cbxCurrency.DataSource = _CurrencyList;

            }
        }

        private void ShowGUI(VoucherType _vouchertype)
        {


            if (_vouchertype.VoucherTypeCurrencyID != 0)
            {
                cbxCurrency.SelectedValue = _vouchertype.VoucherTypeCurrencyID;
            }
            if (!string.IsNullOrEmpty(_vouchertype.CriedtAccountID))
            {
                cbxCreditAccounts.SelectedValue = _vouchertype.CriedtAccountID;
            }
            if (!string.IsNullOrEmpty(_vouchertype.DepitAccountId))
            {
                cbxDepitAccounts.SelectedValue = _vouchertype.DepitAccountId;
            }


            txtVoucherCode.Text = _vouchertype.VoucherTypeId;
            txtArabicName.Text = _vouchertype.VoucherArName;
            txtEnglishName.Text = _vouchertype.VoucherEnName;
            txtEliasAr.Text = _vouchertype.ShortName_Ara;
            txtEliasEn.Text = _vouchertype.ShortName_Eng;


            txtArDtlExtraField1.Text = _vouchertype.DetailExtraField1;
            txtArDtlExtraField2.Text = _vouchertype.DetailExtraField2;
            txtArDtlExtraField3.Text = _vouchertype.DetailExtraField3;
            txtArDtlExtraField4.Text = _vouchertype.DetailExtraField4;
            txtArDtlExtraField5.Text = _vouchertype.DetailExtraField5;

            txtEnExtraField1.Text = _vouchertype.MainExtraField1;
            txtEnExtraField2.Text = _vouchertype.MainExtraField2;
            txtEnExtraField3.Text = _vouchertype.MainExtraField3;
            txtEnExtraField4.Text = _vouchertype.MainExtraField4;
            txtEnExtraField5.Text = _vouchertype.MainExtraField5;

            if (_vouchertype.MainValidationField1 != null)
            {
                cbxValidation1.SelectedValue = _vouchertype.MainValidationField1;
            }
            if (_vouchertype.MainValidationField2 != null)
            {
                cbxValidation2.SelectedValue = _vouchertype.MainValidationField2;
            }
            if (_vouchertype.mainValidationField3 != null)
            {
                cbxValidation3.SelectedValue = _vouchertype.mainValidationField3;
            }
            if (_vouchertype.MainValidationField4 != null)
            {
                cbxValidation4.SelectedValue = _vouchertype.MainValidationField4;
            }
            if (_vouchertype.MainValidationField5 != null)
            {
                cbxValidation5.SelectedValue = _vouchertype.MainValidationField5;
            }

            if (_vouchertype.DtlValidationField1 != null)
            {
                cbxDtlValidation1.SelectedValue = _vouchertype.DtlValidationField1;
            }
            if (_vouchertype.DtlValidationField2 != null)
            {
                cbxDtlValidation2.SelectedValue = _vouchertype.DtlValidationField2;
            }
            if (_vouchertype.DtlValidationField3 != null)
            {
                cbxDtlValidation3.SelectedValue = _vouchertype.DtlValidationField3;
            }
            if (_vouchertype.DtlValidationField4 != null)
            {
                cbxDtlValidation4.SelectedValue = _vouchertype.DtlValidationField4;
            }
            if (_vouchertype.DtlValidationField5 != null)
            {
                cbxDtlValidation5.SelectedValue = _vouchertype.DtlValidationField5;
            }
        }

        private string GetNewID()
        {

            int x = CrVoucher.GetMaxId();
            x++;
            return x.ToString("000");
        }

        private void GetDataFromGUI()
        {
            CrVoucher = new VoucherType();
            if (cbxCurrency.SelectedIndex != -1)
            {
                CrVoucher.VoucherTypeCurrencyID = Convert.ToInt32(cbxCurrency.SelectedValue);
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
            CrVoucher.VoucherArName = txtArabicName.Text;
            CrVoucher.VoucherEnName = txtEnglishName.Text;
            CrVoucher.ShortName_Ara = txtEliasAr.Text;
            CrVoucher.ShortName_Eng = txtEliasEn.Text;

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
