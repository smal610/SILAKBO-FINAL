using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SILAKBO_FINAL.SILAKBO.Models;
using System.Xml.Linq;


namespace SILAKBO_FINAL.SILAKBO.Forms
{
    public partial class RegisterForm : Form
    {
        private AuthService authService = new AuthService();

        public RegisterForm()
        {
            InitializeComponent();
            comboGender.Items.Add("Female");
            comboGender.SelectedIndex = 0;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForms().Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //VALIDATION (ALL REQUIRED)
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                comboGender.SelectedItem == null)
            {
                MessageBox.Show("Please fill up all fields!", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                User user = new User
                {
                    Name = txtName.Text.Trim(),
                    Username = txtUsername.Text.Trim(),
                    Password = txtPassword.Text.Trim(),
                    Gender = comboGender.SelectedItem.ToString(),
                    Birthday = dtpBirthday.Value,
                    Role = "User"
                };

                authService.Register(user);

                MessageBox.Show("Registration successful!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                new LoginForms().Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving to database:\n" + ex.Message);
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
}
