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
    public partial class CustomerAdd : Form
    {
        UserCrud _userCrud = new UserCrud();
        RoleCrud _roleCrud = new RoleCrud();
        public CustomerAdd()
        {
            InitializeComponent();
        }

        private void CustomerAdd_Load(object sender, EventArgs e)
        {
            InfoLbl.Visible = false;
            RoleToCb();
        }

        private void RoleToCb()
        {
            RoleCb.DataSource = _roleCrud.GetAll();
            RoleCb.DisplayMember = "Name";
            RoleCb.ValueMember = "Id";
        }

        private void SelectImageBtn_Click(object sender, EventArgs e)
        {
            Utils.Utils.UploadImage(CustomerPb);
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            User user = new User();

            user.Name = NameTxt.Text;
            user.Surname = SurnameTxt.Text;
            user.Description = DescriptionTxt.Text;
            user.RoleId = Convert.ToInt32(RoleCb.SelectedValue);
            user.Email = EmailTxt.Text;
            user.Password = PasswordTxt.Text;
            user.Image = Utils.Utils.GetImagePath(CustomerPb);

            var check = _userCrud.Add(user);
            InfoLbl.Visible = true;
            InfoLbl.Text = check ? "User Added" : "Cannot Add User";

            Utils.Utils.ClearAllTextBox(new List<TextBox> { NameTxt, SurnameTxt, DescriptionTxt, EmailTxt, PasswordTxt });
            CustomerPb.Image = null;
            StatusCb.Checked = false;
        }

        private void CustomerAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((CustomerManagementForm)Application.OpenForms["CustomerManagementForm"]).RefreshDGV();
        }
    }
}
