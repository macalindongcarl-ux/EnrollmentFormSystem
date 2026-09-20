using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrollmentFormSystem
{
    public static class Database
    {
        private static readonly string connectionString =
            @"Data Source=(localdb)\MSSQLLocalDB;
              Initial Catalog=SchoolEnrollmentDB;
              Integrated Security=True;
              TrustServerCertificate=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
    


