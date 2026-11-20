using System;

namespace Model
{
    public class EnrolledStudentLookupModel
    {
        public int EnrollmentID { get; set; }
        public int StudentID { get; set; }
        public string StudentNumber { get; set; }
        public string StudentName { get; set; }
        public string GradeLevelName { get; set; }
        public decimal DefaultTuitionFee { get; set; }
        public decimal DefaultMiscellaneousFee { get; set; }
        public string SectionName { get; set; }
        public string SchoolYear { get; set; }

        public string DisplayText => $"{StudentNumber} - {StudentName} ({GradeLevelName} - {SectionName}, SY {SchoolYear})";
    }
}