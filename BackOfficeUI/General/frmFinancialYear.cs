using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BackOfficeUI.Controls;
using BackOfficeBL.General;
using BackOfficeBL;

namespace BackOfficeUI.General
{
    public partial class frmFinancialYear : frmBaseDB
    {
        int SelectedYearID = -1;
        int SelectedRow = -1;
        List<FinancialYear> FinancialYearList;
        private FinancialYear financialyear;
        public frmFinancialYear()
        {
            InitializeComponent();
        }

        private void FinancialYear_Load(object sender, EventArgs e)
        {

            FinancialYearList = FinancialYear.GetAllFinancialYears();
            LoadDataGrid(FinancialYearList);
        }

        private void LoadDataGrid(List<FinancialYear> _FinancialYearList)
        {
            if (_FinancialYearList.Count != 0)
            {
                dgrdFinancialYear.AutoGenerateColumns = false;
                dgrdFinancialYear.DataSource = null;

                clmYearID.DataPropertyName = "YearID";
                clmYearName.DataPropertyName = "YearName";
                clmYearBegin.DataPropertyName = "YearBegin";
                clmYearEnd.DataPropertyName = "YearEnd";
                clmIsDefualt.DataPropertyName = "IsDefaultYear";
                clmIsClosed.DataPropertyName = "IsClosedYear";
                dgrdFinancialYear.DataSource = _FinancialYearList;
            }
        }

        private void dgrdFinancialYear_SelectionChanged(object sender, EventArgs e)
        {
            if (dgrdFinancialYear.SelectedRows.Count != 0)
            {

                SelectedYearID = Convert.ToInt32(dgrdFinancialYear.SelectedRows[0].Cells[0].Value);
                financialyear = FinancialYearList.Find(a => a.YearID == SelectedYearID);
                if (financialyear != null)
                {
                    ShowGUI(financialyear);
                }
            }
        }

        private void ShowGUI(FinancialYear _FinancialYear)
        {
            if (!string.IsNullOrEmpty(_FinancialYear.YearName))
            {
                txtYearName.Text = _FinancialYear.YearName;
            }
            if (_FinancialYear.YearBegin != null)
            {
                dtbYearBegin.Value = _FinancialYear.YearBegin;
            }
            if (_FinancialYear.YearEnd != null)
            {
                dtbYearEnd.Value = _FinancialYear.YearEnd;
            }
            if (_FinancialYear.IsDefaultYear != null)
            {
                chkIsDefault.Checked = _FinancialYear.IsDefaultYear;
            }
            if (_FinancialYear.IsClosedYear != null)
            {
                chkIsClosed.Checked = _FinancialYear.IsClosedYear;
            }
        }
        private void GetDataFromGUI()
        {
            financialyear = new FinancialYear();
            financialyear.YearID = SelectedYearID;
            financialyear.YearName = txtYearName.Text;
            financialyear.YearBegin = dtbYearBegin.Value.Date;
            financialyear.YearEnd = dtbYearEnd.Value.Date;
            financialyear.IsDefaultYear = chkIsDefault.Checked;
            financialyear.IsClosedYear = chkIsClosed.Checked;
        }

        private void frmFinancialYear_AddNew(object sender, ref bool _status)
        {
            dgrdFinancialYear.Enabled = false;
            SelectedRow = dgrdFinancialYear.SelectedRows[0].Index;
            SelectedYearID = -1;
        }

        private void frmFinancialYear_Edit(object sender, ref bool _status)
        {
            SelectedYearID = Convert.ToInt32(dgrdFinancialYear.SelectedRows[0].Cells[0].Value);
            dgrdFinancialYear.Enabled = false;
            SelectedRow = dgrdFinancialYear.SelectedRows[0].Index;
        }

        private void frmFinancialYear_Cancel(object sender)
        {
            dgrdFinancialYear.Rows[SelectedRow].Selected = true;
            dgrdFinancialYear_SelectionChanged(dgrdFinancialYear, new EventArgs());
            dgrdFinancialYear.Enabled = true;

        }

        private void frmFinancialYear_DataRefresh(object sender)
        {
            SelectedRow = dgrdFinancialYear.SelectedRows[0].Index;
            FinancialYearList = FinancialYear.GetAllFinancialYears();
            LoadDataGrid(FinancialYearList);
            dgrdFinancialYear.Rows[SelectedRow].Selected = true;
        }

        private void frmFinancialYear_DataMove(object sender, MoveCommandEnum _moveCommand)
        {

            switch (_moveCommand)
            {

                case MoveCommandEnum.MoveFirst:
                    dgrdFinancialYear.Rows[dgrdFinancialYear.SelectedRows[0].Index].Selected = false;
                    dgrdFinancialYear.Rows[0].Selected = true;
                    break;
                case MoveCommandEnum.MoveLast:
                    dgrdFinancialYear.Rows[dgrdFinancialYear.SelectedRows[0].Index].Selected = false;
                    dgrdFinancialYear.Rows[FinancialYearList.Count - 1].Selected = true;
                    break;
                case MoveCommandEnum.MoveNext:
                    SelectedRow = dgrdFinancialYear.SelectedRows[0].Index;
                    if (SelectedRow != FinancialYearList.Count - 1)
                    {
                        dgrdFinancialYear.Rows[dgrdFinancialYear.SelectedRows[0].Index].Selected = false;
                        dgrdFinancialYear.Rows[SelectedRow + 1].Selected = true;
                    }
                    break;
                case MoveCommandEnum.MovePrev:
                    SelectedRow = dgrdFinancialYear.SelectedRows[0].Index;
                    if (SelectedRow != 0)
                    {
                        dgrdFinancialYear.Rows[dgrdFinancialYear.SelectedRows[0].Index].Selected = false;
                        dgrdFinancialYear.Rows[SelectedRow - 1].Selected = true;
                    }
                    break;
            }
        }

        private void frmFinancialYear_Delete(object sender, ref bool _status)
        {

            financialyear = new FinancialYear();
            if (SelectedYearID == -1)
            {
                _status = false;
                return;
            }
            DataDeleteResult result = financialyear.Delete(SelectedYearID);
            _status = result.DeleteStatus;
            if (result.DeleteStatus == false)
            {
                MessageBox.Show(result.ErrorMessage);
            }
            else
            {

                FinancialYearList = FinancialYear.GetAllFinancialYears();
                LoadDataGrid(FinancialYearList);
                dgrdFinancialYear.Rows[0].Selected = true;
            }

        }

        private void frmFinancialYear_Save(object sender, ref bool _status)
        {

            FinancialYear Year = new FinancialYear();
            GetDataFromGUI();

            DataSaveResult saveResult = Year.Save(financialyear);
            if (saveResult.SaveStatus == false)
            {
                _status = false;

            }
            else
            {
                FinancialYearList = FinancialYear.GetAllFinancialYears();
                LoadDataGrid(FinancialYearList);
            }
            dgrdFinancialYear.Enabled = true;
            dgrdFinancialYear.Rows[SelectedRow].Selected = true;
            dgrdFinancialYear_SelectionChanged(dgrdFinancialYear, new EventArgs());
        }
    }
}
