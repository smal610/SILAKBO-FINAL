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

        //public MyProfileForm(User currentUser)
        //{
        //    InitializeComponent();
        //    user = currentUser;
        //    txtName.Text = user.Name;
        //    txtUsername.Text = user.Username;
        //    txtGender.Text = user.Gender;
        //    txtBirthday.Text = user.Birthday.ToShortDateString();
        //    txtRole.Text = user.Role;
        //}

        public MyProfileForm(User currentUser)
        {
            InitializeComponent();
            user = currentUser;
            lblName.Text = user.Name;
            lblUsername.Text = user.Username;
            lblGender.Text = user.Gender;
            lblBirthday.Text = user.Birthday.ToShortDateString();
            lblRole.Text = user.Role;
        }

        private void btnClose_Click(object sender, EventArgs e) => this.Close();
    }
}
