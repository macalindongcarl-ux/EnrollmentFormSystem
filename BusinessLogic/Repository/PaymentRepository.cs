using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Model;

namespace BusinessLogic.Repository
{
    public class PaymentRepository
    {
        public List<AssessedAccountModel> GetAssessedAccounts()
        {
            var list = new List<AssessedAccountModel>();

            using SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString);
            using SqlCommand cmd = new SqlCommand("sp_GetAssessedAccountsForPayment", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            conn.Open();
            using SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new AssessedAccountModel
                {
                    AssessmentID = Convert.ToInt32(reader["AssessmentID"]),
                    EnrollmentID = Convert.ToInt32(reader["EnrollmentID"]),
                    StudentID = Convert.ToInt32(reader["StudentID"]),
                    StudentNumber = reader["StudentNumber"].ToString(),
                    StudentName = reader["StudentName"].ToString(),
                    GradeLevelName = reader["GradeLevelName"].ToString(),
                    SectionName = reader["SectionName"].ToString(),
                    SchoolYear = reader["SchoolYear"].ToString(),
                    TuitionFee = Convert.ToDecimal(reader["TuitionFee"]),
                    MiscellaneousFee = Convert.ToDecimal(reader["MiscellaneousFee"]),
                    OtherFees = Convert.ToDecimal(reader["OtherFees"]),
                    DiscountAmount = Convert.ToDecimal(reader["DiscountAmount"]),
                    TotalAssessed = Convert.ToDecimal(reader["TotalAssessed"]),
                    TotalPaid = Convert.ToDecimal(reader["TotalPaid"]),
                    RemainingBalance = Convert.ToDecimal(reader["RemainingBalance"]),
                    PaymentStatus = reader["PaymentStatus"].ToString()
                });
            }

            return list;
        }

        public List<PaymentModel> GetAll(bool includeInactive, string searchTerm = null)
        {
            var list = new List<PaymentModel>();

            using SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString);
            using SqlCommand cmd = new SqlCommand("sp_GetAllPayments", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IncludeInactive", includeInactive);
            cmd.Parameters.AddWithValue("@SearchTerm", string.IsNullOrWhiteSpace(searchTerm) ? (object)DBNull.Value : searchTerm.Trim());

            conn.Open();
            using SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new PaymentModel
                {
                    PaymentID = Convert.ToInt32(reader["PaymentID"]),
                    AssessmentID = Convert.ToInt32(reader["AssessmentID"]),
                    ReceiptNumber = reader["ReceiptNumber"].ToString(),
                    StudentNumber = reader["StudentNumber"].ToString(),
                    StudentName = reader["StudentName"].ToString(),
                    GradeLevelName = reader["GradeLevelName"].ToString(),
                    SectionName = reader["SectionName"].ToString(),
                    SchoolYear = reader["SchoolYear"].ToString(),
                    AmountPaid = Convert.ToDecimal(reader["AmountPaid"]),
                    PaymentMethod = reader["PaymentMethod"].ToString(),
                    ReferenceNumber = reader["ReferenceNumber"] == DBNull.Value ? string.Empty : reader["ReferenceNumber"].ToString(),
                    PaymentDate = Convert.ToDateTime(reader["PaymentDate"]),
                    ProcessedBy = reader["ProcessedBy"].ToString(),
                    IsActive = Convert.ToBoolean(reader["IsActive"]),
                    DateCreated = Convert.ToDateTime(reader["DateCreated"])
                });
            }

            return list;
        }

        public string Add(PaymentModel payment)
        {
            using SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString);
            using SqlCommand cmd = new SqlCommand("sp_AddPayment", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@AssessmentID", payment.AssessmentID);
            cmd.Parameters.AddWithValue("@AmountPaid", payment.AmountPaid);
            cmd.Parameters.AddWithValue("@PaymentMethod", payment.PaymentMethod);
            cmd.Parameters.AddWithValue("@ReferenceNumber", string.IsNullOrWhiteSpace(payment.ReferenceNumber) ? (object)DBNull.Value : payment.ReferenceNumber.Trim());
            cmd.Parameters.AddWithValue("@PaymentDate", payment.PaymentDate.Date);
            cmd.Parameters.AddWithValue("@ProcessedByUserID", payment.ProcessedByUserID);

            conn.Open();
            object result = cmd.ExecuteScalar();
            return result?.ToString() ?? string.Empty;
        }

        public void Deactivate(int paymentId)
        {
            using SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString);
            using SqlCommand cmd = new SqlCommand("sp_DeactivatePayment", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PaymentID", paymentId);

            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }
}