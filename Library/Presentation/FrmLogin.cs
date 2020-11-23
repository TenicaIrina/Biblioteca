using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.cache;
using Domain;

namespace Presentation
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text != "Username")
            {
                if(txtpass.Text != "Password")
                {
                    UserModel user = new UserModel();
                    var validition = user.LoginUser(txtUser.Text, txtpass.Text);//declaram o variabila cacreia ii asignam valoarea din metota din Domain
                    if (validition == true)// daca userul exista
                    {
                        if (UserLoginCache.Position == RoleUsers.Administrator)
                        {
                            MainAdmin mainmenu = new MainAdmin();
                            mainmenu.Show();
                            mainmenu.FormClosed += Logout;
                            this.Hide();
                        }
                        if (UserLoginCache.Position == RoleUsers.Utilizator)
                        {
                            MainUser mainmenuUser = new MainUser();
                            mainmenuUser.Show();
                            mainmenuUser.FormClosed += Logout;
                            this.Hide();
                        }
                    }
                    else
                    {
                        msgError("Please verify the username and password");
                        txtpass.Clear();
                        txtUser.Focus();
                    }
                }
                else msgError("Please enter your password");
            }
            else msgError("Please enter your username");
        }
        private void msgError(string msg)
        {
            lblError.Text = "    " + msg;
            lblError.Visible = true;

        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "Username")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.DarkGray;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "Username";
                txtUser.ForeColor = Color.Silver;
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "Password")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.DarkGray;
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "Password";
                txtpass.ForeColor = Color.Silver;
                txtpass.UseSystemPasswordChar = false;
            }
        }

        private void Logout(object sender, FormClosedEventArgs e)
        { 
            txtUser.Clear();
            lblError.Visible = false;
            this.Show();
            txtUser.Focus();
        }
    }
}
