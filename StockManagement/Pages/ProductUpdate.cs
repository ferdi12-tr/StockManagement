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
    public partial class ProductUpdate : Form
    {
        ProductCrud _productCrud = new ProductCrud();
        CategoryCrud _categoryCrud = new CategoryCrud();    
        int _selectedId;
        public ProductUpdate(int id)
        {
            InitializeComponent();
            _selectedId = id;
        }

        private void ProductUpdate_Load(object sender, EventArgs e)
        {
            InfoLbl.Visible = false;
            CategoryToCb();
            FillPreviousValue();
        }

        private void CategoryToCb()
        {
            CategoryCb.DataSource = _categoryCrud.GetAll();
            CategoryCb.DisplayMember = "Name";
            CategoryCb.ValueMember = "Id";
        }
        private void FillPreviousValue()
        {
            var product = _productCrud.GetById(_selectedId);

            NameTxt.Text = product.Name;
            DescriptionTxt.Text = product.Description;
            CategoryCb.SelectedValue = product.CategoryId;
            PriceTxt.Text = product.Price.ToString();
            StockTxt.Text = product.Stock.ToString();
            StatusCb.Checked = product.IsStatus;
            ProductPb.ImageLocation = product.Image;

        }

        private void ChangeImageBtn_Click(object sender, EventArgs e)
        {
            Utils.Utils.UploadImage(ProductPb);
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            Product product = new Product();

            product.Name = NameTxt.Text;
            product.Description = DescriptionTxt.Text;
            product.Price = Convert.ToDouble(PriceTxt.Text);
            product.Stock = Convert.ToInt32(StockTxt.Text);
            product.CategoryId = Convert.ToInt32(CategoryCb.SelectedValue);
            product.IsStatus = StatusCb.Checked;
            
            product.Image = Utils.Utils.GetImagePath(ProductPb);

            var check = _productCrud.Update(product, _selectedId);
            InfoLbl.Visible = true;
            InfoLbl.Text = check ? "Product Updated" : "Cannot Update Product";
            
            NameTxt.Clear();
            DescriptionTxt.Clear();
            PriceTxt.Clear();
            StockTxt.Clear();
            ProductPb.Image = null;
            StatusCb.Checked = false;
        }

        private void ProductUpdate_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((ProductManagementForm)Application.OpenForms["ProductManagementForm"]).RefreshDGV();
        }
    }
}
