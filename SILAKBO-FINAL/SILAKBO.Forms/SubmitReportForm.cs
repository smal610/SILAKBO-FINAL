using SILAKBO_FINAL.SILAKBO.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SILAKBO_FINAL.SILAKBO.Forms
{
    public partial class SubmitReportForm : Form
    {
        private User user;
        private ReportService reportService = new ReportService();

        public SubmitReportForm(User currentUser)
        {
            InitializeComponent();
            user = currentUser;
            comboHarassmentType.Items.AddRange(new string[] { "Verbal", "Physical", "Sexual", "Cyber" });
            comboHarassmentType.SelectedIndex = 0;
        }

        private void btnBrowseEvidence_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK) txtEvidence.Text = dlg.FileName;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Report report = new Report
            {
                UserID = user.UserID,
                FullName = txtFullName.Text.Trim(),
                HarassmentType = comboHarassmentType.SelectedItem.ToString(),
                Description = txtDescription.Text.Trim(),
                EvidencePath = txtEvidence.Text.Trim()
            };
            reportService.SubmitReport(report);
            MessageBox.Show("Report submitted successfully!");
            this.Close();
        }
    }
}
