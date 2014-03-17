using BackOfficeUI.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BackOfficeBL.Search;
using BackOfficeUI.Search.Controls;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Reflection;
using BackOfficeBL;
namespace BackOfficeUI.Search
{
    public partial class frmSearch : frmBase
    {
        private SearchMaster CrSearchMaster;
        private System.Windows.Forms.TableLayoutPanel tblParameter;
        private System.Windows.Forms.DataGridView grdResult;
        System.Windows.Forms.Panel pnlSearchOption;

        public frmSearch()
        {
            InitializeComponent();
        }

        private void frmSearch_Load(object sender, EventArgs e)
        {
            int SearchID = 0;
            int.TryParse(this.FormOption, out SearchID);
            if (SearchID != 0)
            {
                CrSearchMaster = new SearchMaster(int.Parse(this.FormOption));
                CrSearchMaster.Load();
                CreateResultGrid();
                CreateSearchOption();
                CreateSearchParameter();
            }
        }

        private void CreateSearchParameter()
        {
            int row = 1;
            int col = 1;
            pnlParameter.Padding = new System.Windows.Forms.Padding(10);
            CreateSearchParameterTable();

            foreach (var prm in CrSearchMaster.SearchParametersProperties)
            {
                // Add Prm Lable
                System.Windows.Forms.Label lbl = new System.Windows.Forms.Label();
                lbl.Text = prm.ParameterText;
                lbl.Visible = true;
                tblParameter.Controls.Add(lbl, col, row);
                col++;
                // Add Compar Control
                System.Windows.Forms.ComboBox compareOrder = CreateCompareOrderControl(prm);
                tblParameter.Controls.Add(compareOrder, col, row);
                col++;
                // Add Prm Control
                IParametersControl PrmControl;
                switch (prm.ParameterControl)
                { 
                    case "TextBox":
                        PrmControl = CreateTextBoxParameter(prm);
                        break;
                    case "CheckBox":
                        PrmControl = CreateCheckBoxParameter(prm);
                        break;
                    case "ComboBox":
                        PrmControl = CreateComboBoxParameter(prm);
                        break;
                    case "DateTimePicker":
                        PrmControl = CreateDateTimePickerParameter(prm);
                        break;
                    default:
                        PrmControl = CreateTextBoxParameter(prm);
                        break;
                }
                PrmControl.SearchParameter = prm;
                PrmControl.CompareOrderControl = compareOrder;
                tblParameter.Controls.Add((Control)PrmControl, col, row);
                col++;
                if (col > (CrSearchMaster.ParametersColumns * 3))
                {
                    col = 1;
                    row++;
                }
            }
        }

        private void CreateSearchParameterTable()
        {
            tblParameter = new TableLayoutPanel();

            tblParameter.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;
            tblParameter.Dock = DockStyle.Top;
            tblParameter.Height = 200;
            tblParameter.AutoSize = true;
            pnlParameter.Controls.Add(tblParameter);
        }

        private void CreateSearchOption()
        {
            pnlSearchOption = new System.Windows.Forms.Panel();
            pnlSearchOption.AutoSize = true;
            pnlSearchOption.Dock = DockStyle.Top;
            pnlSearchOption.Height = 70;
            pnlSearchOption.BorderStyle = BorderStyle.None;
            pnlSearchOption.RightToLeft = System.Windows.Forms.RightToLeft.Yes;

            System.Windows.Forms.FlowLayoutPanel pnlFlow = new FlowLayoutPanel();
            pnlFlow.AutoSize = true;
            pnlFlow.Dock = DockStyle.Fill;

            System.Windows.Forms.Button btnSearch = new System.Windows.Forms.Button();
            btnSearch.Text = "Search";
            btnSearch.AutoSize = true;
            btnSearch.Click += btnSearch_Click;       

            pnlFlow.Controls.Add(btnSearch);
            pnlSearchOption.Controls.Add(pnlFlow);
            pnlParameter.Controls.Add(pnlSearchOption);
        }

        private void CreateResultGrid()
        {
            grdResult = new DataGridView();
            grdResult.Dock = DockStyle.Top;
            grdResult.Height = 200;
            grdResult.AutoGenerateColumns = false;
            grdResult.ReadOnly = true;
            grdResult.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdResult.AllowUserToAddRows = false;
            grdResult.TabStop = false;
            foreach (var colStyle in CrSearchMaster.ResultGridColumnStyle)
            {
                DataGridViewColumn gridCol;
                switch (colStyle.ColumnType)
                { 
                    case BackOfficeBL.Search.DataGridColumnStyle.ColumnTypeEnum.TextBoxColumn:
                        gridCol = new DataGridViewTextBoxColumn(); 
                        break;
                    case BackOfficeBL.Search.DataGridColumnStyle.ColumnTypeEnum.CheckBoxColumn:
                        gridCol = new DataGridViewCheckBoxColumn();
                        break;
                    default:
                        gridCol = new DataGridViewTextBoxColumn(); 
                        break;
                }
                gridCol.Name = colStyle.Name;
                gridCol.HeaderText = colStyle.HeaderText;
                gridCol.DataPropertyName = colStyle.DataPropertyName;
                grdResult.Columns.Add(gridCol);
            }
            pnlParameter.Controls.Add(grdResult);
            grdResult.DoubleClick+=grdResult_DoubleClick;
        }

