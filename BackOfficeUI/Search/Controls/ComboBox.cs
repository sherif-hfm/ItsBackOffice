using BackOfficeBL.Search;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BackOfficeUI.Search.Controls
{
    public partial class SearchComboBox : System.Windows.Forms.ComboBox, IParametersControl
    {
        public SearchComboBox()
        {
            InitializeComponent();
            this.DropDownStyle = ComboBoxStyle.DropDownList;
            this.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
        }

        void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDataParameters();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        public BackOfficeBL.Search.SearchParameterProperties SearchParameter { get; set; }

        public System.Windows.Forms.ComboBox CompareOrderControl { get; set; }

        public string GetCondition()
        {
            if (string.IsNullOrEmpty(CompareOrderControl.Text) == false && string.IsNullOrEmpty(SearchParameter.ConditionDataFields) == false && string.IsNullOrEmpty(SearchParameter.ConditionParameters) == false)
            {
                string sql = "";
                sql = this.SearchParameter.ConditionDataFields + " " + CompareOrderControl.Text + " @" + this.SearchParameter.ConditionParameters;
                return sql;
            }
            else
                return "";
        }

        public void UpdateDataParameters()
        {
            if (this.SelectedValue != null && string.IsNullOrEmpty(this.SearchParameter.ValuesKeys) == false)
            {
                SearchMaster searchMaster = this.SearchParameter.Search;
                DataRowView comboSelectRow = (DataRowView)this.SelectedItem;
                searchMaster.DataParameters[this.SearchParameter.ValuesKeys] = comboSelectRow.Row.Field<object>(this.SearchParameter.ComboBoxValueMembers);
            }
        }
    }
}
