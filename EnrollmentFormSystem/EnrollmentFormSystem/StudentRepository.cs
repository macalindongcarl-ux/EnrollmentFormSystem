using EnrollmentFormSystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrollmentFormSystem
{
    internal class StudentRepository
    {

        // Store your connection string here
        private readonly string _connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=Enrollmentformsystem;Integrated Security=True;";

        public bool AddStudent(Student student)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
                    INSERT INTO Students
                    (
                        StudentID,
                        FirstName,
                        MiddleName,
                        LastName,
                        DateOfBirth,
                        Gender,
                        Address,
                        ContactNumber,
                        GuardianName,
                        GuardianContact,
                        GradeLevel,
                        Section
                    )
                    VALUES
                    (
                        @StudentID,
                        @FirstName,
                        @MiddleName,
                        @LastName,
                        @DateOfBirth,
                        @Gender,
                        @Address,
                        @ContactNumber,
                        @GuardianName,
                        @GuardianContact,
                        @GradeLevel,
                        @Section
                    )";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        AddParameters(cmd, student);

                        conn.Open();

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }

            // READ
            public DataTable GetStudents()
            {
                DataTable table = new DataTable();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                    string query = "SELECT * FROM Students ORDER BY LastName";

                    using (SqlDataAdapter adapter =
                           new SqlDataAdapter(query, conn))
                    {
                        adapter.Fill(table);
                    }
                }

                return table;
            }

            // SEARCH
            public DataTable SearchStudents(string keyword)
            {
                DataTable table = new DataTable();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                    string query = @"
                    SELECT *
                    FROM Students
                    WHERE StudentID LIKE @Keyword
                       OR FirstName LIKE @Keyword
                       OR LastName LIKE @Keyword
                       OR (FirstName + ' ' + LastName) LIKE @Keyword
                    ORDER BY LastName";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@Keyword",
                            "%" + keyword + "%"
                        );

                        using (SqlDataAdapter adapter =
                               new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(table);
                        }
                    }
                }

                return table;
            }

            // UPDATE
            public bool UpdateStudent(Student student)
            {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                    string query = @"
                    UPDATE Students SET
                        FirstName = @FirstName,
                        MiddleName = @MiddleName,
                        LastName = @LastName,
                        DateOfBirth = @DateOfBirth,
                        Gender = @Gender,
                        Address = @Address,
                        ContactNumber = @ContactNumber,
                        GuardianName = @GuardianName,
                        GuardianContact = @GuardianContact,
                        GradeLevel = @GradeLevel,
                        Section = @Section
                    WHERE StudentID = @StudentID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        AddParameters(cmd, student);

                        conn.Open();

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }

            public bool DeleteStudent(string studentID)
            {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                    string query =
                        "DELETE FROM Students WHERE StudentID = @StudentID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@StudentID", studentID);

                        conn.Open();

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }

            // CHECK IF STUDENT EXISTS
            public bool StudentExists(string studentID)
            {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                    string query =
                        "SELECT COUNT(*) FROM Students WHERE StudentID = @StudentID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@StudentID", studentID);

                        conn.Open();

                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        return count > 0;
                    }
                }
            }

            private void AddParameters(
                SqlCommand cmd,Student student)
            {
                cmd.Parameters.AddWithValue(
                    "@StudentID", student.StudentID);

                cmd.Parameters.AddWithValue(
                    "@FirstName", student.FirstName);

                cmd.Parameters.AddWithValue(
                    "@MiddleName",
                    string.IsNullOrEmpty(student.MiddleName)
                        ? (object)DBNull.Value
                        : student.MiddleName);

                cmd.Parameters.AddWithValue(
                    "@LastName", student.LastName);

                cmd.Parameters.AddWithValue(
                    "@DateOfBirth", student.DateOfBirth);

                cmd.Parameters.AddWithValue(
                    "@Gender", student.Gender);

                cmd.Parameters.AddWithValue(
                    "@Address", student.Address);

                cmd.Parameters.AddWithValue(
                    "@ContactNumber", student.ContactNumber);

                cmd.Parameters.AddWithValue(
                    "@GuardianName", student.GuardianName);

                cmd.Parameters.AddWithValue(
                    "@GuardianContact", student.GuardianNo);

                cmd.Parameters.AddWithValue(
                    "@GradeLevel", student.GradeLevel);

                cmd.Parameters.AddWithValue(
                    "@Section", student.Section);
            }
        }
    }