        void grdResult_DoubleClick(object sender, EventArgs e)
        {
            if (grdResult.SelectedRows.Count > 0 && string.IsNullOrWhiteSpace(CrSearchMaster.ReturnsFields) == false && string.IsNullOrWhiteSpace(CrSearchMaster.EditForm) == false)
            {
                Dictionary<string, object> result = new Dictionary<string, object>();
                DataGridViewRow grdRow = grdResult.SelectedRows[0];
                DataRowView rowData = (DataRowView)grdRow.DataBoundItem;
                foreach (string fieldStr in CrSearchMaster.ReturnsFields.Split(','))
                {
                    result[fieldStr] = rowData.Row.Field<object>(fieldStr);
                }
                var menuItem = AppInfo.CurrentUser.UserMenuItems.Find(m => m.MenuID == CrSearchMaster.EditForm);
                string frmName = AppInfo.ApplicationUINamespace + "." + menuItem.FormName;
                frmBaseDB frm = (frmBaseDB)Assembly.GetExecutingAssembly().CreateInstance(frmName);
                frm.FormID = CrSearchMaster.EditForm;
                frm.MdiParent = this.MdiParent;
                frm.Show();
                frm.DoFind(result);
            }
        }

        void btnSearch_Click(object sender, EventArgs e)
        {
           string sql=  GenerateSearchSQL();
           CrSearchMaster.FullSearchSQL = sql;
           grdResult.DataSource = CrSearchMaster.ExecuteSearch();
        }

        private IParametersControl CreateTextBoxParameter(SearchParameterProperties prm)
        {
            Search.Controls.TextBox textBox = new Search.Controls.TextBox();
            textBox.Width = prm.ParameterControlWidth;

            return textBox;
        }

        private IParametersControl CreateCheckBoxParameter(SearchParameterProperties prm)
        {
            Search.Controls.CheckBox checkBox = new Search.Controls.CheckBox();
            checkBox.Width = prm.ParameterControlWidth;

            return checkBox;
        }

        private IParametersControl CreateComboBoxParameter(SearchParameterProperties prm)
        {
            Search.Controls.ComboBox comboBox = new Search.Controls.ComboBox();
            comboBox.Width = prm.ParameterControlWidth;
            comboBox.DataSource = prm.GetComboData();
            comboBox.DisplayMember = prm.ComboBoxDisplayMember;
            comboBox.ValueMember = prm.ComboBoxValueMembers;
            return comboBox;
        }

        private IParametersControl CreateDateTimePickerParameter(SearchParameterProperties prm)
        {
            Search.Controls.DateTimePicker dateTimePicker = new Search.Controls.DateTimePicker();
            dateTimePicker.Width = prm.ParameterControlWidth;

            return dateTimePicker;
        }

        private System.Windows.Forms.ComboBox CreateCompareOrderControl(SearchParameterProperties prm)
        {
            System.Windows.Forms.ComboBox compareOrderControl = new System.Windows.Forms.ComboBox();
            compareOrderControl.Width = 60;
            compareOrderControl.DropDownStyle = ComboBoxStyle.DropDownList;
            compareOrderControl.TabStop = false;
            if (string.IsNullOrWhiteSpace(prm.ComperOrders) == false)
            {
                string[] compareOrders = prm.ComperOrders.Split(',');
                compareOrderControl.DataSource = compareOrders;
            }
            else
                compareOrderControl.Visible = false;
            return compareOrderControl;
        }

        private string GenerateSearchSQL()
        {
            string sql = CrSearchMaster.SearchSQL;
            if (CrSearchMaster.AddWhere == true)
                sql += " Where ";
            foreach (var prmControl in tblParameter.Controls)
            {
                if (prmControl is IParametersControl)
                {
                    string condition = "";
                    IParametersControl CrPrmControl=(IParametersControl)prmControl;
                    condition = CrPrmControl.GetCondition();
                    if (string.IsNullOrWhiteSpace(condition) == false)
                    {
                        sql += condition + " And ";
                    }
                    if (string.IsNullOrWhiteSpace(CrPrmControl.SearchParameter.ValuesKeys) == false)
                        CrPrmControl.UpdateDataParameters();
                }
            }
            if (sql.EndsWith("And ") == true)
                sql = sql.Substring(0, sql.Length - 4);
            
            if (sql.EndsWith("Where ") == true)
                sql = sql.Substring(0, sql.Length - 6);
            return sql;
        }

        private void frmSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

    }
}
