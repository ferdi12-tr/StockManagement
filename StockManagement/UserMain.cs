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
    public partial class UserMain : Form
    {
        public UserMain()
        {
            InitializeComponent();
        }

        private void UserMain_Load(object sender, EventArgs e)
        {
            Utils.Utils.LocatePanelOnForm(this, panel1);
        }

        private void ProductListBtn_Click(object sender, EventArgs e)
        {
            new ProductList().ShowDialog();
        }

        private void BasketBtn_Click(object sender, EventArgs e)
        {
            new BasketList().ShowDialog();
        }

        private void UserMain_SizeChanged(object sender, EventArgs e)
        {
            Utils.Utils.LocatePanelOnForm(this, panel1);
        }
    }
}
