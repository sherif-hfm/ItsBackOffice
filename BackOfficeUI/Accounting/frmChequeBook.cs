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
    public partial class frmChequeBook : frmBaseDB
    {
        int SelectedChequeID = -1;
        int SelectedRow = -1;
        List<ChequeBook> ChequeBookList;
        private ChequeBook _chequebook;
        public frmChequeBook()
        {
            InitializeComponent();
        }

        private void frmChequeBook_Load(object sender, EventArgs e)
        {
            ChequeBookList = ChequeBook.GetAllCheques();
            LoadDataGrid(ChequeBookList);
            LoadComboAccounts(ChequeBook.GetAllAccounts());
            LoadComboCurrency(VoucherType.GetAllCurrency());
        }
        private void LoadDataGrid(List<ChequeBook> _ChequeBookList)
        {
            if (_ChequeBookList.Count != 0)
            {
                dgrdChequeBook.AutoGenerateColumns = false;
                dgrdChequeBook.DataSource = null;

                clmChequeBookID.DataPropertyName = "ChequeBookID";
                clmCheuqeBookName_Ara.DataPropertyName = "CheuqeBookName_Ara";
                clmCheuqeBookName_Eng.DataPropertyName = "CheuqeBookName_Eng";
                clmChequeEndNo.DataPropertyName = "CHequeEndno";
                clmChequeStartNo.DataPropertyName = "ChequeStartNo";
                dgrdChequeBook.DataSource = _ChequeBookList;
            }
        }

        private void dgrdChequeBook_SelectionChanged(object sender, EventArgs e)
        {

            if (dgrdChequeBook.SelectedRows.Count != 0)
            {

                SelectedChequeID = Convert.ToInt32(dgrdChequeBook.SelectedRows[0].Cells[0].Value);
                _chequebook = ChequeBookList.Find(a => a.ChequeBookID == SelectedChequeID);
                if (_chequebook != null)
                {
                    ShowGUI(_chequebook);
                }
                //  financialyear = SelectedFinancialYear;
            }
        }

        private void frmChequeBook_AddNew(object sender, ref bool _status)
        {
            dgrdChequeBook.Enabled = false;
            SelectedRow = dgrdChequeBook.SelectedRows[0].Index;
            SelectedChequeID = -1;
        }

        private void frmChequeBook_Edit(object sender, ref bool _status)
        {
            SelectedChequeID = Convert.ToInt32(dgrdChequeBook.SelectedRows[0].Cells[0].Value);
            dgrdChequeBook.Enabled = false;
            SelectedRow = dgrdChequeBook.SelectedRows[0].Index;
        }

        private void frmChequeBook_Cancel(object sender)
        {
            dgrdChequeBook.Rows[SelectedRow].Selected = true;
            dgrdChequeBook_SelectionChanged(dgrdChequeBook, new EventArgs());
            dgrdChequeBook.Enabled = true;
        }

        private void frmChequeBook_DataMove(object sender, MoveCommandEnum _moveCommand)
        {
            switch (_moveCommand)
            {

                case MoveCommandEnum.MoveFirst:
                    dgrdChequeBook.Rows[dgrdChequeBook.SelectedRows[0].Index].Selected = false;
                    dgrdChequeBook.Rows[0].Selected = true;
                    break;
                case MoveCommandEnum.MoveLast:
                    dgrdChequeBook.Rows[dgrdChequeBook.SelectedRows[0].Index].Selected = false;
                    dgrdChequeBook.Rows[ChequeBookList.Count - 1].Selected = true;
                    break;
                case MoveCommandEnum.MoveNext:
                    SelectedRow = dgrdChequeBook.SelectedRows[0].Index;
                    if (SelectedRow != ChequeBookList.Count - 1)
                    {
                        dgrdChequeBook.Rows[dgrdChequeBook.SelectedRows[0].Index].Selected = false;
                        dgrdChequeBook.Rows[SelectedRow + 1].Selected = true;
                    }
                    break;
                case MoveCommandEnum.MovePrev:
                    SelectedRow = dgrdChequeBook.SelectedRows[0].Index;
                    if (SelectedRow != 0)
                    {
                        dgrdChequeBook.Rows[dgrdChequeBook.SelectedRows[0].Index].Selected = false;
                        dgrdChequeBook.Rows[SelectedRow - 1].Selected = true;
                    }
                    break;
            }
        }

        private void frmChequeBook_DataRefresh(object sender)
        {
            SelectedRow = dgrdChequeBook.SelectedRows[0].Index;
            ChequeBookList = ChequeBook.GetAllCheques();
            LoadDataGrid(ChequeBookList);
            dgrdChequeBook.Rows[SelectedRow].Selected = true;
        }

        private void frmChequeBook_Delete(object sender, ref bool _status)
        {
            _chequebook = new ChequeBook();
            if (SelectedChequeID == -1)
            {
                _status = false;
                return;
            }
            DataDeleteResult result = _chequebook.Delete(SelectedChequeID);
            _status = result.DeleteStatus;
            if (result.DeleteStatus == false)
            {
                MessageBox.Show(result.ErrorMessage);
            }
            else
            {

                ChequeBookList = ChequeBook.GetAllCheques();
                LoadDataGrid(ChequeBookList);
                dgrdChequeBook.Rows[0].Selected = true;
            }

        }

        private void frmChequeBook_Save(object sender, ref bool _status)
        {
            ChequeBook cheque = new ChequeBook();
            GetDataFromGUI();

            DataSaveResult saveResult = cheque.Save(_chequebook);
            if (saveResult.SaveStatus == false)
            {
                _status = false;

            }
            else
            {
                ChequeBookList = ChequeBook.GetAllCheques();
                LoadDataGrid(ChequeBookList);
            }
            dgrdChequeBook.Enabled = true;
            dgrdChequeBook.Rows[SelectedRow].Selected = true;
            dgrdChequeBook_SelectionChanged(dgrdChequeBook, new EventArgs());

        }



        private void ShowGUI(ChequeBook _ChequeBook)
        {
            if (!string.IsNullOrEmpty(_ChequeBook.CheuqeBookName_Ara))
            {
                txtArabicName.Text = _ChequeBook.CheuqeBookName_Ara;
            }
            if (!string.IsNullOrEmpty(_ChequeBook.CheuqeBookName_Eng))
            {
                txtEnglishName.Text = _ChequeBook.CheuqeBookName_Eng;
            }

            cbxCurrency.SelectedValue = _ChequeBook.ChequeCurrancyId;

            if (!string.IsNullOrEmpty(_ChequeBook.BankAccountId))
            {
                cbxBanckAccounts.SelectedValue = _ChequeBook.BankAccountId;
            }
            chkIsDisabled.Checked = _ChequeBook.IsDisable;
            numStart.Value = Convert.ToDecimal(_ChequeBook.ChequeStartNo);
            numEnd.Value = Convert.ToDecimal(_ChequeBook.CHequeEndno);
        }
        private void GetDataFromGUI()
        {
            _chequebook = new ChequeBook();
            _chequebook.ChequeBookID = SelectedChequeID;
            _chequebook.CheuqeBookName_Ara = txtArabicName.Text;
            _chequebook.CheuqeBookName_Eng = txtEnglishName.Text;
            _chequebook.ChequeCurrancyId = Convert.ToInt32(cbxCurrency.SelectedValue);
            _chequebook.IsDisable = chkIsDisabled.Checked;
            _chequebook.BankAccountId = cbxBanckAccounts.SelectedValue.ToString();
            _chequebook.ChequeStartNo = Convert.ToInt32(numEnd.Value);
            _chequebook.CHequeEndno = Convert.ToInt32(numEnd.Value);
        }
        private void LoadComboAccounts(List<ChequeBook> _ChequeBookList)
        {
            if (_ChequeBookList.Count != 0)
            {
                cbxBanckAccounts.DataSource = _ChequeBookList;
                cbxBanckAccounts.ValueMember = "AccountId";
                cbxBanckAccounts.DisplayMember = "BankAccountName";
               // cbxBanckAccounts.SelectedIndex = 0;
            }
        }
        private void LoadComboCurrency(List<VoucherType> _CurrencyList)
        {
            if (_CurrencyList.Count != 0)
            {
                cbxCurrency.DisplayMember = "CurrencyName";
                cbxCurrency.ValueMember = "CurrencyID";
                cbxCurrency.DataSource = _CurrencyList;
               // cbxCurrency.SelectedIndex = 0;
            }
        }


    }
}
