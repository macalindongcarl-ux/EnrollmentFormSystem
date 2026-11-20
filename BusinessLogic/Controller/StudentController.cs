using System;
using System.Collections.Generic;
using BusinessLogic.Repository;
using Model;

namespace BusinessLogic.Controller
{
    public class StudentController
    {
        private readonly StudentRepository _studentRepo;

        public StudentController()
        {
            _studentRepo = new StudentRepository();
        }

        public List<StudentModel> GetAll(bool includeInactive, string searchTerm = null)
        {
            return _studentRepo.GetAll(includeInactive, searchTerm);
        }

        public bool Add(StudentModel student, out string errorMessage)
        {
            errorMessage = string.Empty;

            if (!ValidateStudent(student, out errorMessage))
                return false;

            try
            {
                TrimStudentFields(student);
                _studentRepo.Add(student);
                return true;
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return false;
            }
        }

        public bool Update(StudentModel student, out string errorMessage)
        {
            errorMessage = string.Empty;

            if (student == null || student.StudentID <= 0)
            {
                errorMessage = "Please select a valid student record to update.";
                return false;
            }

            if (!ValidateStudent(student, out errorMessage))
                return false;

            try
            {
                TrimStudentFields(student);
                _studentRepo.Update(student);
                return true;
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return false;
            }
        }

        public bool Deactivate(int studentId, out string errorMessage)
        {
            errorMessage = string.Empty;

            if (studentId <= 0)
            {
                errorMessage = "Please select a valid student record to delete.";
                return false;
            }

            try
            {
                _studentRepo.Deactivate(studentId);
                return true;
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return false;
            }
        }

        private bool ValidateStudent(StudentModel student, out string errorMessage)
        {
            errorMessage = string.Empty;

            if (student == null)
            {
                errorMessage = "Invalid student data.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(student.FirstName))
            {
                errorMessage = "First Name is required.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(student.LastName))
            {
                errorMessage = "Last Name is required.";
                return false;
            }

            if (student.DateOfBirth >= DateTime.Today)
            {
                errorMessage = "Please enter a valid Date of Birth.";
                return false;
            }

            if (student.Gender != "Male" && student.Gender != "Female")
            {
                errorMessage = "Please select a valid Gender (Male or Female).";
                return false;
            }

            if (string.IsNullOrWhiteSpace(student.Address))
            {
                errorMessage = "Address is required.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(student.GuardianName))
            {
                errorMessage = "Guardian / Parent Name is required.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(student.GuardianContact))
            {
                errorMessage = "Guardian Contact Number is required.";
                return false;
            }

            return true;
        }

        private void TrimStudentFields(StudentModel student)
        {
            student.FirstName = student.FirstName.Trim();
            student.MiddleName = student.MiddleName?.Trim();
            student.LastName = student.LastName.Trim();
            student.Address = student.Address.Trim();
            student.ContactNumber = student.ContactNumber?.Trim();
            student.Email = student.Email?.Trim();
            student.GuardianName = student.GuardianName.Trim();
            student.GuardianContact = student.GuardianContact.Trim();
        }
    }
}