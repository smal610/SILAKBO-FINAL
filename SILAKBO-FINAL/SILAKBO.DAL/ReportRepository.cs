using MySql.Data.MySqlClient;
using SILAKBO_FINAL.SILAKBO.Models;
using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Text;

public class ReportRepository
{
    public void SubmitReport(Report report)
    {
        using (var conn = DBConnection.GetConnection())
        {
            conn.Open();
            string sql = "INSERT INTO Reports (UserID, FullName, HarassmentType, Description, EvidencePath) " +
                         "VALUES (@UserID, @FullName, @HarassmentType, @Description, @EvidencePath)";
            using (var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@UserID", report.UserID);
                cmd.Parameters.AddWithValue("@FullName", report.FullName);
                cmd.Parameters.AddWithValue("@HarassmentType", report.HarassmentType);
                cmd.Parameters.AddWithValue("@Description", report.Description);
                cmd.Parameters.AddWithValue("@EvidencePath", report.EvidencePath);
                cmd.ExecuteNonQuery();
            }
        }
    }

    public void UpdateReportStatus(int reportID, string status)
    {
        using (var conn = DBConnection.GetConnection())
        {
            conn.Open();
            string sql = "UPDATE Reports SET Status=@status WHERE ReportID=@id";
            using (var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@id", reportID);
                cmd.ExecuteNonQuery();
            }
        }
    }

    public List<Report> GetReportsByUser(int userId)
    {
        List<Report> reports = new List<Report>();
        using (var conn = DBConnection.GetConnection())
        {
            conn.Open();
            string sql = userId == 0 ? "SELECT * FROM Reports" : "SELECT * FROM Reports WHERE UserID=@UserID";
            using (var cmd = new MySqlCommand(sql, conn))
            {
                if (userId != 0) cmd.Parameters.AddWithValue("@UserID", userId);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        reports.Add(new Report
                        {
                            ReportID = reader.GetInt32("ReportID"),
                            UserID = reader.GetInt32("UserID"),
                            FullName = reader.GetString("FullName"),
                            HarassmentType = reader.GetString("HarassmentType"),
                            Description = reader.GetString("Description"),
                            EvidencePath = reader["EvidencePath"] as string,
                            Status = reader.GetString("Status"),
                            DateSubmitted = reader.GetDateTime("DateSubmitted")
                        });
                    }
                }
            }
        }
        return reports;
    }
}