using System;

namespace EnrollmentFormSystem.Models
{
    public class Student
    {
        public string StudentID { get; set; }
        public string StudentNo { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public string GuardianNo { get; set; }
        public string GuardianName { get; set; }
        public string GradeLevel { get; set; }
        public string Section { get; set; }
    }
}