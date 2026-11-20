using System;
using System.Collections.Generic;
using BusinessLogic.Repository;
using Model;

namespace BusinessLogic.Controller
{
    public class EnrollmentController
    {
        private readonly EnrollmentRepository _enrollmentRepo;

        public EnrollmentController()
        {
            _enrollmentRepo = new EnrollmentRepository();
        }

        public List<EnrollmentModel> GetAll(bool includeInactive, string searchTerm = null)
        {
            return _enrollmentRepo.GetAll(includeInactive, searchTerm);
        }

        public List<SectionCapacityModel> GetSectionsByGradeAndSY(int gradeLevelId, string schoolYear)
        {
            if (gradeLevelId <= 0 || string.IsNullOrWhiteSpace(schoolYear))
                return new List<SectionCapacityModel>();

            return _enrollmentRepo.GetSectionsByGradeAndSY(gradeLevelId, schoolYear);
        }

        public bool Add(EnrollmentModel enrollment, out string errorMessage)
        {
            errorMessage = string.Empty;

            if (!ValidateEnrollment(enrollment, out errorMessage))
                return false;

            try
            {
                enrollment.SchoolYear = enrollment.SchoolYear.Trim();
                _enrollmentRepo.Add(enrollment);
                return true;
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return false;
            }
        }

        public bool Update(EnrollmentModel enrollment, out string errorMessage)
        {
            errorMessage = string.Empty;

            if (enrollment == null || enrollment.EnrollmentID <= 0)
            {
                errorMessage = "Please select a valid enrollment record to update.";
                return false;
            }

            if (!ValidateEnrollment(enrollment, out errorMessage))
                return false;

            try
            {
                enrollment.SchoolYear = enrollment.SchoolYear.Trim();
                _enrollmentRepo.Update(enrollment);
                return true;
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return false;
            }
        }

        public bool Deactivate(int enrollmentId, out string errorMessage)
        {
            errorMessage = string.Empty;

            if (enrollmentId <= 0)
            {
                errorMessage = "Please select a valid enrollment record to delete.";
                return false;
            }

            try
            {
                _enrollmentRepo.Deactivate(enrollmentId);
                return true;
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return false;
            }
        }

        private bool ValidateEnrollment(EnrollmentModel enrollment, out string errorMessage)
        {
            errorMessage = string.Empty;

            if (enrollment == null)
            {
                errorMessage = "Invalid enrollment data.";
                return false;
            }

            if (enrollment.StudentID <= 0)
            {
                errorMessage = "Please select a valid student.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(enrollment.SchoolYear))
            {
                errorMessage = "School Year is required (e.g., 2026-2027).";
                return false;
            }

            if (enrollment.GradeLevelID <= 0)
            {
                errorMessage = "Please select a valid Grade Level.";
                return false;
            }

            if (enrollment.SectionID <= 0)
            {
                errorMessage = "Please select a valid Section.";
                return false;
            }

            if (enrollment.Status != "Enrolled" && enrollment.Status != "Dropped")
            {
                errorMessage = "Please select a valid enrollment status (Enrolled or Dropped).";
                return false;
            }

            return true;
        }
    }
}