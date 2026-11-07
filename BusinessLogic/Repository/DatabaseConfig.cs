using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Repository
{
    public static class DatabaseConfig
    {
        public static string ConnectionString { get; } = @"Server=.\SQLEXPRESS;Database=EnrollmentDB;Trusted_Connection=True;TrustServerCertificate=True;";
    }
}
