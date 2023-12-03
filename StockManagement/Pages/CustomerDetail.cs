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
    public partial class CustomerDetail : Form
    {
        UserCrud _userCrud = new UserCrud();
        RoleCrud _roleCrud = new RoleCrud();    
        int _selectedId;
        public CustomerDetail(int id)
        {
            InitializeComponent();
            _selectedId = id;
        }

        private void CustomerDetail_Load(object sender, EventArgs e)
        {
            var user = _userCrud.GetById(_selectedId);
            var role = _roleCrud.GetById(user.RoleId);

            CustomerPb.ImageLocation = user.Image;
            NameLbl.Text = user.Name;   
            SurnameLbl.Text = user.Surname;
            RoleLbl.Text = role.Name;
            DescriptionLbl.Text = user.Description; 
            EmailLbl.Text = user.Email;
            PasswordLbl.Text = user.Password;   
            StatusLbl.Text = user.IsStatus ? "Aktif" : "Pasif";
        }
    }
}
