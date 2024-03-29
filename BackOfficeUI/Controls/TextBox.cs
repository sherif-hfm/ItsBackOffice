﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BackOfficeUI.Controls
{
    public partial class TextBox : System.Windows.Forms.TextBox, IControl
    {
        public TextBox()
        {
            InitializeComponent();
            this.KeyDown += TextBox_KeyDown;
            this.BackColor = Color.White;
        }

        void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
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


        private bool mClearable = true;
        public bool Clearable { get { return mClearable; } set { mClearable = value; } }


        private bool mIsRequired = false;
        public bool IsRequired { get { return mIsRequired; } set { mIsRequired = value; } }

        #endregion

        #region ************************** Methods **************************

        public void Lock()
        {
            this.ReadOnly = true;
        }

        public void UnLock()
        {
            this.ReadOnly = false;
        }

        public bool IsEmpty()
        {
            if (string.IsNullOrEmpty(this.Text) == true)
                return true;
            else
                return false;
        }

        public void ClearData()
        {
            this.Clear();
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
