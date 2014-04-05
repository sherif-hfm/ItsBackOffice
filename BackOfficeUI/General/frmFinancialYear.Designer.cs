namespace BackOfficeUI.General
{
    partial class frmFinancialYear
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
            this.dgrdFinancialYear = new System.Windows.Forms.DataGridView();
            this.clmYearID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmYearName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmYearBegin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmYearEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIsDefualt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIsClosed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtYearName = new BackOfficeUI.Controls.TextBox();
            this.lbl_YearName = new BackOfficeUI.Controls.Label();
            this.chkIsDefault = new BackOfficeUI.Controls.CheckBox();
            this.chkIsClosed = new BackOfficeUI.Controls.CheckBox();
            this.lblYearBegin = new BackOfficeUI.Controls.Label();
            this.lblYearEnd = new BackOfficeUI.Controls.Label();
            this.dtbYearBegin = new System.Windows.Forms.DateTimePicker();
            this.dtbYearEnd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new BackOfficeUI.Controls.Label();
            this.txtPrefix = new BackOfficeUI.Controls.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdFinancialYear)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrdFinancialYear
            // 
            this.dgrdFinancialYear.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrdFinancialYear.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmYearID,
            this.clmYearName,
            this.clmYearBegin,
            this.clmYearEnd,
            this.clmIsDefualt,
            this.clmIsClosed});
            this.dgrdFinancialYear.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgrdFinancialYear.Location = new System.Drawing.Point(0, 44);
            this.dgrdFinancialYear.MultiSelect = false;
            this.dgrdFinancialYear.Name = "dgrdFinancialYear";
            this.dgrdFinancialYear.ReadOnly = true;
            this.dgrdFinancialYear.RowHeadersVisible = false;
            this.dgrdFinancialYear.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrdFinancialYear.Size = new System.Drawing.Size(859, 150);
            this.dgrdFinancialYear.TabIndex = 0;
            this.dgrdFinancialYear.SelectionChanged += new System.EventHandler(this.dgrdFinancialYear_SelectionChanged);
            // 
            // clmYearID
            // 
            this.clmYearID.HeaderText = "";
            this.clmYearID.Name = "clmYearID";
            this.clmYearID.ReadOnly = true;
            this.clmYearID.Visible = false;
            this.clmYearID.Width = 5;
            // 
            // clmYearName
            // 
            this.clmYearName.HeaderText = "Year Name";
            this.clmYearName.Name = "clmYearName";
            this.clmYearName.ReadOnly = true;
            this.clmYearName.Width = 180;
            // 
            // clmYearBegin
            // 
            this.clmYearBegin.HeaderText = "Year Begin";
            this.clmYearBegin.Name = "clmYearBegin";
            this.clmYearBegin.ReadOnly = true;
            this.clmYearBegin.Width = 140;
            // 
            // clmYearEnd
            // 
            this.clmYearEnd.HeaderText = "Year End";
            this.clmYearEnd.Name = "clmYearEnd";
            this.clmYearEnd.ReadOnly = true;
            this.clmYearEnd.Width = 140;
            // 
            // clmIsDefualt
            // 
            this.clmIsDefualt.HeaderText = "Is Default";
            this.clmIsDefualt.Name = "clmIsDefualt";
            this.clmIsDefualt.ReadOnly = true;
            this.clmIsDefualt.Width = 120;
            // 
            // clmIsClosed
            // 
            this.clmIsClosed.HeaderText = "Is Closed";
            this.clmIsClosed.Name = "clmIsClosed";
            this.clmIsClosed.ReadOnly = true;
            this.clmIsClosed.Width = 80;
            // 
            // txtYearName
            // 
            this.txtYearName.BackColor = System.Drawing.Color.White;
            this.txtYearName.Clearable = true;
            this.txtYearName.ContextSearchId = 0;
            this.txtYearName.IsRequired = true;
            this.txtYearName.Location = new System.Drawing.Point(101, 217);
            this.txtYearName.LockedInModes = 25;
            this.txtYearName.MaxLength = 50;
            this.txtYearName.Name = "txtYearName";
            this.txtYearName.Size = new System.Drawing.Size(311, 27);
            this.txtYearName.TabIndex = 1;
            // 
            // lbl_YearName
            // 
            this.lbl_YearName.AutoSize = true;
            this.lbl_YearName.Clearable = true;
            this.lbl_YearName.ContextSearchId = 0;
            this.lbl_YearName.IsRequired = false;
            this.lbl_YearName.Location = new System.Drawing.Point(6, 221);
            this.lbl_YearName.LockedInModes = 25;
            this.lbl_YearName.Name = "lbl_YearName";
            this.lbl_YearName.Size = new System.Drawing.Size(87, 19);
            this.lbl_YearName.TabIndex = 4;
            this.lbl_YearName.Text = "Year Name";
            // 
            // chkIsDefault
            // 
            this.chkIsDefault.AutoSize = true;
            this.chkIsDefault.Clearable = true;
            this.chkIsDefault.ContextSearchId = 0;
            this.chkIsDefault.ForeColor = System.Drawing.Color.Black;
            this.chkIsDefault.IsRequired = false;
            this.chkIsDefault.Location = new System.Drawing.Point(445, 219);
            this.chkIsDefault.LockedInModes = 25;
            this.chkIsDefault.Name = "chkIsDefault";
            this.chkIsDefault.Size = new System.Drawing.Size(94, 23);
            this.chkIsDefault.TabIndex = 2;
            this.chkIsDefault.Text = "Is default";
            this.chkIsDefault.UseVisualStyleBackColor = true;
            // 
            // chkIsClosed
            // 
            this.chkIsClosed.AutoSize = true;
            this.chkIsClosed.Clearable = true;
            this.chkIsClosed.ContextSearchId = 0;
            this.chkIsClosed.ForeColor = System.Drawing.Color.Black;
            this.chkIsClosed.IsRequired = false;
            this.chkIsClosed.Location = new System.Drawing.Point(572, 219);
            this.chkIsClosed.LockedInModes = 25;
            this.chkIsClosed.Name = "chkIsClosed";
            this.chkIsClosed.Size = new System.Drawing.Size(93, 23);
            this.chkIsClosed.TabIndex = 3;
            this.chkIsClosed.Text = "Is Closed";
            this.chkIsClosed.UseVisualStyleBackColor = true;
            // 
            // lblYearBegin
            // 
            this.lblYearBegin.AutoSize = true;
            this.lblYearBegin.Clearable = true;
            this.lblYearBegin.ContextSearchId = 0;
            this.lblYearBegin.IsRequired = false;
            this.lblYearBegin.Location = new System.Drawing.Point(6, 270);
            this.lblYearBegin.LockedInModes = 25;
            this.lblYearBegin.Name = "lblYearBegin";
            this.lblYearBegin.Size = new System.Drawing.Size(85, 19);
            this.lblYearBegin.TabIndex = 8;
            this.lblYearBegin.Text = "Year Begin";
            // 
            // lblYearEnd
            // 
            this.lblYearEnd.AutoSize = true;
            this.lblYearEnd.Clearable = true;
            this.lblYearEnd.ContextSearchId = 0;
            this.lblYearEnd.IsRequired = false;
            this.lblYearEnd.Location = new System.Drawing.Point(370, 270);
            this.lblYearEnd.LockedInModes = 25;
            this.lblYearEnd.Name = "lblYearEnd";
            this.lblYearEnd.Size = new System.Drawing.Size(73, 19);
            this.lblYearEnd.TabIndex = 10;
            this.lblYearEnd.Text = "Year End";
            // 
            // dtbYearBegin
            // 
            this.dtbYearBegin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtbYearBegin.Location = new System.Drawing.Point(101, 266);
            this.dtbYearBegin.Name = "dtbYearBegin";
            this.dtbYearBegin.Size = new System.Drawing.Size(200, 27);
            this.dtbYearBegin.TabIndex = 11;
            // 
            // dtbYearEnd
            // 
            this.dtbYearEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtbYearEnd.Location = new System.Drawing.Point(459, 266);
            this.dtbYearEnd.Name = "dtbYearEnd";
            this.dtbYearEnd.Size = new System.Drawing.Size(200, 27);
            this.dtbYearEnd.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Clearable = true;
            this.label1.ContextSearchId = 0;
            this.label1.IsRequired = false;
            this.label1.Location = new System.Drawing.Point(6, 316);
            this.label1.LockedInModes = 25;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "prefix";
            // 
            // txtPrefix
            // 
            this.txtPrefix.BackColor = System.Drawing.Color.White;
            this.txtPrefix.Clearable = true;
            this.txtPrefix.ContextSearchId = 0;
            this.txtPrefix.IsRequired = true;
            this.txtPrefix.Location = new System.Drawing.Point(101, 312);
            this.txtPrefix.LockedInModes = 25;
            this.txtPrefix.MaxLength = 50;
            this.txtPrefix.Name = "txtPrefix";
            this.txtPrefix.Size = new System.Drawing.Size(200, 27);
            this.txtPrefix.TabIndex = 13;
            // 
            // frmFinancialYear
            // 
            this.AllowedFunctions = 25;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 401);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrefix);
            this.Controls.Add(this.dtbYearEnd);
            this.Controls.Add(this.dtbYearBegin);
            this.Controls.Add(this.lblYearEnd);
            this.Controls.Add(this.lblYearBegin);
            this.Controls.Add(this.chkIsClosed);
            this.Controls.Add(this.chkIsDefault);
            this.Controls.Add(this.lbl_YearName);
            this.Controls.Add(this.txtYearName);
            this.Controls.Add(this.dgrdFinancialYear);
            this.Name = "frmFinancialYear";
            this.Text = "FinancialYear";
            this.AddNew += new BackOfficeUI.Controls.frmBaseDB.AddNewDelegate(this.frmFinancialYear_AddNew);
            this.Edit += new BackOfficeUI.Controls.frmBaseDB.EditDelegate(this.frmFinancialYear_Edit);
            this.Delete += new BackOfficeUI.Controls.frmBaseDB.DeleteDelegate(this.frmFinancialYear_Delete);
            this.Save += new BackOfficeUI.Controls.frmBaseDB.SaveDelegate(this.frmFinancialYear_Save);
            this.DataMove += new BackOfficeUI.Controls.frmBaseDB.DataMoveDelegate(this.frmFinancialYear_DataMove);
            this.Cancel += new BackOfficeUI.Controls.frmBaseDB.CancelDelegate(this.frmFinancialYear_Cancel);
            this.DataRefresh += new BackOfficeUI.Controls.frmBaseDB.DataRefreshDelegate(this.frmFinancialYear_DataRefresh);
            this.Load += new System.EventHandler(this.FinancialYear_Load);
            this.Controls.SetChildIndex(this.dgrdFinancialYear, 0);
            this.Controls.SetChildIndex(this.txtYearName, 0);
            this.Controls.SetChildIndex(this.lbl_YearName, 0);
            this.Controls.SetChildIndex(this.chkIsDefault, 0);
            this.Controls.SetChildIndex(this.chkIsClosed, 0);
            this.Controls.SetChildIndex(this.lblYearBegin, 0);
            this.Controls.SetChildIndex(this.lblYearEnd, 0);
            this.Controls.SetChildIndex(this.dtbYearBegin, 0);
            this.Controls.SetChildIndex(this.dtbYearEnd, 0);
            this.Controls.SetChildIndex(this.txtPrefix, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgrdFinancialYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrdFinancialYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmYearID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmYearName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmYearBegin;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmYearEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIsDefualt;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIsClosed;
        private Controls.TextBox txtYearName;
        private Controls.Label lbl_YearName;
        private Controls.CheckBox chkIsDefault;
        private Controls.CheckBox chkIsClosed;
        private Controls.Label lblYearBegin;
        private Controls.Label lblYearEnd;
        private System.Windows.Forms.DateTimePicker dtbYearBegin;
        private System.Windows.Forms.DateTimePicker dtbYearEnd;
        private Controls.Label label1;
        private Controls.TextBox txtPrefix;
    }
}