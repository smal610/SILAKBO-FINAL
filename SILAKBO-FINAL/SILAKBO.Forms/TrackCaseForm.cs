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
    public partial class TrackCaseForm : Form
    {
        private User user;
        private ReportService reportService = new ReportService();

        public TrackCaseForm(User currentUser)
        {
            InitializeComponent();
            user = currentUser;
            LoadReports();
        }

        private void LoadReports()
        {
            dgvReports.DataSource = reportService.GetUserReports(user.UserID);
        }
    }
}
