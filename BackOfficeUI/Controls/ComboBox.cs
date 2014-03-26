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
    public partial class ComboBox : System.Windows.Forms.ComboBox, IControl
    {
        public ComboBox()
        {
            InitializeComponent();
            this.BackColor = Color.White;
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

        private int mDefaultIndex = -1;
        public int DefaultIndex { get { return mDefaultIndex; } set { mDefaultIndex = value; } }

        #endregion

        #region ************************** Methods **************************

        public void Lock()
        {
            this.Enabled = false;
        }

        public void UnLock()
        {
            this.Enabled = true;
        }

        public bool IsEmpty()
        {
            if (this.SelectedValue != null)
                return false;
            else
                return true;
        }

        public void ClearData()
        {
            this.SelectedIndex = mDefaultIndex;
        }


        #endregion
    }
}
