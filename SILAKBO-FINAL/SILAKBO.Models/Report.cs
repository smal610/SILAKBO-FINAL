using System;
using System.Collections.Generic;
using System.Text;

namespace SILAKBO_FINAL.SILAKBO.Models
{
    public class Report
    {
        public int ReportID { get; set; }
        public int UserID { get; set; }
        public string FullName { get; set; }
        public string HarassmentType { get; set; }
        public string Description { get; set; }
        public string EvidencePath { get; set; }
        public string Status { get; set; }
        public DateTime DateSubmitted { get; set; }
    }
}
