using BusinessLogic.Repository;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Controller
{
    public class UserController
    {
        private readonly UserRepository _userRepository;

        public UserController()
        {
            _userRepository = new UserRepository();
        }

        /// <summary>
        /// Validates form text parameters and coordinates login execution flow
        /// </summary>
        public UserModel Login(string username, string password, out string errorMessage)
        {
            errorMessage = string.Empty;

            // UI Input verification bounds validation
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                errorMessage = "Username and Password fields cannot be left empty.";
                return null;
            }

            try
            {
                UserModel authenticatedUser = _userRepository.Authenticate(username, password);

                if (authenticatedUser == null)
                {
                    errorMessage = "Invalid username or password credentials.";
                }

                return authenticatedUser;
            }
            catch (Exception ex)
            {
                errorMessage = $"System connection error: {ex.Message}";
                return null;
            }
        }
    }
}
