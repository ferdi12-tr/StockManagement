namespace StockManagement
{
    partial class UserMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BasketBtn = new System.Windows.Forms.Button();
            this.ProductListBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BasketBtn);
            this.panel1.Controls.Add(this.ProductListBtn);
            this.panel1.Location = new System.Drawing.Point(478, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 395);
            this.panel1.TabIndex = 0;
            // 
            // BasketBtn
            // 
            this.BasketBtn.Location = new System.Drawing.Point(22, 272);
            this.BasketBtn.Name = "BasketBtn";
            this.BasketBtn.Size = new System.Drawing.Size(224, 110);
            this.BasketBtn.TabIndex = 5;
            this.BasketBtn.Text = "Basket";
            this.BasketBtn.UseVisualStyleBackColor = true;
            this.BasketBtn.Click += new System.EventHandler(this.BasketBtn_Click);
            // 
            // ProductListBtn
            // 
            this.ProductListBtn.Location = new System.Drawing.Point(22, 12);
            this.ProductListBtn.Name = "ProductListBtn";
            this.ProductListBtn.Size = new System.Drawing.Size(224, 110);
            this.ProductListBtn.TabIndex = 4;
            this.ProductListBtn.Text = "Product List";
            this.ProductListBtn.UseVisualStyleBackColor = true;
            this.ProductListBtn.Click += new System.EventHandler(this.ProductListBtn_Click);
            // 
            // UserMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 658);
            this.Controls.Add(this.panel1);
            this.Name = "UserMain";
            this.Text = "UserMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UserMain_Load);
            this.SizeChanged += new System.EventHandler(this.UserMain_SizeChanged);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BasketBtn;
        private System.Windows.Forms.Button ProductListBtn;
    }
}