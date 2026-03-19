using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

public static class DBConnection
{
    private static string connString = "server=localhost;database=silakbo_final;uid=root;pwd=;";

    public static MySqlConnection GetConnection()
    {
        return new MySqlConnection(connString);
    }
}
