using SILAKBO_FINAL.SILAKBO.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SILAKBO_FINAL.SILAKBO.Forms
{
    public partial class MyProfileForm : Form
    {
        private User user;

        public MyProfileForm(User currentUser)
        {
            InitializeComponent();
            user = currentUser;
            txtName.Text = user.Name;
            txtUsername.Text = user.Username;
            txtGender.Text = user.Gender;
            txtBirthday.Text = user.Birthday.ToShortDateString();
            txtRole.Text = user.Role;
        }

        private void btnClose_Click(object sender, EventArgs e) => this.Close();

        private void btnClose_Click_1(object sender, EventArgs e)
        {

        }
    }
}
