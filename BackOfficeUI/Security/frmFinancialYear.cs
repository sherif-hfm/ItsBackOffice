using BackOfficeUI.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BackOfficeBL;
using BackOfficeBL.Security;

namespace BackOfficeUI.Security
{
    public partial class frmFinancialYear : frmBase
    {
        public frmFinancialYear()
        {
            InitializeComponent();

            var years = BackOfficeBL.Security.FinancialYear.GetAllActiveFinancialYear();
            LoadFinancialYears(years);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var FinancialYearId = int.Parse(comboBoxFinancialYear.SelectedValue.ToString());
            SetFinancialYearInfo(FinancialYearId);

            this.Hide();
            frmMenu frm = new frmMenu();
            frm.Show();
        }

        private void SetFinancialYearInfo(int FinancialYearId)
        {
            AppInfo.CurrentYear = FinancialYear.GetFinanicalYear(FinancialYearId);
        }


        private void LoadFinancialYears(List<FinancialYear> years)
        {
            if (years.Count != 0)
            {
                comboBoxFinancialYear.ValueMember = "YearId";
                comboBoxFinancialYear.DisplayMember = "YearName";
                comboBoxFinancialYear.DataSource = years;
                comboBoxFinancialYear.SelectedValue = FinancialYear.GetDefaultYear(years);
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
