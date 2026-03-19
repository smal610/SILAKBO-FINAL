using System;
using System.Windows.Forms;
using SILAKBO_FINAL.SILAKBO.DAL;
using SILAKBO_FINAL.SILAKBO.Models;

namespace SILAKBO_FINAL.SILAKBO.Forms
{
    public partial class AdminDashboard : Form
    {
        private ReportRepository reportRepo = new ReportRepository();

        public AdminDashboard()
        {
            InitializeComponent();
            LoadAllReports(); // auto-load when form opens
        }

        // 🔹 Load all reports into DataGridView
        private void LoadAllReports()
        {
            try
            {
                dgvReports.DataSource = reportRepo.GetReportsByUser(0);
                // 0 = get ALL reports (as we defined earlier)
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading reports: " + ex.Message);
            }
        }

        // 🔹 Refresh Button
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadAllReports();
        }
    }
}