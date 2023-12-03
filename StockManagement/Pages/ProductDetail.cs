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
    public partial class ProductDetail : Form
    {
        ProductCrud _productCrud = new ProductCrud();
        CategoryCrud _categoryCrud = new CategoryCrud();

        int _selectedId;
        public ProductDetail(int id)
        {
            _selectedId = id;
            InitializeComponent();
        }

        private void ProductDetail_Load(object sender, EventArgs e)
        {


            var product = _productCrud.GetById(_selectedId);
            var category = _categoryCrud.GetById(product.CategoryId);

            ProductPb.ImageLocation = product.Image;
            NameLbl.Text = product.Name;
            CategoryLbl.Text = category.Name;
            DescriptionLbl.Text = product.Description;
            PriceLbl.Text = product.Price + " TL";
            StockLbl.Text = product.Stock + " Adet";
            StatusLbl.Text = product.IsStatus ? "Aktif" : "Pasif";
        }
    }
}
