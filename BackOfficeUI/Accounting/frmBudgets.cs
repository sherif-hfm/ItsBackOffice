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

namespace BackOfficeUI.Accounting
{
    public partial class frmBudgets : frmBaseDB
    {
        List<Budget> BudgetList;
        int SelectedBudgetID = -1;
        int SelectedRow = -1;
        public frmBudgets()
        {
            InitializeComponent();
            BudgetList = Budget.GetAllBugets();
            LoadBudgetsDataGrid(BudgetList);
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
        private void LoadBudgetDetailsDataGrid()
        {

        }

        private void dgrdBudget_SelectionChanged(object sender, EventArgs e)
        {
            if (dgrdBudget.SelectedRows.Count != 0)
            {

                SelectedBudgetID = Convert.ToInt32(dgrdBudget.SelectedRows[0].Cells[0].Value);
               // VoucherType SelectedVoucherType = VouchersList.Find(a => a.VoucherTypeId == VOUCHERTYPEID);
                //ShowGUI(SelectedVoucherType);

                //CrVoucher = SelectedVoucherType;
            }

        }

    }
}
