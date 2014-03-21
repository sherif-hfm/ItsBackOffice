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
    public partial class TreeView : System.Windows.Forms.TreeView, IControl
    {
        public TreeView()
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
            if (this.SelectedNode != null)
                return false;
            else
                return true;
        }

        public void ClearData()
        {

        }

        #endregion
    }
}
