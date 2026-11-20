using System;

namespace Model
{
    public class StudentModel
    {
        public int StudentID { get; set; }
        public string StudentNumber { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public string GuardianName { get; set; }
        public string GuardianContact { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateCreated { get; set; }

        public string FullName
        {
            get
            {
                string middleInitial = string.IsNullOrWhiteSpace(MiddleName)
                    ? string.Empty
                    : $" {MiddleName.Trim()[0]}.";
                return $"{LastName}, {FirstName}{middleInitial}";
            }
        }
    }
}