using StockManagement.Controller;
using StockManagement.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagement.Pages
{
    public partial class ProductList : Form
    {
        ProductCrud _productCrud = new ProductCrud();
        CategoryCrud _categoryCrud = new CategoryCrud();
        OrderCrud _orderCrud = new OrderCrud();
        SellCrud _sellCrud = new SellCrud();

        GroupBox productGb;
        PictureBox productPicture;
        NumericUpDown amount;
        Button addBasketBtn;
        Label amountLabel;
        public ProductList()
        {
            InitializeComponent();
        }

        private void ProductList_Load(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            DisplayProductCard();
        }

        private void ProductList_SizeChanged(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            DisplayProductCard();
        }

        public void DisplayProductCard()
        {
            int xStart = 20;
            int yStart = 20;
            int i = 0;
            int step = 170;
            int panelWidth = panel2.Width - xStart;
            int productGbCount = (panelWidth - (panelWidth % step)) / step;

            foreach (var product in _productCrud.GetAll())
            {
                if (i == productGbCount)
                {
                    yStart += step + 90;
                    i = 0;
                }

                productGb = new GroupBox()
                {
                    Name = "ProductGb_" + product.Id,
                    Text = product.Name,
                    Size = new Size(150, 240),
                    BackColor = Color.White,
                    Location = new Point(xStart + (step * i), yStart),

                };

                productPicture = new PictureBox()
                {
                    Name = "ProductImgPb_" + product.Id,
                    ImageLocation = product.Image,
                    Size = new Size(120, 120),
                    Location = new Point(15, 25),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                };

                amount = new NumericUpDown()
                {
                    Name = "Amount_" + product.Id,
                    Text = product.Name,
                    Size = new Size(60, 40),
                    Location = new Point(80, 155),
                    Maximum = product.Stock
                };

                amountLabel = new Label()
                {
                    Name = "AmountLabel_" + product.Id,
                    Text = "Amount:",
                    Size = new Size(80, 40),
                    Location = new Point(15, 157),
                };

                addBasketBtn = new Button()
                {
                    Name = "UserDetail_" + product.Id,
                    Text = "Add Basket",
                    Location = new Point(15, 185),
                    Size = new Size(120, 40),
                    FlatStyle = FlatStyle.Popup,
                    BackColor = Color.DarkOliveGreen,
                    ForeColor = Color.White,
                };

                addBasketBtn.Click += AddBasket_Click;

                productGb.Controls.Add(addBasketBtn);
                productGb.Controls.Add(amount);
                productGb.Controls.Add(productPicture);
                productGb.Controls.Add(amountLabel);
                panel2.Controls.Add(productGb);
                i++;

            }
        }

        private void AddBasket_Click(object sender, EventArgs e)
        {
            Button btn = ((Button)sender);
            string[] btnId = btn.Name.Split('_');
            int productId = Convert.ToInt32(btnId[btnId.Length - 1]);
            var amountNud = panel2.Controls.Find("Amount_" + productId, true).First();
            var amount = ((NumericUpDown)amountNud).Value;

            var currentUser = Utils.Utils.GetCurrentUser();
            var product = _productCrud.GetById(productId);

            Order order = new Order()
            {
                UserId = currentUser.Id,
                OrderDateTime = DateTime.Now,
                İsDelete = false,
                ProductId = product.Id,
                Quantity = Convert.ToInt32(amount)
            };

            var check = _orderCrud.Add(order);
            MessageBox.Show(check ? "Added to basket." : "Cannot add to basket.");
        }
    }
}
