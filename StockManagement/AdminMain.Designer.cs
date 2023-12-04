namespace StockManagement
{
    partial class AdminMain
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
            this.ProductManagementBtn = new System.Windows.Forms.Button();
            this.CustomerManagementBtn = new System.Windows.Forms.Button();
            this.SalesReportBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductManagementBtn
            // 
            this.ProductManagementBtn.Location = new System.Drawing.Point(39, 24);
            this.ProductManagementBtn.Name = "ProductManagementBtn";
            this.ProductManagementBtn.Size = new System.Drawing.Size(224, 110);
            this.ProductManagementBtn.TabIndex = 0;
            this.ProductManagementBtn.Text = "Product Management";
            this.ProductManagementBtn.UseVisualStyleBackColor = true;
            this.ProductManagementBtn.Click += new System.EventHandler(this.ProductManagementBtn_Click);
            // 
            // CustomerManagementBtn
            // 
            this.CustomerManagementBtn.Location = new System.Drawing.Point(39, 188);
            this.CustomerManagementBtn.Name = "CustomerManagementBtn";
            this.CustomerManagementBtn.Size = new System.Drawing.Size(224, 110);
            this.CustomerManagementBtn.TabIndex = 1;
            this.CustomerManagementBtn.Text = "Customer Management";
            this.CustomerManagementBtn.UseVisualStyleBackColor = true;
            this.CustomerManagementBtn.Click += new System.EventHandler(this.CustomerManagementBtn_Click);
            // 
            // SalesReportBtn
            // 
            this.SalesReportBtn.Location = new System.Drawing.Point(39, 362);
            this.SalesReportBtn.Name = "SalesReportBtn";
            this.SalesReportBtn.Size = new System.Drawing.Size(224, 110);
            this.SalesReportBtn.TabIndex = 2;
            this.SalesReportBtn.Text = "Sales Reports";
            this.SalesReportBtn.UseVisualStyleBackColor = true;
            this.SalesReportBtn.Click += new System.EventHandler(this.SalesReportBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SalesReportBtn);
            this.panel1.Controls.Add(this.ProductManagementBtn);
            this.panel1.Controls.Add(this.CustomerManagementBtn);
            this.panel1.Location = new System.Drawing.Point(609, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 501);
            this.panel1.TabIndex = 3;
            // 
            // AdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1485, 737);
            this.Controls.Add(this.panel1);
            this.Name = "AdminMain";
            this.Text = "AdminMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminMain_Load);
            this.SizeChanged += new System.EventHandler(this.AdminMain_SizeChanged);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ProductManagementBtn;
        private System.Windows.Forms.Button CustomerManagementBtn;
        private System.Windows.Forms.Button SalesReportBtn;
        private System.Windows.Forms.Panel panel1;
    }
}