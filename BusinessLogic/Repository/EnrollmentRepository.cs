using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Model;

namespace BusinessLogic.Repository
{
    public class EnrollmentRepository
    {
        public List<EnrollmentModel> GetAll(bool includeInactive, string searchTerm = null)
        {
            var list = new List<EnrollmentModel>();

            using SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString);
            using SqlCommand cmd = new SqlCommand("sp_GetAllEnrollments", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IncludeInactive", includeInactive);
            cmd.Parameters.AddWithValue("@SearchTerm", string.IsNullOrWhiteSpace(searchTerm) ? (object)DBNull.Value : searchTerm.Trim());

            conn.Open();
            using SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new EnrollmentModel
                {
                    EnrollmentID = Convert.ToInt32(reader["EnrollmentID"]),
                    StudentID = Convert.ToInt32(reader["StudentID"]),
                    StudentNumber = reader["StudentNumber"].ToString(),
                    StudentName = reader["StudentName"].ToString(),
                    GradeLevelID = Convert.ToInt32(reader["GradeLevelID"]),
                    GradeLevelName = reader["GradeLevelName"].ToString(),
                    SectionID = Convert.ToInt32(reader["SectionID"]),
                    SectionName = reader["SectionName"].ToString(),
                    SchoolYear = reader["SchoolYear"].ToString(),
                    EnrollmentDate = Convert.ToDateTime(reader["EnrollmentDate"]),
                    Status = reader["Status"].ToString(),
                    IsActive = Convert.ToBoolean(reader["IsActive"]),
                    DateCreated = Convert.ToDateTime(reader["DateCreated"])
                });
            }

            return list;
        }

        public List<SectionCapacityModel> GetSectionsByGradeAndSY(int gradeLevelId, string schoolYear)
        {
            var list = new List<SectionCapacityModel>();

            using SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString);
            using SqlCommand cmd = new SqlCommand("sp_GetSectionsByGradeAndSY", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@GradeLevelID", gradeLevelId);
            cmd.Parameters.AddWithValue("@SchoolYear", schoolYear.Trim());

            conn.Open();
            using SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new SectionCapacityModel
                {
                    SectionID = Convert.ToInt32(reader["SectionID"]),
                    SectionName = reader["SectionName"].ToString(),
                    GradeLevelID = Convert.ToInt32(reader["GradeLevelID"]),
                    SchoolYear = reader["SchoolYear"].ToString(),
                    Adviser = reader["Adviser"] == DBNull.Value ? string.Empty : reader["Adviser"].ToString(),
                    MaxCapacity = reader["MaxCapacity"] == DBNull.Value ? (int?)null : Convert.ToInt32(reader["MaxCapacity"]),
                    CurrentEnrolled = Convert.ToInt32(reader["CurrentEnrolled"])
                });
            }

            return list;
        }

        public void Add(EnrollmentModel enrollment)
        {
            using SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString);
            using SqlCommand cmd = new SqlCommand("sp_AddEnrollment", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            AddEnrollmentParameters(cmd, enrollment);

            conn.Open();
            cmd.ExecuteNonQuery();
        }

        public void Update(EnrollmentModel enrollment)
        {
            using SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString);
            using SqlCommand cmd = new SqlCommand("sp_UpdateEnrollment", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@EnrollmentID", enrollment.EnrollmentID);
            AddEnrollmentParameters(cmd, enrollment);

            conn.Open();
            cmd.ExecuteNonQuery();
        }

        public void Deactivate(int enrollmentId)
        {
            using SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString);
            using SqlCommand cmd = new SqlCommand("sp_DeactivateEnrollment", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EnrollmentID", enrollmentId);

            conn.Open();
            cmd.ExecuteNonQuery();
        }

        private void AddEnrollmentParameters(SqlCommand cmd, EnrollmentModel enrollment)
        {
            cmd.Parameters.AddWithValue("@StudentID", enrollment.StudentID);
            cmd.Parameters.AddWithValue("@GradeLevelID", enrollment.GradeLevelID);
            cmd.Parameters.AddWithValue("@SectionID", enrollment.SectionID);
            cmd.Parameters.AddWithValue("@SchoolYear", enrollment.SchoolYear.Trim());
            cmd.Parameters.AddWithValue("@EnrollmentDate", enrollment.EnrollmentDate.Date);
            cmd.Parameters.AddWithValue("@Status", enrollment.Status);
        }
    }
}