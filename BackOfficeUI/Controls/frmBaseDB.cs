using BackOfficeBL.Search;
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
    public partial class frmBaseDB : frmBase
    {
        public enum FormStatusEnum { DataPreview = 1, AddNew = 2, Edit = 4, Confirmed = 8, Posted = 16 };

        public enum MoveCommandEnum { MoveFirst = 1, MovePrev = 2, MoveNext = 3, MoveLast = 4 };

        public frmBaseDB()
        {
            InitializeComponent();
            this.KeyDown += frmBaseDB_KeyDown;
        }

        #region ************************** Form Events **************************

        void frmBaseDB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                if (this.FormStatus != FormStatusEnum.AddNew && this.FormStatus != FormStatusEnum.Edit)
                    ExitForm();
                else
                    btnCancel_Click(this,null);
        }

        #endregion

        #region ************************** Properties **************************

        private FormStatusEnum mFormStatus = FormStatusEnum.DataPreview;
        public FormStatusEnum FormStatus { get { return mFormStatus; } set { mFormStatus = value; UpdateToolBar(); LockControls((Control)this); } }

        private int mAllowedFunctions = 0;
        public int AllowedFunctions { get { return mAllowedFunctions; } set { mAllowedFunctions = value; UpdateToolBar(); } }

        #endregion

        #region ************************** Methods **************************

        private void UpdateToolBar()
        {
            if (DesignMode == true)
                return;
            foreach (var ctrl in toolBar.Items)
            {
                if (ctrl is ToolStripButton)
                {
                    ToolStripButton btn = (ToolStripButton)ctrl;
                    if ((btn.ShowInModes & (int)this.FormStatus) > 0 && (btn.FunctionsCode & this.AllowedFunctions ) > 0)
                        btn.Visible = true;
                    else
                        btn.Visible = false;
                }

                if (ctrl is ToolStripSeparator)
                {
                    ToolStripSeparator spr = (ToolStripSeparator)ctrl;
                    if ((spr.ShowInModes & (int)this.FormStatus) > 0)
                        spr.Visible = true;
                    else
                        spr.Visible = false;
                }
            }
        }

        private void LoadFormProperties()
        {

            if (this.FormMenuItem != null && DesignMode == false)
            {
                this.AllowedFunctions = this.FormMenuItem.FormAllowedFunctions;
            }
        }

        private void LockControls(Control _container)
        {
            if (DesignMode == true)
                return;

            foreach (Control crControl in _container.Controls)
            {
                LockControls(crControl);

                if (crControl is IControl)
                {
                    IControl control = (IControl)crControl;
                    if ((control.LockedInModes & (int)this.FormStatus) > 0)
                        control.Lock();
                    else
                        control.UnLock();
                }
            }
        }

        private bool CheckRequiredFields(Control _container)
        {
            bool result = true;

            foreach (Control crControl in _container.Controls)
            {
                if (CheckRequiredFields(crControl) == false)
                    result = false;

                if (crControl is IControl)
                {
                    IControl control = (IControl)crControl;
                    if (control.IsRequired == true)
                    {
                        if (control.IsEmpty() == true)
                        {
                            result = false;
                            errProv.SetError((Control)control, BackOfficeResources.Messages.PleaseFill);
                        }
                    }
                }
            }
            return result;
        }

        private void ClearAllControls(Control _container)
        {
            if (DesignMode == true)
                return;

            foreach (Control crControl in _container.Controls)
            {
                if (crControl.HasChildren) {
                    foreach (Control crChildControlitem in crControl.Controls)
                    {
                        ClearControl(crChildControlitem);
                    }
                }

                ClearControl(crControl);
            }
        }

        private void ClearControl(Control crControl)
        {

            LockControls(crControl);

            if (crControl is IControl)
            {
                IControl control = (IControl)crControl;
                control.ClearData();
            }
        }

        private void ExitForm()
        {
            //DialogResult result = MessageBox.Show(NewAppsResources.Messages.ConfirmExit, NewAppsResources.Messages.MessageBoxTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            //if (result == System.Windows.Forms.DialogResult.Yes)
                this.Close();
        }

        #endregion

        private void frmBaseDB_Load(object sender, EventArgs e)
        {
            if (DesignMode == false)
            {
                LoadFormProperties();
                UpdateToolBar();
                LockControls(this);
            }
        }

        #region ************************** ToolBar Button Commands **************************

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            bool status = true;
               
                DoAddNew(ref status);
                if (status == true)
                {
                    this.FormStatus = FormStatusEnum.AddNew;
                    ClearAllControls(this);
                }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(BackOfficeResources.Messages.ConfirmExit, BackOfficeResources.Messages.MessageBoxTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                errProv.Clear();
                DoCancel();
                this.FormStatus = FormStatusEnum.DataPreview;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool status = true;
            if (CheckRequiredFields(this) == false)
                return;
            DoSave(ref status);
            if (status == true)
            {
                this.FormStatus = FormStatusEnum.DataPreview;
            }
            errProv.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(BackOfficeResources.Messages.ConfirmDelete, BackOfficeResources.Messages.MessageBoxTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != System.Windows.Forms.DialogResult.Yes)
                return;

            bool status = true;
            DoDelete(ref status);
            if (status == true)
            {
                ClearAllControls(this);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            bool status = true;
            DoPost1(ref status);
            if (status == true)
            {
                this.FormStatus = FormStatusEnum.Confirmed;
            }
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            bool status = true;
            DoPost2(ref status);
            if (status == true)
            {
                this.FormStatus = FormStatusEnum.Posted;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            bool status = true;
            DoEdit(ref status);
            if (status == true)
            {
                this.FormStatus = FormStatusEnum.Edit;
            }
        }

        private void btnMoveFirst_Click(object sender, EventArgs e)
        {
            DoDataMove(MoveCommandEnum.MoveFirst);
        }

        private void btnMovePrev_Click(object sender, EventArgs e)
        {
            DoDataMove(MoveCommandEnum.MovePrev);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DoDataRefresh();
        }

        private void btnMoveNext_Click(object sender, EventArgs e)
        {
            DoDataMove(MoveCommandEnum.MoveNext);
        }

        private void btnMoveLast_Click(object sender, EventArgs e)
        {
            DoDataMove(MoveCommandEnum.MoveLast);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DoSearch();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DoPrint();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitForm();
        }

        #endregion

        #region ************************** Events **************************

        public delegate void AddNewDelegate(object sender, ref bool _status);
        public event AddNewDelegate AddNew;
        private void DoAddNew(ref bool _status)
        {
            if (AddNew != null)
                AddNew(this,ref _status);
        }

        public delegate void EditDelegate(object sender, ref bool _status);
        public event EditDelegate Edit;
        private void DoEdit(ref bool _status)
        {
            if (Edit != null)
                Edit(this, ref _status);
        }

        public delegate void DeleteDelegate(object sender, ref bool _status);
        public event DeleteDelegate Delete;
        private void DoDelete(ref bool _status)
        {
            if (Delete != null)
                Delete(this, ref _status);
        }

        public delegate void Post1Delegate(object sender, ref bool _status);
        public event Post1Delegate Post1;
        private void DoPost1(ref bool _status)
        {
            if (Post1 != null)
                Post1(this, ref _status);
        }
       
        public delegate void Post2Delegate(object sender, ref bool _status);
        public event Post2Delegate Post2;
        private void DoPost2(ref bool _status)
        {
            if (Post2 != null)
                Post2(this, ref _status);
        }

        public delegate void SaveDelegate(object sender, ref bool _status);
        public event SaveDelegate Save;
        private void DoSave(ref bool _status)
        {
            if (Save != null)
                Save(this, ref _status);
        }

        public delegate void PrintDelegate(object sender);
        public event PrintDelegate Print;
        private void DoPrint()
        {
            if (Print != null)
                Print(this);
        }

        public delegate void SearchDelegate(object sender);
        public event SearchDelegate Search;
        private void DoSearch()
        {
            if (Search != null)
                Search(this);
        }

        public delegate void DataMoveDelegate(object sender,MoveCommandEnum _moveCommand);
        public event DataMoveDelegate DataMove;
        private void DoDataMove(MoveCommandEnum _moveCommand)
        {
            if (DataMove != null)
                DataMove(this, _moveCommand);
        }

        public delegate void CancelDelegate(object sender);
        public event CancelDelegate Cancel;
        private void DoCancel()
        {
            if (Cancel != null)
                Cancel(this);
        }

        public delegate void DataRefreshDelegate(object sender);
        public event DataRefreshDelegate DataRefresh;
        private void DoDataRefresh()
        {
            if (DataRefresh != null)
                DataRefresh(this);
        }

        public delegate void FindDelegate(object sender, Dictionary<string, object> _findFields);
        public event FindDelegate Find;
        public void DoFind(Dictionary<string,object> _findFields)
        {
            if (Find != null && _findFields.Count > 0) 
            if (Find != null)
                Find(this, _findFields);
        }

        #endregion

    }
}
