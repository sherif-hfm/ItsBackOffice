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
    public partial class ToolStripSeparator : System.Windows.Forms.ToolStripSeparator
    {
        public ToolStripSeparator()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

      

        #region ************************** Properties **************************

        public int ShowInModes { get; set; }

        #endregion
    }
}
