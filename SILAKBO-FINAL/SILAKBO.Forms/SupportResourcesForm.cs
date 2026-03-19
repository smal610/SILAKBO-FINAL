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
        private SupportRepository repo = new SupportRepository();

        public SupportResourcesForm()
        {
            InitializeComponent();
            LoadSupportResources();
        }

        private void LoadSupportResources()
        {
            try
            {
                dgvSupport.DataSource = repo.GetAllResources();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading resources:\n" + ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadSupportResources();
        }
    }
}
