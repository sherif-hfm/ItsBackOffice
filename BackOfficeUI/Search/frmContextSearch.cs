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
        private string SearchQuery = string.Empty;


        public frmContextSearch(IControl parentControl)
        {
            InitializeComponent();
            ContextSearchId = parentControl.ContextSearchId;
            SetWindowUI(parentControl);
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


        }
        private static void SetWindowUI(IControl parentControl)
        {
            MessageBox.Show(parentControl.ContextSearchId.ToString());

        }
    }
}
