using StockManagement.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagement
{
    public partial class AdminMain : Form
    {
        public AdminMain()
        {
            InitializeComponent();
        }

        private void AdminMain_Load(object sender, EventArgs e)
        {
            
        }

        private void ProductManagementBtn_Click(object sender, EventArgs e)
        {
            new ProductManagementForm().ShowDialog();
        }

        private void CustomerManagementBtn_Click(object sender, EventArgs e)
        {
            new CostumerManagementForm().ShowDialog();  
        }

        private void SalesReportBtn_Click(object sender, EventArgs e)
        {
            new SalesReportForm().ShowDialog(); 
        }
    }
}
