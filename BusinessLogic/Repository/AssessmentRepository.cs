using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Model;

namespace BusinessLogic.Repository
{
    public class AssessmentRepository
    {
        public List<AssessmentModel> GetAll(bool includeInactive, string searchTerm = null)
        {
            var list = new List<AssessmentModel>();

            using SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString);
            using SqlCommand cmd = new SqlCommand("sp_GetAllAssessments", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IncludeInactive", includeInactive);
            cmd.Parameters.AddWithValue("@SearchTerm", string.IsNullOrWhiteSpace(searchTerm) ? (object)DBNull.Value : searchTerm.Trim());

            conn.Open();
            using SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new AssessmentModel
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
                    TotalAmount = Convert.ToDecimal(reader["TotalAmount"]),
                    AssessmentDate = Convert.ToDateTime(reader["AssessmentDate"]),
                    IsActive = Convert.ToBoolean(reader["IsActive"]),
                    DateCreated = Convert.ToDateTime(reader["DateCreated"])
                });
            }

            return list;
        }

        public List<EnrolledStudentLookupModel> GetEnrolledStudents()
        {
            var list = new List<EnrolledStudentLookupModel>();

            using SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString);
            using SqlCommand cmd = new SqlCommand("sp_GetEnrolledStudentsForAssessment", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            conn.Open();
            using SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new EnrolledStudentLookupModel
                {
                    EnrollmentID = Convert.ToInt32(reader["EnrollmentID"]),
                    StudentID = Convert.ToInt32(reader["StudentID"]),
                    StudentNumber = reader["StudentNumber"].ToString(),
                    StudentName = reader["StudentName"].ToString(),
                    GradeLevelName = reader["GradeLevelName"].ToString(),
                    DefaultTuitionFee = Convert.ToDecimal(reader["DefaultTuitionFee"]),
                    DefaultMiscellaneousFee = Convert.ToDecimal(reader["DefaultMiscellaneousFee"]),
                    SectionName = reader["SectionName"].ToString(),
                    SchoolYear = reader["SchoolYear"].ToString()
                });
            }

            return list;
        }

        public void Add(AssessmentModel assessment)
        {
            using SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString);
            using SqlCommand cmd = new SqlCommand("sp_AddAssessment", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            AddAssessmentParameters(cmd, assessment);

            conn.Open();
            cmd.ExecuteNonQuery();
        }

        public void Update(AssessmentModel assessment)
        {
            using SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString);
            using SqlCommand cmd = new SqlCommand("sp_UpdateAssessment", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@AssessmentID", assessment.AssessmentID);
            AddAssessmentParameters(cmd, assessment);

            conn.Open();
            cmd.ExecuteNonQuery();
        }

        public void Deactivate(int assessmentId)
        {
            using SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString);
            using SqlCommand cmd = new SqlCommand("sp_DeactivateAssessment", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@AssessmentID", assessmentId);

            conn.Open();
            cmd.ExecuteNonQuery();
        }

        private void AddAssessmentParameters(SqlCommand cmd, AssessmentModel assessment)
        {
            cmd.Parameters.AddWithValue("@EnrollmentID", assessment.EnrollmentID);
            cmd.Parameters.AddWithValue("@TuitionFee", assessment.TuitionFee);
            cmd.Parameters.AddWithValue("@MiscellaneousFee", assessment.MiscellaneousFee);
            cmd.Parameters.AddWithValue("@OtherFees", assessment.OtherFees);
            cmd.Parameters.AddWithValue("@DiscountAmount", assessment.DiscountAmount);
            cmd.Parameters.AddWithValue("@AssessmentDate", assessment.AssessmentDate.Date);
        }
    }
}