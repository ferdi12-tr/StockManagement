namespace StockManagement.Pages
{
    partial class SalesReportForm
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
            this.ReportDgv = new System.Windows.Forms.DataGridView();
            this.RefreshBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ReportDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // ReportDgv
            // 
            this.ReportDgv.AllowUserToAddRows = false;
            this.ReportDgv.AllowUserToDeleteRows = false;
            this.ReportDgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ReportDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReportDgv.Location = new System.Drawing.Point(36, 26);
            this.ReportDgv.Name = "ReportDgv";
            this.ReportDgv.ReadOnly = true;
            this.ReportDgv.RowHeadersWidth = 51;
            this.ReportDgv.RowTemplate.Height = 24;
            this.ReportDgv.Size = new System.Drawing.Size(1039, 276);
            this.ReportDgv.TabIndex = 0;
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Location = new System.Drawing.Point(437, 373);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(213, 70);
            this.RefreshBtn.TabIndex = 1;
            this.RefreshBtn.Text = "Refresh Reports";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // SalesReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 728);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.ReportDgv);
            this.Name = "SalesReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalesReportForm";
            this.Load += new System.EventHandler(this.SalesReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReportDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ReportDgv;
        private System.Windows.Forms.Button RefreshBtn;
    }
}