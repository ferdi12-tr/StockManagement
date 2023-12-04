using StockManagement.Controller;
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
    public partial class SalesReportForm : Form
    {
        SellCrud _sellCrud = new SellCrud();
        ProductCrud _productCrud = new ProductCrud();
        OrderCrud _orderCrud = new OrderCrud();
        UserCrud _userCrud = new UserCrud();
        public SalesReportForm()
        {
            InitializeComponent();
        }

        private void SalesReportForm_Load(object sender, EventArgs e)
        {
            ReportDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ReportDgv.ColumnCount = 5;
            ReportDgv.Columns[0].Name = "User Name";
            ReportDgv.Columns[1].Name = "Product Name";
            ReportDgv.Columns[2].Name = "Quantity";
            ReportDgv.Columns[3].Name = "Price";
            ReportDgv.Columns[4].Name = "Total Amount";
            RefreshDGV();
        }

        private void RefreshDGV()
        {
            ReportDgv.Rows.Clear();
            var sells = _sellCrud.GetAll();
            foreach (var sell in sells)
            {
                var product = _productCrud.GetById(sell.ProductId);
                var order = _orderCrud.GetById(sell.OrderId);
                var user = _userCrud.GetById(order.UserId);

                ReportDgv.Rows.Add(new string[]
                {
                    user.Name,
                    product.Name,
                    product.Price.ToString(),
                    order.Quantity.ToString(),
                    (order.Quantity * product.Price).ToString()
                });
            }
            ReportDgv.ClearSelection();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            RefreshDGV();
        }
    }
}
