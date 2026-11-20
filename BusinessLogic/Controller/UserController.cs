using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using BusinessLogic.Repository;
using Model;

namespace BusinessLogic.Controller
{
    public class UserController
    {
        private readonly UserRepository _userRepo;

        public UserController()
        {
            _userRepo = new UserRepository();
        }

        public UserModel Login(string username, string password, out string errorMessage)
        {
            errorMessage = string.Empty;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                errorMessage = "Please enter both username and password.";
                return null;
            }

            try
            {
                using SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString);
                using SqlCommand cmd = new SqlCommand("sp_AuthenticateUser", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Username", username.Trim());
                cmd.Parameters.AddWithValue("@Password", password);

                conn.Open();
                using SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new UserModel
                    {
                        UserID = Convert.ToInt32(reader["UserID"]),
                        Username = reader["Username"].ToString(),
                        Role = reader["Role"].ToString(),
                        IsActive = Convert.ToBoolean(reader["IsActive"])
                    };
                }

                errorMessage = "Invalid username, password, or inactive account.";
                return null;
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return null;
            }
        }

        public List<UserModel> GetAll(bool includeInactive = true, string searchTerm = null)
        {
            return _userRepo.GetAll(includeInactive, searchTerm);
        }

        public bool Add(string username, string password, string confirmPassword, string role, out string errorMessage)
        {
            errorMessage = string.Empty;

            if (string.IsNullOrWhiteSpace(username) || username.Trim().Length < 3)
            {
                errorMessage = "Username must be at least 3 characters long.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(password) || password.Length < 4)
            {
                errorMessage = "Password must be at least 4 characters long.";
                return false;
            }

            if (password != confirmPassword)
            {
                errorMessage = "Password and Confirm Password do not match.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(role))
            {
                errorMessage = "Please select a valid role.";
                return false;
            }

            try
            {
                var user = new UserModel
                {
                    Username = username.Trim(),
                    Password = password,
                    Role = role,
                    IsActive = true
                };

                _userRepo.Add(user);
                return true;
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return false;
            }
        }

        public bool Update(int userId, int currentLoggedInUserId, string username, string newPassword, string confirmPassword, string role, bool isActive, out string errorMessage)
        {
            errorMessage = string.Empty;

            if (userId <= 0)
            {
                errorMessage = "Please select a user from the table to update.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(username) || username.Trim().Length < 3)
            {
                errorMessage = "Username must be at least 3 characters long.";
                return false;
            }

            if (userId == currentLoggedInUserId && !isActive)
            {
                errorMessage = "You cannot deactivate your own currently logged-in account.";
                return false;
            }

            if (userId == currentLoggedInUserId && !role.Equals("Admin", StringComparison.OrdinalIgnoreCase))
            {
                errorMessage = "You cannot remove Admin privileges from your own currently logged-in account.";
                return false;
            }

            if (!string.IsNullOrEmpty(newPassword))
            {
                if (newPassword.Length < 4)
                {
                    errorMessage = "New password must be at least 4 characters long.";
                    return false;
                }

                if (newPassword != confirmPassword)
                {
                    errorMessage = "New Password and Confirm Password do not match.";
                    return false;
                }
            }

            try
            {
                var user = new UserModel
                {
                    UserID = userId,
                    Username = username.Trim(),
                    Password = newPassword,
                    Role = role,
                    IsActive = isActive
                };

                _userRepo.Update(user);
                return true;
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return false;
            }
        }

        public bool Deactivate(int userId, int currentLoggedInUserId, out string errorMessage)
        {
            errorMessage = string.Empty;

            if (userId <= 0)
            {
                errorMessage = "Please select a user to deactivate.";
                return false;
            }

            if (userId == currentLoggedInUserId)
            {
                errorMessage = "You cannot deactivate your own currently logged-in account.";
                return false;
            }

            try
            {
                _userRepo.Deactivate(userId);
                return true;
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return false;
            }
        }
    }
}