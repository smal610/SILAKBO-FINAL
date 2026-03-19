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
    public partial class SupportResourcesForm : Form
    {
        private SupportRepository supportRepo = new SupportRepository();

        public SupportResourcesForm()
        {
            InitializeComponent();
            LoadContacts();
        }

        private void LoadContacts() => dgvSupport.DataSource = supportRepo.GetAllContacts();

        private void btnRefresh_Click(object sender, EventArgs e) => LoadContacts();
    }
}
