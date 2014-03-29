using BackOfficeBL.Search;
using BackOfficeUI.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BackOfficeUI.Search
{
    public partial class frmContextSearch : frmBase
    {
        private int ContextSearchId = 0;

        private ContextSearch contextSearchManager;

        IControl Parent;
        public frmContextSearch(IControl parentControl)
        {
            InitializeComponent();
            Parent = parentControl;
            ContextSearchId = parentControl.ContextSearchId;
            contextSearchManager = new ContextSearch(ContextSearchId);


        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSearch.Text != string.Empty)
            {
                var searchWord = textBoxSearch.Text;

                GetSearchResult(searchWord);


            }
        }

        private void GetSearchResult(string searchWord)
        {
            grdResult.DataSource = contextSearchManager.ExecuteSearch(searchWord);

        }
        private void SetWindowUI()
        {
            grdResult.Dock = DockStyle.Bottom;
            grdResult.Height = 200;
            grdResult.AutoGenerateColumns = false;
            grdResult.ReadOnly = true;
            grdResult.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdResult.AllowUserToAddRows = false;
            grdResult.TabStop = false;
            foreach (var colStyle in contextSearchManager.ResultGridColumnStyle)
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

                grdResult.DoubleClick += grdResult_DoubleClick;
            }

        }

        void grdResult_DoubleClick(object sender, EventArgs e)
        {
            if (grdResult.SelectedRows.Count > 0 && string.IsNullOrWhiteSpace(contextSearchManager.ReturnFields) == false)
            {
                Dictionary<string, object> result = new Dictionary<string, object>();
                DataGridViewRow grdRow = grdResult.SelectedRows[0];
                DataRowView rowData = (DataRowView)grdRow.DataBoundItem;
                foreach (string fieldStr in contextSearchManager.ReturnFields.Split(','))
                {
                    result[fieldStr] = rowData.Row.Field<object>(fieldStr);
                }


                Parent.DoContextualFind(result);
            }
        }


        private void frmContextSearch_Load(object sender, EventArgs e)
        {
            SetWindowUI();
        }

        private void grdResult_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
    }
}
