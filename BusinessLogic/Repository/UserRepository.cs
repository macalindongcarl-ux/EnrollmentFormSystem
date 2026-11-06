using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Model;

namespace BusinessLogic.Repository
{
    public class UserRepository
    {
        public UserModel Authenticate(string username, string password)
        {
            // Pull the string directly from your centralized configuration class
            using SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString);
            using (SqlCommand cmd = new SqlCommand("sp_AuthenticateUser", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                // Parameters prevent SQL injections safely
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Map the returned row records to your Model properties
                        return new UserModel
                        {
                            UserID = Convert.ToInt32(reader["UserID"]),
                            Username = reader["Username"].ToString(),
                            IsAdmin = Convert.ToBoolean(reader["IsAdmin"])
                        };
                    }
                }
            }
            return null; // Return null if authentication credentials fail
        }
    }
}
