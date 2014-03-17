using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BackOfficeUI.Controls
{
    public partial class ToolStripMenuItem : System.Windows.Forms.ToolStripMenuItem
    {
        public ToolStripMenuItem()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        #region ************************** Properties **************************

        public string FormName { get; set; }
        public string MenuID { get; set; }
        public string FormOption { get; set; }

        #endregion
    }
}
