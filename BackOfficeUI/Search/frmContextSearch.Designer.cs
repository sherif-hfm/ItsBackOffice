namespace BackOfficeUI.Search
{
    partial class frmContextSearch
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
            this.textBoxSearch = new BackOfficeUI.Controls.TextBox();
            this.grdResult = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdResult)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.Color.White;
            this.textBoxSearch.Clearable = true;
            this.textBoxSearch.ContextSearchId = 0;
            this.textBoxSearch.IsRequired = false;
            this.textBoxSearch.Location = new System.Drawing.Point(12, 12);
            this.textBoxSearch.LockedInModes = 25;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(466, 20);
            this.textBoxSearch.TabIndex = 0;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // grdResult
            // 
            this.grdResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdResult.Location = new System.Drawing.Point(12, 50);
            this.grdResult.Name = "grdResult";
            this.grdResult.Size = new System.Drawing.Size(466, 211);
            this.grdResult.TabIndex = 1;
            this.grdResult.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdResult_KeyDown);
            // 
            // frmContextSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 271);
            this.Controls.Add(this.grdResult);
            this.Controls.Add(this.textBoxSearch);
            this.Name = "frmContextSearch";
            this.Text = "frmContextSearch";
            this.Load += new System.EventHandler(this.frmContextSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BackOfficeUI.Controls.TextBox textBoxSearch;
        private System.Windows.Forms.DataGridView grdResult;
    }
}