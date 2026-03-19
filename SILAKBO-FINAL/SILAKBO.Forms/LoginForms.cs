using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SILAKBO_FINAL.SILAKBO.Models;

namespace SILAKBO_FINAL.SILAKBO.Forms
{
    public partial class LoginForms : Form
    {
        private AuthService authService = new AuthService();

        public LoginForms()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            new RegisterForm().Show();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var user = authService.Login(txtUsername.Text.Trim(), txtPassword.Text.Trim());
            if (user != null)
            {
                this.Hide();
                if (user.Role == "Admin") new AdminDashboardForm(user).Show();
                else new UserDashboardForm(user).Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false; // show password
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true; // hide password
            }

        }
    }

    internal class AdminDashboardForm
    {
        private User user;

        public AdminDashboardForm(User user)
        {
            this.user = user;
        }

        internal void Show()
        {
            throw new NotImplementedException();
        }
    }
}
