using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Model;

namespace BusinessLogic.Repository
{
    public class StudentRepository
    {
        public List<StudentModel> GetAll(bool includeInactive, string searchTerm = null)
        {
            var list = new List<StudentModel>();

            using SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString);
            using SqlCommand cmd = new SqlCommand("sp_GetAllStudents", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IncludeInactive", includeInactive);
            cmd.Parameters.AddWithValue("@SearchTerm", string.IsNullOrWhiteSpace(searchTerm) ? (object)DBNull.Value : searchTerm.Trim());

            conn.Open();
            using SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new StudentModel
                {
                    StudentID = Convert.ToInt32(reader["StudentID"]),
                    StudentNumber = reader["StudentNumber"].ToString(),
                    FirstName = reader["FirstName"].ToString(),
                    MiddleName = reader["MiddleName"] == DBNull.Value ? string.Empty : reader["MiddleName"].ToString(),
                    LastName = reader["LastName"].ToString(),
                    DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]),
                    Gender = reader["Gender"].ToString(),
                    Address = reader["Address"].ToString(),
                    ContactNumber = reader["ContactNumber"] == DBNull.Value ? string.Empty : reader["ContactNumber"].ToString(),
                    Email = reader["Email"] == DBNull.Value ? string.Empty : reader["Email"].ToString(),
                    GuardianName = reader["GuardianName"].ToString(),
                    GuardianContact = reader["GuardianContact"].ToString(),
                    IsActive = Convert.ToBoolean(reader["IsActive"]),
                    DateCreated = Convert.ToDateTime(reader["DateCreated"])
                });
            }

            return list;
        }

        public void Add(StudentModel student)
        {
            using SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString);
            using SqlCommand cmd = new SqlCommand("sp_AddStudent", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            AddStudentParameters(cmd, student);

            conn.Open();
            cmd.ExecuteNonQuery();
        }

        public void Update(StudentModel student)
        {
            using SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString);
            using SqlCommand cmd = new SqlCommand("sp_UpdateStudent", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@StudentID", student.StudentID);
            AddStudentParameters(cmd, student);

            conn.Open();
            cmd.ExecuteNonQuery();
        }

        public void Deactivate(int studentId)
        {
            using SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString);
            using SqlCommand cmd = new SqlCommand("sp_DeactivateStudent", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StudentID", studentId);

            conn.Open();
            cmd.ExecuteNonQuery();
        }

        private void AddStudentParameters(SqlCommand cmd, StudentModel student)
        {
            cmd.Parameters.AddWithValue("@FirstName", student.FirstName);
            cmd.Parameters.AddWithValue("@MiddleName", string.IsNullOrWhiteSpace(student.MiddleName) ? (object)DBNull.Value : student.MiddleName);
            cmd.Parameters.AddWithValue("@LastName", student.LastName);
            cmd.Parameters.AddWithValue("@DateOfBirth", student.DateOfBirth.Date);
            cmd.Parameters.AddWithValue("@Gender", student.Gender);
            cmd.Parameters.AddWithValue("@Address", student.Address);
            cmd.Parameters.AddWithValue("@ContactNumber", string.IsNullOrWhiteSpace(student.ContactNumber) ? (object)DBNull.Value : student.ContactNumber);
            cmd.Parameters.AddWithValue("@Email", string.IsNullOrWhiteSpace(student.Email) ? (object)DBNull.Value : student.Email);
            cmd.Parameters.AddWithValue("@GuardianName", student.GuardianName);
            cmd.Parameters.AddWithValue("@GuardianContact", student.GuardianContact);
        }
    }
}