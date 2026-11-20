using System;

namespace Model
{
    public class AssessedAccountModel
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
        public decimal TotalAssessed { get; set; }
        public decimal TotalPaid { get; set; }
        public decimal RemainingBalance { get; set; }
        public string PaymentStatus { get; set; }

        public string DisplayText => $"{StudentNumber} - {StudentName} ({GradeLevelName} - {SectionName}, Bal: ₱{RemainingBalance:N2})";
    }
}