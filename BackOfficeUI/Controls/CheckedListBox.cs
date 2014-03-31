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
    public partial class CheckedListBox : System.Windows.Forms.CheckedListBox, IControl
    {
        public CheckedListBox()
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

        private int mContextSearchId = 0;
        public int ContextSearchId { get { return mContextSearchId; } set { mContextSearchId = value; } }


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
            if (this.SelectedItems.Count > 0)
                return false;
            else
                return true;
        }

        public void ClearData()
        {
            this.SelectedItems.Clear();
        }

        #endregion

        public bool Clearable { get; set; }

        public delegate void FindDelegate(object sender, Dictionary<string, object> _findFields);
        public event FindDelegate ContextualFind;
        public void DoContextualFind(Dictionary<string, object> _findFields)
        {
            if (ContextualFind != null && _findFields.Count > 0)
                if (ContextualFind != null)
                    ContextualFind(this, _findFields);
        }

    }
}
