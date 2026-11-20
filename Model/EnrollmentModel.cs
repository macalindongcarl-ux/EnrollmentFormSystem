using System;

namespace Model
{
    public class EnrollmentModel
    {
        public int EnrollmentID { get; set; }
        public int StudentID { get; set; }
        public string StudentNumber { get; set; }
        public string StudentName { get; set; }
        public int GradeLevelID { get; set; }
        public string GradeLevelName { get; set; }
        public int SectionID { get; set; }
        public string SectionName { get; set; }
        public string SchoolYear { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public string Status { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateCreated { get; set; }
    }
}