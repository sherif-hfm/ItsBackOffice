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
    public partial class SearchTextBox : System.Windows.Forms.TextBox, IParametersControl
    {
        public SearchTextBox()
        {
            InitializeComponent();
            this.KeyDown += TextBox_KeyDown;
            this.TextChanged += TextBox_TextChanged;
        }

        void TextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateDataParameters();
        }

        void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
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
            if (string.IsNullOrEmpty(this.Text) == false && string.IsNullOrEmpty(this.SearchParameter.ValuesKeys) == false)
            {
                SearchMaster searchMaster = this.SearchParameter.Search;
                if (this.CompareOrderControl.Text == "Like")
                    searchMaster.DataParameters[this.SearchParameter.ValuesKeys] = "%" + this.Text + "%";
                else
                    searchMaster.DataParameters[this.SearchParameter.ValuesKeys] = this.Text;
            }
        }
    }
}
