using System;

namespace Model
{
    public class PaymentModel
    {
        public int PaymentID { get; set; }
        public int AssessmentID { get; set; }
        public string ReceiptNumber { get; set; }
        public string StudentNumber { get; set; }
        public string StudentName { get; set; }
        public string GradeLevelName { get; set; }
        public string SectionName { get; set; }
        public string SchoolYear { get; set; }
        public decimal AmountPaid { get; set; }
        public string PaymentMethod { get; set; }
        public string ReferenceNumber { get; set; }
        public DateTime PaymentDate { get; set; }
        public int ProcessedByUserID { get; set; }
        public string ProcessedBy { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateCreated { get; set; }
    }
}