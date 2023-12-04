namespace StockManagement.Pages
{
    partial class BasketList
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
            this.BasketDgv = new System.Windows.Forms.DataGridView();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.BuyAllBtn = new System.Windows.Forms.Button();
            this.InfoLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BasketDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // BasketDgv
            // 
            this.BasketDgv.AllowUserToAddRows = false;
            this.BasketDgv.AllowUserToDeleteRows = false;
            this.BasketDgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.BasketDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BasketDgv.Location = new System.Drawing.Point(13, 13);
            this.BasketDgv.Name = "BasketDgv";
            this.BasketDgv.ReadOnly = true;
            this.BasketDgv.RowHeadersWidth = 51;
            this.BasketDgv.RowTemplate.Height = 24;
            this.BasketDgv.Size = new System.Drawing.Size(944, 281);
            this.BasketDgv.TabIndex = 0;
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Location = new System.Drawing.Point(306, 330);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(147, 46);
            this.RemoveBtn.TabIndex = 1;
            this.RemoveBtn.Text = "Remove Order";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // BuyAllBtn
            // 
            this.BuyAllBtn.Location = new System.Drawing.Point(496, 330);
            this.BuyAllBtn.Name = "BuyAllBtn";
            this.BuyAllBtn.Size = new System.Drawing.Size(153, 46);
            this.BuyAllBtn.TabIndex = 3;
            this.BuyAllBtn.Text = "Buy All";
            this.BuyAllBtn.UseVisualStyleBackColor = true;
            this.BuyAllBtn.Click += new System.EventHandler(this.BuyAllBtn_Click);
            // 
            // InfoLbl
            // 
            this.InfoLbl.AutoSize = true;
            this.InfoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.InfoLbl.Location = new System.Drawing.Point(301, 426);
            this.InfoLbl.Name = "InfoLbl";
            this.InfoLbl.Size = new System.Drawing.Size(64, 25);
            this.InfoLbl.TabIndex = 4;
            this.InfoLbl.Text = "label1";
            // 
            // BasketList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 493);
            this.Controls.Add(this.InfoLbl);
            this.Controls.Add(this.BuyAllBtn);
            this.Controls.Add(this.RemoveBtn);
            this.Controls.Add(this.BasketDgv);
            this.Name = "BasketList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BasketList";
            this.Load += new System.EventHandler(this.BasketList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BasketDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView BasketDgv;
        private System.Windows.Forms.Button RemoveBtn;
        private System.Windows.Forms.Button BuyAllBtn;
        private System.Windows.Forms.Label InfoLbl;
    }
}