using MySql.Data.MySqlClient;
using SILAKBO_FINAL.SILAKBO.Models;
using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Text;

public class SupportRepository
{
    public List<SupportResource> GetAllResources()
    {
        List<SupportResource> contacts = new List<SupportResource>();
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
                        contacts.Add(new SupportResource
                        {
                            ResourceID = reader.GetInt32("ResourceID"),
                            Name = reader.GetString("Name"),
                            Type = reader.GetString("Type"),
                            Contact = reader.GetString("Contact")
                        });
                    }
                }
            }
        }

        return contacts;


    }
}