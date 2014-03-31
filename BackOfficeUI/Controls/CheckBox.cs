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
    public partial class CheckBox : System.Windows.Forms.CheckBox,IControl 
    {
        public CheckBox()
        {
            InitializeComponent();
            this.ForeColor = Color.Black;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
        #region ************************** Properties **************************

        private int mLockedInModes = 25;
        public int LockedInModes { get { return mLockedInModes; } set { mLockedInModes = value; } }

        private int mContextSearchId = 0;
        public int ContextSearchId { get { return mContextSearchId; } set { mContextSearchId = value; } }

        private bool mIsRequired = false;
        public bool IsRequired { get { return mIsRequired; } set { mIsRequired = value; } }

        private bool mClearable = true;
        public bool Clearable { get { return mClearable; } set { mClearable = value; } }

        #endregion

        #region ************************** Methods **************************

        public void Lock()
        {
            this.AutoCheck = false;
        }

        public void UnLock()
        {
            this.AutoCheck = true;
        }

        public bool IsEmpty()
        {
            return false;
        }

        public void ClearData()
        {
            this.Checked = false;
        }

        #endregion


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
