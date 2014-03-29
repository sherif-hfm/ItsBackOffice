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

        public frmContextSearch(IControl parentControl)
        {
            InitializeComponent();
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
            }

        }

        private void frmContextSearch_Load(object sender, EventArgs e)
        {
            SetWindowUI();
        }
    }
}
