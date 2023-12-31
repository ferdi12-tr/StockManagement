﻿using StockManagement.Controller;
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
    public partial class CustomerManagementForm : Form
    {
        UserCrud _userCrud = new UserCrud();
        RoleCrud _roleCrud = new RoleCrud();    
        public CustomerManagementForm()
        {
            InitializeComponent();
        }

        private void CostumerManagementForm_Load(object sender, EventArgs e)
        {
            CustomerDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            RefreshDGV();
        }

        public void RefreshDGV()
        {

            CustomerDgv.DataSource  = _userCrud.GetAll();
            CustomerDgv.Columns["RoleId"].Visible = false;
            CustomerDgv.Columns["Id"].Visible = false;
            CustomerDgv.Columns["Image"].Visible = false;
            CustomerDgv.ClearSelection();
        }

        private void DetailBtn_Click(object sender, EventArgs e)
        {
            if (CustomerDgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user from list");
                return;
            }
            var selectedId = CustomerDgv.SelectedRows[0].Cells["Id"].Value;
            int id = Convert.ToInt32(selectedId);
            new CustomerDetail(id).ShowDialog();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            new CustomerAdd().ShowDialog();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (CustomerDgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user from list");
                return;
            }

            var selectedId = CustomerDgv.SelectedRows[0].Cells["Id"].Value;
            DialogResult result = MessageBox.Show(
                    $"Are you sure to delete {CustomerDgv.SelectedRows[0].Cells["Name"].Value}",
                    "Delete !"
                    , MessageBoxButtons.YesNo
                    , MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                _userCrud.Delete(Convert.ToInt32(selectedId));
                RefreshDGV();
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (CustomerDgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user from list");
                return;
            }
            var selectedId = CustomerDgv.SelectedRows[0].Cells["Id"].Value;
            int id = Convert.ToInt32(selectedId);
            new CustomerUpdate(id).ShowDialog();
        }
    }
}
