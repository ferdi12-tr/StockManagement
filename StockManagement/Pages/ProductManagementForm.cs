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
    public partial class ProductManagementForm : Form
    {
        ProductCrud _productCrud = new ProductCrud();
        CategoryCrud _categoryCrud = new CategoryCrud();
        public ProductManagementForm()
        {
            InitializeComponent();
        }

        private void ProductManagementForm_Load(object sender, EventArgs e)
        {
            ProductDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            RefreshDGV();
        }

        public void RefreshDGV()
        {
            var products = _productCrud.GetAll();

            ProductDgv.DataSource = products;
            ProductDgv.Columns["CategoryId"].Visible = false;
            ProductDgv.Columns["Id"].Visible = false;
            ProductDgv.ClearSelection();
        }

        private void DetailBtn_Click(object sender, EventArgs e)
        {
            if (ProductDgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product from list");
                return;
            }
            var selectedId = ProductDgv.SelectedRows[0].Cells["Id"].Value;
            int id = Convert.ToInt32(selectedId);
            new ProductDetail(id).ShowDialog();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            new ProductAdd().ShowDialog();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (ProductDgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product from list");
                return;
            }
            var selectedId = ProductDgv.SelectedRows[0].Cells["Id"].Value;
            DialogResult result =  MessageBox.Show(
                    $"Are you sure to delete {ProductDgv.SelectedRows[0].Cells["Name"].Value}",
                    "Delete !"
                    ,MessageBoxButtons.YesNo
                    ,MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                _productCrud.Delete(Convert.ToInt32(selectedId));
                RefreshDGV();
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            var selectedId = ProductDgv.SelectedRows[0].Cells["Id"].Value;
            if (ProductDgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product from list");
                return;
            }
            int id = Convert.ToInt32(selectedId);
            new ProductUpdate(id).ShowDialog();
        }
    }
}
