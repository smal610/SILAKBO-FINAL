using MySql.Data.MySqlClient;
using SILAKBO_FINAL.SILAKBO.Models;
using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Text;

public class SupportRepository
{
    public List<SupportContact> GetAllContacts()
    {
        List<SupportContact> contacts = new List<SupportContact>();
        using (var conn = DBConnection.GetConnection())
        {
            conn.Open();
            string sql = "SELECT * FROM SupportContacts";
            using (var cmd = new MySqlCommand(sql, conn))
            {
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        contacts.Add(new SupportContact
                        {
                            ContactID = reader.GetInt32("ContactID"),
                            Name = reader.GetString("Name"),
                            ContactInfo = reader.GetString("ContactInfo")
                        });
                    }
                }
            }
        }
        return contacts;
    }
}