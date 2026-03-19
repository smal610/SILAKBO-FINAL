using SILAKBO_FINAL.SILAKBO.Models;

namespace SILAKBO_FINAL.SILAKBO.Forms
{
    public partial class AdminDashboard : Form
    {
        private ReportRepository reportRepo = new ReportRepository();

        public AdminDashboard()
        {
            InitializeComponent();
            dgvReports.SelectionChanged += dgvReports_SelectionChanged;
            btnUpdateStatus.Click += btnUpdateStatus_Click;

            // Optionally, fill ComboBox items
            comboStatus.Items.AddRange(new string[] { "Pending", "Ongoing", "Completed" });
            comboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
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

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (dgvReports.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a case to update.");
                return;
            }

            if (comboStatus.SelectedItem == null)
            {
                MessageBox.Show("Please select a status.");
                return;
            }

            int reportID = Convert.ToInt32(dgvReports.SelectedRows[0].Cells["ReportID"].Value);
            string newStatus = comboStatus.SelectedItem.ToString();

            try
            {
                reportRepo.UpdateReportStatus(reportID, newStatus);
                MessageBox.Show("Case status updated successfully!");
                LoadAllReports(); // Refresh DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating case: " + ex.Message);
            }
        }

        private void dgvReports_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvReports.SelectedRows.Count > 0)
            {
                string currentStatus = dgvReports.SelectedRows[0].Cells["Status"].Value.ToString();
                comboStatus.SelectedItem = currentStatus;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Logout Successful!", "Logged Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoginForms login = new LoginForms();
                login.Show();
                this.Close();
            }
        }
    }
}