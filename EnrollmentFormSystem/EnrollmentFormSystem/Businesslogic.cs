
using EnrollmentFormSystem.Models;
using System;
using System.Data;

namespace EnrollmentFormSystem
{
    internal class Businesslogic
    {
        private readonly StudentRepository repository =
            new StudentRepository();

        public bool AddStudent(Student student)
        {
            ValidateStudent(student);

            if (repository.StudentExists(student.StudentID))
            {
                throw new Exception("Student ID already exists.");
            }

            return repository.AddStudent(student);
        }

      
        public DataTable GetStudents()
        {
            return repository.GetStudents();
        }

       
        public DataTable SearchStudents(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
            {
                return repository.GetStudents();
            }

            return repository.SearchStudents(keyword);
        }

       
        public bool UpdateStudent(Student student)
        {
            ValidateStudent(student);

            if (!repository.StudentExists(student.StudentID))
            {
                throw new Exception("Student record does not exist.");
            }

            return repository.UpdateStudent(student);
        }

        
        public bool DeleteStudent(string studentID)
        {
            if (string.IsNullOrWhiteSpace(studentID))
            {
                throw new Exception("Please select a student.");
            }

            return repository.DeleteStudent(studentID);
        }

      
        private void ValidateStudent(Student student)
        {
            if (student == null)
                throw new Exception("Student information is required.");

            if (string.IsNullOrWhiteSpace(student.StudentID))
                throw new Exception("Student ID is required.");

            if (string.IsNullOrWhiteSpace(student.FirstName))
                throw new Exception("First Name is required.");

            if (string.IsNullOrWhiteSpace(student.LastName))
                throw new Exception("Last Name is required.");

            if (string.IsNullOrWhiteSpace(student.Gender))
                throw new Exception("Gender is required.");

            if (string.IsNullOrWhiteSpace(student.Address))
                throw new Exception("Address is required.");

            if (string.IsNullOrWhiteSpace(student.ContactNumber))
                throw new Exception("Contact Number is required.");

            if (string.IsNullOrWhiteSpace(student.GuardianName))
                throw new Exception("Guardian Name is required.");

            if (string.IsNullOrWhiteSpace(student.GuardianNo))
                throw new Exception("Guardian Contact is required.");

            if (string.IsNullOrWhiteSpace(student.GradeLevel))
                throw new Exception("Grade Level is required.");

            if (string.IsNullOrWhiteSpace(student.Section))
                throw new Exception("Section is required.");
        }
    }
}
