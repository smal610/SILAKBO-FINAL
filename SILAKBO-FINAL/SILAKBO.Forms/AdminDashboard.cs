using SILAKBO_FINAL.SILAKBO.Models;
using SILAKBO_FINAL.SILAKBO.Utils;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Text.Json;
using System.IO;

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
            //LoadAllReportsAsync(); // auto-load when form opens
            _ = LoadAllReportsAsync(); // async call
        }

        // Load all reports into DataGridView
        //private void LoadAllReports()
        //{
        //    try
        //    {
        //        dgvReports.DataSource = reportRepo.GetReportsByUser(0);
        //        // 0 = get ALL reports (as we defined earlier)
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error loading reports: " + ex.Message);
        //    }
        //}

        private async Task LoadAllReportsAsync()
        {
            try
            {
                dgvReports.DataSource = await Task.Run(() => reportRepo.GetReportsByUser(0));
                LoadReportChart(); // load chart after data
            }
            catch (Exception ex)
            {
                Logger.Log(ex);
                MessageBox.Show("Something went wrong. Check log.txt");
            }
        }

        //Refresh Button
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadAllReportsAsync();
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
                LoadAllReportsAsync(); // Refresh DataGridView
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

        private void LoadReportChart()
        {
            try
            {
                var reports = reportRepo.GetReportsByUser(0);
                var statusCounts = reports.GroupBy(r => r.Status)
                                          .Select(g => new { Status = g.Key, Count = g.Count() })
                                          .ToList();

                chartReports.Series.Clear();
                Series series = new Series("Reports");
                series.ChartType = SeriesChartType.Column;

                foreach (var s in statusCounts)
                {
                    series.Points.AddXY(s.Status, s.Count);
                }

                chartReports.Series.Add(series);
                chartReports.ChartAreas[0].AxisX.Title = "Status";
                chartReports.ChartAreas[0].AxisY.Title = "Number of Reports";
            }
            catch (Exception ex)
            {
                Logger.Log(ex);
                MessageBox.Show("Error loading chart. Check log.txt for details.");
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

        private void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {
                var reports = reportRepo.GetReportsByUser(0);

                string json = JsonSerializer.Serialize(reports, new JsonSerializerOptions
                {
                    WriteIndented = true
                });

                File.WriteAllText("ReportsBackup.json", json);

                MessageBox.Show("Backup saved successfully!");
            }
            catch (Exception ex)
            {
                Logger.Log(ex);
                MessageBox.Show("Error saving backup.");
            }
        }
    }
}