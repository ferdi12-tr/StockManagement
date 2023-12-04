using StockManagement.Controller;
using StockManagement.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagement.Pages
{
    public partial class ProductAdd : Form
    {
        ProductCrud _productCrud = new ProductCrud();
        CategoryCrud _categoryCrud = new CategoryCrud();    
        public ProductAdd()
        {
            InitializeComponent();
        }

        private void ProductAdd_Load(object sender, EventArgs e)
        {
            InfoLbl.Visible = false;
            CategoryToCb();
        }

        private void CategoryToCb()
        {
            CategoryCb.DataSource = _categoryCrud.GetAll();
            CategoryCb.DisplayMember = "Name";
            CategoryCb.ValueMember = "Id";
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Product product = new Product();

            product.Name = NameTxt.Text;
            product.Description = DescriptionTxt.Text;
            product.Price = Convert.ToDouble(PriceTxt.Text);
            product.Stock = Convert.ToInt32(StockTxt.Text);
            product.CategoryId = Convert.ToInt32(CategoryCb.SelectedValue);
            product.IsStatus = StatusCb.Checked;

            
            product.Image = Utils.Utils.GetImagePath(ProductPb);


            var check = _productCrud.Add(product);

            InfoLbl.Visible= true;
            InfoLbl.Text = check ? "Product Added" : "Cannot Add Product";

            Utils.Utils.ClearAllTextBox(new List<TextBox>() { NameTxt, DescriptionTxt, PriceTxt, StockTxt });
            ProductPb.Image = null;
            StatusCb.Checked = false;

        }

        private void SelectImageBtn_Click(object sender, EventArgs e)
        {
            Utils.Utils.UploadImage(ProductPb);
        }

        private void ProductAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((ProductManagementForm)Application.OpenForms["ProductManagementForm"]).RefreshDGV();
        }
    }
}
