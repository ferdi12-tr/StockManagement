using StockManagement.Controller;
using StockManagement.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagement.Pages
{
    public partial class CustomerUpdate : Form
    {
        RoleCrud _roleCrud = new RoleCrud();
        UserCrud _userCrud = new UserCrud();
        int _selectedId;
        public CustomerUpdate(int id)
        {
            InitializeComponent();
            _selectedId = id;
        }

        private void CustomerUpdate_Load(object sender, EventArgs e)
        {
            InfoLbl.Visible = false;
            RoleToCb();
            FillPreviousValue();
        }

        private void RoleToCb()
        {
            RoleCb.DataSource = _roleCrud.GetAll();
            RoleCb.DisplayMember = "Name";
            RoleCb.ValueMember = "Id";
        }

        private void FillPreviousValue()
        {
            var user = _userCrud.GetById(_selectedId);
            NameTxt.Text = user.Name;
            SurnameTxt.Text = user.Surname;
            DescriptionTxt.Text = user.Description; 
            EmailTxt.Text = user.Email;
            PasswordTxt.Text = user.Password;
            StatusCb.Checked = user.IsStatus;
            CustomerPb.ImageLocation = user.Image;
        }

        private void ChangeImageBtn_Click(object sender, EventArgs e)
        {
            Utils.Utils.UploadImage(CustomerPb);
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            User user = new User
            {
                Name = NameTxt.Text,
                Surname = SurnameTxt.Text,
                RoleId = Convert.ToInt32(RoleCb.SelectedValue),
                Description = DescriptionTxt.Text,
                Email = EmailTxt.Text,
                Password = PasswordTxt.Text,
                IsStatus = StatusCb.Checked,
                Image = Utils.Utils.GetImagePath(CustomerPb)
            };

            var check = _userCrud.Update(user, _selectedId);
            InfoLbl.Visible = true;
            InfoLbl.Text = check ? "User Updated" : "Cannot Update User";

            Utils.Utils.ClearAllTextBox(new List<TextBox> { NameTxt, SurnameTxt, DescriptionTxt, EmailTxt, PasswordTxt });
            CustomerPb.Image = null;
            StatusCb.Checked = false;
        }

        private void CustomerUpdate_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((CustomerManagementForm)Application.OpenForms["CustomerManagementForm"]).RefreshDGV();
        }
    } 
}
