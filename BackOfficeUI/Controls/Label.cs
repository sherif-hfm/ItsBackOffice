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
    public partial class Label : System.Windows.Forms.Label, IControl
    {
        public Label()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        #region ************************** Properties **************************

        private int mLockedInModes = 25;
        public int LockedInModes { get { return mLockedInModes; } set { mLockedInModes = value; } }

        private bool mIsRequired = false;
        public bool IsRequired { get { return mIsRequired; } set { mIsRequired = value; } }

        #endregion

        #region ************************** Methods **************************

        public void Lock()
        {
        }

        public void UnLock()
        {
            this.Enabled = true;
        }

        public bool IsEmpty()
        {
            return false;
        }

        public void ClearData()
        {
        }

        #endregion
    }
}
