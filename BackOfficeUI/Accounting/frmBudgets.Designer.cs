namespace BackOfficeUI.Accounting
{
    partial class frmBudgets
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
            this.dgrdBudget = new System.Windows.Forms.DataGridView();
            this.clmBudgetId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEnglishName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmArName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIsDisabled = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdBudget)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrdBudget
            // 
            this.dgrdBudget.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrdBudget.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmBudgetId,
            this.clmEnglishName,
            this.clmArName,
            this.clmYear,
            this.clmIsDisabled});
            this.dgrdBudget.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgrdBudget.Location = new System.Drawing.Point(0, 44);
            this.dgrdBudget.MultiSelect = false;
            this.dgrdBudget.Name = "dgrdBudget";
            this.dgrdBudget.ReadOnly = true;
            this.dgrdBudget.RowHeadersVisible = false;
            this.dgrdBudget.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrdBudget.Size = new System.Drawing.Size(859, 150);
            this.dgrdBudget.TabIndex = 2;
            this.dgrdBudget.SelectionChanged += new System.EventHandler(this.dgrdBudget_SelectionChanged);
            // 
            // clmBudgetId
            // 
            this.clmBudgetId.HeaderText = "";
            this.clmBudgetId.Name = "clmBudgetId";
            this.clmBudgetId.ReadOnly = true;
            this.clmBudgetId.Visible = false;
            this.clmBudgetId.Width = 5;
            // 
            // clmEnglishName
            // 
            this.clmEnglishName.HeaderText = "English Name";
            this.clmEnglishName.Name = "clmEnglishName";
            this.clmEnglishName.ReadOnly = true;
            this.clmEnglishName.Width = 180;
            // 
            // clmArName
            // 
            this.clmArName.HeaderText = "Arabic Name";
            this.clmArName.Name = "clmArName";
            this.clmArName.ReadOnly = true;
            this.clmArName.Width = 180;
            // 
            // clmYear
            // 
            this.clmYear.HeaderText = "Budget Year";
            this.clmYear.Name = "clmYear";
            this.clmYear.ReadOnly = true;
            this.clmYear.Width = 140;
            // 
            // clmIsDisabled
            // 
            this.clmIsDisabled.HeaderText = "Is Disabled";
            this.clmIsDisabled.Name = "clmIsDisabled";
            this.clmIsDisabled.ReadOnly = true;
            // 
            // frmBudgets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 401);
            this.Controls.Add(this.dgrdBudget);
            this.Name = "frmBudgets";
            this.Text = "frmBudgets";
            this.Controls.SetChildIndex(this.dgrdBudget, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgrdBudget)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrdBudget;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBudgetId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEnglishName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmArName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIsDisabled;
    }
}