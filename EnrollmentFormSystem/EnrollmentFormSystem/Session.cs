using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrollmentFormSystem
{
    internal class Session
    {
        public static int UserID { get; set; }
        public static string Username { get; set; }
        public static string FullName { get; set; }
        public static string Role { get; set; }

        public static void Clear()
        {
            UserID = 0;
            Username = null;
            FullName = null;
            Role = null;
        }
    }
}
