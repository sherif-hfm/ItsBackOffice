using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BackOfficeUI.Controls;
using BackOfficeBL.Accounting;
using BackOfficeBL.General;
using BackOfficeBL;

namespace BackOfficeUI.Accounting
{
    public partial class frmBudgets : frmBaseDB
    {
        List<Budget> BudgetList;
        List<Budget> BudgetDetailsList;
        int SelectedBudgetID = -1;
        int SelectedRow = -1;
        Budget _Budget;
        public frmBudgets()
        {
            InitializeComponent();
            BudgetList = Budget.GetAllBugets();
            LoadBudgetsDataGrid(BudgetList);
            LoadComboAccount(Account.GetAllAccountTree());
            LoadComboCostCenter(CostCenter.GetAllCmbCostCenter());
            LoadComboLocation(Budget.GetAllLocations());
            LoadComboYear(FinancialYear.GetAllFinancialYears());

        }
        private void LoadBudgetsDataGrid(List<Budget> _BudgetTypeList)
        {
            if (_BudgetTypeList.Count != 0)
            {
                dgrdBudget.AutoGenerateColumns = false;
                dgrdBudget.DataSource = null;

                clmBudgetId.DataPropertyName = "BudgetId";
                clmEnglishName.DataPropertyName = "BudgetName_Eng";
                clmArName.DataPropertyName = "BudgetName_Ara";
                clmYear.DataPropertyName = "BudgetYearName";
                clmIsDisabled.DataPropertyName = "IsDisable";
                dgrdBudget.DataSource = _BudgetTypeList;

            }
        }
        private void LoadBudgetDetailsDataGrid(List<Budget> _BudgetDetailList)
        {
            if (_BudgetDetailList.Count != 0)
            {
                dgrdBudgetDetails.AutoGenerateColumns = false;
                dgrdBudgetDetails.DataSource = null;

                clmBudgetDetailID.DataPropertyName = "BudgetDtlId";
                clmBudgetYear.DataPropertyName = "BudgetYear";
                clmBugetAccount.DataPropertyName = "BudgetAccountId";
                //clmBugetCostCenter.DisplayMember = "CostCenterName";
                clmBugetCostCenter.DataPropertyName = "BudgetCostCenterId";
                //  clmBugetLocation.DisplayMember = "LocationName";
                clmBugetLocation.DataPropertyName = "BudgetLocationId";
                clmBdgtDepitAmount.DataPropertyName = "BdgtDepitAmount";
                clmBdgtCreditAmount.DataPropertyName = "BdgtCreditAmount";
                clmBdgttBalance.DataPropertyName = "BdgttBalance";
                clmBdgtFrom.DataPropertyName = "BdgtFrom";
                clmBdgtTo.DataPropertyName = "BdgtTo";

                dgrdBudgetDetails.DataSource = _BudgetDetailList;

            }
        }
        private void LoadComboAccount(List<Account> _AccountList)
        {
            if (_AccountList.Count != 0)
            {
                clmBugetAccount.ValueMember = "AccountID";
                clmBugetAccount.DisplayMember = "NameAndNo";
                clmBugetAccount.DataSource = _AccountList;
            }
        }
        private void LoadComboCostCenter(List<CostCenter> _CostCenterList)
        {
            if (_CostCenterList.Count != 0)
            {
                clmBugetCostCenter.ValueMember = "CostCenterId";
                clmBugetCostCenter.DisplayMember = "Name";
                clmBugetCostCenter.DataSource = _CostCenterList;
            }
        }
        private void LoadComboLocation(List<Budget> _LocationList)
        {
            if (_LocationList.Count != 0)
            {
                clmBugetLocation.ValueMember = "BudgetLocationId";
                clmBugetLocation.DisplayMember = "LocationName";
                clmBugetLocation.DataSource = _LocationList;
            }
        }
        private void LoadComboYear(List<FinancialYear> _FinancialYearList)
        {
            if (_FinancialYearList.Count != 0)
            {
                cbxYear.ValueMember = "YearID";
                cbxYear.DisplayMember = "YearName";
                cbxYear.DataSource = _FinancialYearList;
            }

        }
        private void ShowGUI(Budget _Budget)
        {
            if (!string.IsNullOrEmpty(_Budget.BudgetName_Ara))
            {
                txtArabicName.Text = _Budget.BudgetName_Ara;
            }
            if (!string.IsNullOrEmpty(_Budget.BudgetName_Eng))
            {
                txtEnglishName.Text = _Budget.BudgetName_Eng;
            }
            cbxYear.SelectedValue = _Budget.BudgetYearId;
            chkIsDisabled.Checked = _Budget.IsDisable;
        }
        private void GetDataFromGUI()
        {
            _Budget = new Budget();
            _Budget.BudgetId = SelectedBudgetID;
            _Budget.BudgetName_Ara = txtArabicName.Text;
            _Budget.BudgetName_Eng = txtEnglishName.Text;
            _Budget.BudgetYearId = Convert.ToInt32(cbxYear.SelectedValue);
            _Budget.IsDisable = chkIsDisabled.Checked;
            BudgetDetailsList = new List<Budget>();
            foreach (DataGridViewRow row in dgrdBudgetDetails.Rows)
            {
                Budget Details = new Budget()
                  {

                      BudgetDtlId = Convert.ToInt32(row.Cells["clmBudgetDetailID"].Value),
                      BudgetYear = Convert.ToInt32(row.Cells["clmBudgetYear"].Value),
                      BudgetAccountId = Convert.ToString(row.Cells["clmBugetAccount"].Value),
                      BudgetCostCenterId = Convert.ToInt32(row.Cells["clmBugetCostCenter"].Value),
                      BudgetLocationId = Convert.ToString(row.Cells["clmBugetLocation"].Value),
                      BdgtDepitAmount = Convert.ToDecimal(row.Cells["clmBdgtDepitAmount"].Value),
                      BdgtCreditAmount = Convert.ToDecimal(row.Cells["clmBdgtCreditAmount"].Value),
                      BdgttBalance = Convert.ToDecimal(row.Cells["clmBdgttBalance"].Value),
                      BdgtFrom = Convert.ToDateTime(row.Cells["clmBdgtFrom"].Value),
                      BdgtTo = Convert.ToDateTime(row.Cells["clmBdgtTo"].Value)
                  };
                BudgetDetailsList.Add(Details);

            }
            _Budget.BudgetDetails = BudgetDetailsList;

        }

