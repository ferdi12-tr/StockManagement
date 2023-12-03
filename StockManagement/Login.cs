using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using StockManagement.Controller;

namespace StockManagement
{
    public partial class Login : Form
    {
        UserCrud _userCrud = new UserCrud();
        RoleCrud _roleCrud = new RoleCrud();    
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoginStatusLbl.Visible=false;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            var email = EmailTxt.Text.Trim();
            var password = PasswordTxt.Text.Trim();

            var user = _userCrud.GetAll().Find(x => x.Email == email && x.Password == password);
            if (user == null) 
            {
                LoginStatusLbl.Visible = true;
                LoginStatusLbl.Text = "Cannot Login, Check Email or Password";
            }
            else
            {
                Utils.Utils.SetCurrentUser(user);
                var role = _roleCrud.GetById(user.RoleId);
                if (role != null)
                {
                    if (role.Name == "Admin")
                    {
                        new AdminMain().Show();
                    }
                    else if (role.Name == "Customer")
                    {
                        new UserMain().Show();
                    }
                }
            }

        }

    }
}
