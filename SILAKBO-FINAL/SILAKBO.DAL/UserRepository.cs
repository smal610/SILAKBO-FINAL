using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using SILAKBO_FINAL.SILAKBO.Models;

public class UserRepository
{
    public void Register(User user)
    {
        using (var conn = DBConnection.GetConnection())
        {
            conn.Open();
            string sql = "INSERT INTO Users (Name, Username, Password, Gender, Birthday, Role) " +
                         "VALUES (@Name, @Username, @Password, @Gender, @Birthday, @Role)";
            using (var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Name", user.Name);
                cmd.Parameters.AddWithValue("@Username", user.Username);
                cmd.Parameters.AddWithValue("@Password", user.Password);
                cmd.Parameters.AddWithValue("@Gender", user.Gender);
                cmd.Parameters.AddWithValue("@Birthday", user.Birthday);
                cmd.Parameters.AddWithValue("@Role", user.Role);
                cmd.ExecuteNonQuery();
            }
        }
    }

    public User Login(string username, string passwordHash)
    {
        using (var conn = DBConnection.GetConnection())
        {
            conn.Open();
            string sql = "SELECT * FROM Users WHERE Username=@Username AND Password=@Password";
            using (var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", passwordHash);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new User
                        {
                            UserID = reader.GetInt32("UserID"),
                            Name = reader.GetString("Name"),
                            Username = reader.GetString("Username"),
                            Gender = reader.GetString("Gender"),
                            Birthday = reader.GetDateTime("Birthday"),
                            Role = reader.GetString("Role")
                        };
                    }
                }
            }
        }
        return null;
    }
}