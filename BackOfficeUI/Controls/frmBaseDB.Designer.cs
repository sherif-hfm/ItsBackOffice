namespace BackOfficeUI.Controls
{
    partial class frmBaseDB
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolBar = new System.Windows.Forms.ToolStrip();
            this.btnAddNew = new BackOfficeUI.Controls.ToolStripButton();
            this.btnEdit = new BackOfficeUI.Controls.ToolStripButton();
            this.btnDelete = new BackOfficeUI.Controls.ToolStripButton();
            this.toolStripSeparator1 = new BackOfficeUI.Controls.ToolStripSeparator();
            this.btnConfirm = new BackOfficeUI.Controls.ToolStripButton();
            this.btnPost = new BackOfficeUI.Controls.ToolStripButton();
            this.toolStripSeparator3 = new BackOfficeUI.Controls.ToolStripSeparator();
            this.btnMoveFirst = new BackOfficeUI.Controls.ToolStripButton();
            this.btnMovePrev = new BackOfficeUI.Controls.ToolStripButton();
            this.btnRefresh = new BackOfficeUI.Controls.ToolStripButton();
            this.btnMoveNext = new BackOfficeUI.Controls.ToolStripButton();
            this.btnMoveLast = new BackOfficeUI.Controls.ToolStripButton();
            this.toolStripSeparator4 = new BackOfficeUI.Controls.ToolStripSeparator();
            this.btnSearch = new BackOfficeUI.Controls.ToolStripButton();
            this.btnPrint = new BackOfficeUI.Controls.ToolStripButton();
            this.toolStripSeparator2 = new BackOfficeUI.Controls.ToolStripSeparator();
            this.btnExit = new BackOfficeUI.Controls.ToolStripButton();
            this.btnSave = new BackOfficeUI.Controls.ToolStripButton();
            this.btnCancel = new BackOfficeUI.Controls.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.errProv = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProv)).BeginInit();
            this.SuspendLayout();
            // 
            // toolBar
            // 
            this.toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddNew,
            this.btnEdit,
            this.btnDelete,
            this.toolStripSeparator1,
            this.btnConfirm,
            this.btnPost,
            this.toolStripSeparator3,
            this.btnMoveFirst,
            this.btnMovePrev,
            this.btnRefresh,
            this.btnMoveNext,
            this.btnMoveLast,
            this.toolStripSeparator4,
            this.btnSearch,
            this.btnPrint,
            this.toolStripSeparator2,
            this.btnExit,
            this.btnSave,
            this.btnCancel});
            this.toolBar.Location = new System.Drawing.Point(0, 0);
            this.toolBar.Name = "toolBar";
            this.toolBar.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolBar.Size = new System.Drawing.Size(859, 44);
            this.toolBar.TabIndex = 0;
            this.toolBar.Text = "toolStrip1";
            // 
            // btnAddNew
            // 
            this.btnAddNew.AutoSize = false;
            this.btnAddNew.FunctionsCode = 1;
            this.btnAddNew.Image = global::BackOfficeUI.Resource.AddNew_Image;
            this.btnAddNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAddNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.ShowInModes = 25;
            this.btnAddNew.Size = new System.Drawing.Size(54, 41);
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.AutoSize = false;
            this.btnEdit.FunctionsCode = 2;
            this.btnEdit.Image = global::BackOfficeUI.Resource.Edit_Image;
            this.btnEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ShowInModes = 1;
            this.btnEdit.Size = new System.Drawing.Size(54, 41);
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = false;
            this.btnDelete.FunctionsCode = 4;
            this.btnDelete.Image = global::BackOfficeUI.Resource.Delete_Image;
            this.btnDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ShowInModes = 1;
            this.btnDelete.Size = new System.Drawing.Size(54, 41);
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.ShowInModes = 1;
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 44);
            // 
            // btnConfirm
            // 
            this.btnConfirm.AutoSize = false;
            this.btnConfirm.FunctionsCode = 16;
            this.btnConfirm.Image = global::BackOfficeUI.Resource.Post1;
            this.btnConfirm.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnConfirm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.ShowInModes = 1;
            this.btnConfirm.Size = new System.Drawing.Size(54, 41);
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnPost
            // 
            this.btnPost.AutoSize = false;
            this.btnPost.FunctionsCode = 32;
            this.btnPost.Image = global::BackOfficeUI.Resource.PostData_Image;
            this.btnPost.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPost.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPost.Name = "btnPost";
            this.btnPost.ShowInModes = 9;
            this.btnPost.Size = new System.Drawing.Size(54, 41);
            this.btnPost.Text = "Post";
            this.btnPost.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.ShowInModes = 25;
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 44);
            // 
            // btnMoveFirst
            // 
            this.btnMoveFirst.AutoSize = false;
            this.btnMoveFirst.FunctionsCode = 64;
            this.btnMoveFirst.Image = global::BackOfficeUI.Resource.MoveFrist_Image;
            this.btnMoveFirst.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnMoveFirst.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMoveFirst.Name = "btnMoveFirst";
            this.btnMoveFirst.ShowInModes = 25;
            this.btnMoveFirst.Size = new System.Drawing.Size(54, 41);
            this.btnMoveFirst.Text = "MoveFirst";
            this.btnMoveFirst.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMoveFirst.Click += new System.EventHandler(this.btnMoveFirst_Click);
            // 
            // btnMovePrev
            // 
            this.btnMovePrev.AutoSize = false;
            this.btnMovePrev.FunctionsCode = 64;
            this.btnMovePrev.Image = global::BackOfficeUI.Resource.MovePrev_Image;
            this.btnMovePrev.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnMovePrev.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMovePrev.Name = "btnMovePrev";
            this.btnMovePrev.ShowInModes = 25;
            this.btnMovePrev.Size = new System.Drawing.Size(54, 41);
            this.btnMovePrev.Text = "MovePrev";
            this.btnMovePrev.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMovePrev.Click += new System.EventHandler(this.btnMovePrev_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.AutoSize = false;
            this.btnRefresh.FunctionsCode = 64;
            this.btnRefresh.Image = global::BackOfficeUI.Resource.RefreshData_Image;
            this.btnRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ShowInModes = 25;
            this.btnRefresh.Size = new System.Drawing.Size(54, 41);
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnMoveNext
            // 
            this.btnMoveNext.AutoSize = false;
            this.btnMoveNext.FunctionsCode = 64;
            this.btnMoveNext.Image = global::BackOfficeUI.Resource.MoveNext_Image;
            this.btnMoveNext.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnMoveNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMoveNext.Name = "btnMoveNext";
            this.btnMoveNext.ShowInModes = 25;
            this.btnMoveNext.Size = new System.Drawing.Size(54, 41);
            this.btnMoveNext.Text = "MoveNext";
            this.btnMoveNext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMoveNext.Click += new System.EventHandler(this.btnMoveNext_Click);
            // 
            // btnMoveLast
            // 
            this.btnMoveLast.AutoSize = false;
            this.btnMoveLast.FunctionsCode = 64;
            this.btnMoveLast.Image = global::BackOfficeUI.Resource.MoveLast_Image;
            this.btnMoveLast.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnMoveLast.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMoveLast.Name = "btnMoveLast";
            this.btnMoveLast.ShowInModes = 25;
            this.btnMoveLast.Size = new System.Drawing.Size(54, 41);
            this.btnMoveLast.Text = "MoveLast";
            this.btnMoveLast.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMoveLast.Click += new System.EventHandler(this.btnMoveLast_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.ShowInModes = 25;
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 44);
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = false;
            this.btnSearch.FunctionsCode = 128;
            this.btnSearch.Image = global::BackOfficeUI.Resource.Search_Image;
            this.btnSearch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ShowInModes = 25;
            this.btnSearch.Size = new System.Drawing.Size(54, 41);
            this.btnSearch.Text = "Search";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.AutoSize = false;
            this.btnPrint.FunctionsCode = 8;
            this.btnPrint.Image = global::BackOfficeUI.Resource.Print_Image;
            this.btnPrint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.ShowInModes = 25;
            this.btnPrint.Size = new System.Drawing.Size(54, 41);
            this.btnPrint.Text = "Print";
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.ShowInModes = 1;
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 44);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = false;
            this.btnExit.FunctionsCode = 255;
            this.btnExit.Image = global::BackOfficeUI.Resource.ExitMyFrm_Image;
            this.btnExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.ShowInModes = 25;
            this.btnExit.Size = new System.Drawing.Size(54, 41);
            this.btnExit.Text = "Exit";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = false;
            this.btnSave.FunctionsCode = 3;
            this.btnSave.Image = global::BackOfficeUI.Resource.Save_Image;
            this.btnSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.ShowInModes = 6;
            this.btnSave.Size = new System.Drawing.Size(54, 41);
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = false;
            this.btnCancel.FunctionsCode = 3;
            this.btnCancel.Image = global::BackOfficeUI.Resource.Cancel_Image;
            this.btnCancel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ShowInModes = 6;
            this.btnCancel.Size = new System.Drawing.Size(54, 41);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 379);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip.Size = new System.Drawing.Size(859, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // errProv
            // 
            this.errProv.ContainerControl = this;
            // 
            // frmBaseDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 401);
            this.ControlBox = false;
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolBar);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBaseDB";
            this.Text = "frmBaseDB";
            this.Load += new System.EventHandler(this.frmBaseDB_Load);
            this.toolBar.ResumeLayout(false);
            this.toolBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolBar;
        private Controls.ToolStripButton btnDelete;
        private ToolStripButton btnAddNew;
        private ToolStripButton btnEdit;
        private ToolStripButton btnConfirm;
        private ToolStripButton btnPost;
        private ToolStripButton btnMoveFirst;
        private ToolStripButton btnMovePrev;
        private ToolStripButton btnMoveNext;
        private ToolStripButton btnMoveLast;
        private ToolStripButton btnRefresh;
        private ToolStripButton btnSearch;
        private ToolStripButton btnPrint;
        private ToolStripButton btnExit;
        private ToolStripButton btnSave;
        private ToolStripButton btnCancel;
        private BackOfficeUI.Controls.ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ErrorProvider errProv;
    }
}