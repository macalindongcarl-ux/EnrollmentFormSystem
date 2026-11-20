using System;

namespace Model
{
    public class AssessmentModel
    {
        public int AssessmentID { get; set; }
        public int EnrollmentID { get; set; }
        public int StudentID { get; set; }
        public string StudentNumber { get; set; }
        public string StudentName { get; set; }
        public string GradeLevelName { get; set; }
        public string SectionName { get; set; }
        public string SchoolYear { get; set; }
        public decimal TuitionFee { get; set; }
        public decimal MiscellaneousFee { get; set; }
        public decimal OtherFees { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime AssessmentDate { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateCreated { get; set; }
    }
}