        private void dgrdBudget_SelectionChanged(object sender, EventArgs e)
        {
            if (dgrdBudget.SelectedRows.Count != 0)
            {
                SelectedBudgetID = Convert.ToInt32(dgrdBudget.SelectedRows[0].Cells[0].Value);

                _Budget = BudgetList.Find(a => a.BudgetId == SelectedBudgetID);
                if (_Budget != null)
                {
                    ShowGUI(_Budget);
                    LoadBudgetDetailsDataGrid(Budget.GetBudgetDetails(SelectedBudgetID, _Budget.BudgetYearId));


                }
            }


        }
        private void frmBudgets_AddNew(object sender, ref bool _status)
        {
            dgrdBudget.Enabled = false;
            dgrdBudgetDetails.Enabled = true;
            SelectedRow = dgrdBudget.SelectedRows[0].Index;
            SelectedBudgetID = -1;
        }
        private void frmBudgets_Cancel(object sender)
        {
            dgrdBudget.Rows[SelectedRow].Selected = true;
            dgrdBudget_SelectionChanged(dgrdBudget, new EventArgs());
            dgrdBudget.Enabled = true;

        }
        private void frmBudgets_DataMove(object sender, MoveCommandEnum _moveCommand)
        {
            switch (_moveCommand)
            {

                case MoveCommandEnum.MoveFirst:
                    dgrdBudget.Rows[dgrdBudget.SelectedRows[0].Index].Selected = false;
                    dgrdBudget.Rows[0].Selected = true;
                    break;
                case MoveCommandEnum.MoveLast:
                    dgrdBudget.Rows[dgrdBudget.SelectedRows[0].Index].Selected = false;
                    dgrdBudget.Rows[BudgetList.Count - 1].Selected = true;
                    break;
                case MoveCommandEnum.MoveNext:
                    SelectedRow = dgrdBudget.SelectedRows[0].Index;
                    if (SelectedRow != BudgetList.Count - 1)
                    {
                        dgrdBudget.Rows[dgrdBudget.SelectedRows[0].Index].Selected = false;
                        dgrdBudget.Rows[SelectedRow + 1].Selected = true;
                    }
                    break;
                case MoveCommandEnum.MovePrev:
                    SelectedRow = dgrdBudget.SelectedRows[0].Index;
                    if (SelectedRow != 0)
                    {
                        dgrdBudget.Rows[dgrdBudget.SelectedRows[0].Index].Selected = false;
                        dgrdBudget.Rows[SelectedRow - 1].Selected = true;
                    }
                    break;
            }
        }
        private void frmBudgets_DataRefresh(object sender)
        {
            SelectedRow = dgrdBudget.SelectedRows[0].Index;
            BudgetList = Budget.GetAllBugets();
            LoadBudgetsDataGrid(BudgetList);
            dgrdBudget.Rows[SelectedRow].Selected = true;
        }
        private void frmBudgets_Edit(object sender, ref bool _status)
        {
            SelectedBudgetID = Convert.ToInt32(dgrdBudget.SelectedRows[0].Cells[0].Value);
            dgrdBudget.Enabled = false;
            dgrdBudgetDetails.Enabled = true;
            SelectedRow = dgrdBudget.SelectedRows[0].Index;
        }
        private void frmBudgets_Delete(object sender, ref bool _status)
        {
            _Budget = new Budget();
            if (SelectedBudgetID == -1)
            {
                _status = false;
                return;
            }
            DataDeleteResult result = _Budget.Delete(SelectedBudgetID);
            _status = result.DeleteStatus;
            if (result.DeleteStatus == false)
            {
                MessageBox.Show(result.ErrorMessage);
            }
            else
            {

                BudgetList = Budget.GetAllBugets();
                LoadBudgetsDataGrid(BudgetList);
                dgrdBudget.Rows[0].Selected = true;
            }
        }
        private void frmBudgets_Save(object sender, ref bool _status)
        {
            Budget budget = new Budget();
            GetDataFromGUI();

            DataSaveResult saveResult = budget.Save(_Budget);
            if (saveResult.SaveStatus == false)
            {
                _status = false;

            }
            else
            {
                BudgetList = Budget.GetAllBugets();
                LoadBudgetsDataGrid(BudgetList);
            }
            dgrdBudget.Enabled = true;
            dgrdBudget.Rows[SelectedRow].Selected = true;
            dgrdBudget_SelectionChanged(dgrdBudget, new EventArgs());

        }

    }
}
