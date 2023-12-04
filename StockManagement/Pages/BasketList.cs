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
    public partial class BasketList : Form
    {
        OrderCrud _orderCrud = new OrderCrud();
        ProductCrud _productCrud = new ProductCrud();   
        UserCrud _userCrud = new UserCrud();
        SellCrud _sellCrud = new SellCrud();

        
        public BasketList()
        {
            InitializeComponent();
        }

        private void BasketList_Load(object sender, EventArgs e)
        {
                BasketDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                RefreshDGV();
        }

        public void RefreshDGV()
        {
            double _totalAmount = 0;
            var allOrdersInfo = new List<Order>();
            var orders = _orderCrud.GetAll();

            foreach (var order in orders)
            {
                var product = _productCrud.GetById(order.ProductId);
                var user = _userCrud.GetById(order.UserId);
                Order ord = new Order()
                {
                    Id = order.Id,
                    UserName = user.Name,
                    ProductName = product.Name,
                    OrderDateTime = order.OrderDateTime,
                    İsDelete = order.İsDelete,
                    Quantity = order.Quantity,
                    TotalPayAmount = product.Price * order.Quantity
                };
                allOrdersInfo.Add(ord);
                _totalAmount += ord.TotalPayAmount;
            }

            InfoLbl.Text = $"{_totalAmount} $ total basket price for {allOrdersInfo.Count} product.";

            BasketDgv.DataSource = allOrdersInfo;
            BasketDgv.Columns["Id"].Visible = false;
            BasketDgv.Columns["İsDelete"].Visible = false;
            BasketDgv.Columns["ProductId"].Visible = false;
            BasketDgv.Columns["UserId"].Visible = false;
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            var selectedId = BasketDgv.SelectedRows[0].Cells["Id"].Value;
            if (selectedId == null)
            {
                MessageBox.Show("Please select a product from list");
                return;
            }
            int id = Convert.ToInt32(selectedId);
            var check = _orderCrud.Delete(id);
            MessageBox.Show(check ? "Order Removed" : "Cannot Remove Order");
            RefreshDGV();
        }

        private void BuyAllBtn_Click(object sender, EventArgs e)
        {
            var orders = _orderCrud.GetAll();
            foreach (var order in orders)
            {
                SellProduct sellProduct = new SellProduct()
                {
                    OrderId = order.Id,
                    ProductId = order.ProductId,
                    IsDelete = false,
                };
                _orderCrud.Delete(order.Id);
                var check = _sellCrud.Add(sellProduct);

                MessageBox.Show(check ? "Successfully Sold" : "Cannot Sell");
                RefreshDGV();
            }
        }
    }
}
