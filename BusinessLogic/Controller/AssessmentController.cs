using System;
using System.Collections.Generic;
using BusinessLogic.Repository;
using Model;

namespace BusinessLogic.Controller
{
    public class AssessmentController
    {
        private readonly AssessmentRepository _assessmentRepo;

        public AssessmentController()
        {
            _assessmentRepo = new AssessmentRepository();
        }

        public List<AssessmentModel> GetAll(bool includeInactive, string searchTerm = null)
        {
            return _assessmentRepo.GetAll(includeInactive, searchTerm);
        }

        public List<EnrolledStudentLookupModel> GetEnrolledStudents()
        {
            return _assessmentRepo.GetEnrolledStudents();
        }

        public bool Add(AssessmentModel assessment, out string errorMessage)
        {
            errorMessage = string.Empty;

            if (!ValidateAssessment(assessment, out errorMessage))
                return false;

            try
            {
                assessment.TotalAmount = CalculateTotal(assessment);
                _assessmentRepo.Add(assessment);
                return true;
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return false;
            }
        }

        public bool Update(AssessmentModel assessment, out string errorMessage)
        {
            errorMessage = string.Empty;

            if (assessment == null || assessment.AssessmentID <= 0)
            {
                errorMessage = "Please select a valid assessment record to update.";
                return false;
            }

            if (!ValidateAssessment(assessment, out errorMessage))
                return false;

            try
            {
                assessment.TotalAmount = CalculateTotal(assessment);
                _assessmentRepo.Update(assessment);
                return true;
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return false;
            }
        }

        public bool Deactivate(int assessmentId, out string errorMessage)
        {
            errorMessage = string.Empty;

            if (assessmentId <= 0)
            {
                errorMessage = "Please select a valid assessment record to delete.";
                return false;
            }

            try
            {
                _assessmentRepo.Deactivate(assessmentId);
                return true;
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return false;
            }
        }

        private bool ValidateAssessment(AssessmentModel assessment, out string errorMessage)
        {
            errorMessage = string.Empty;

            if (assessment == null)
            {
                errorMessage = "Invalid assessment data.";
                return false;
            }

            if (assessment.EnrollmentID <= 0)
            {
                errorMessage = "Please select an enrolled student.";
                return false;
            }

            if (assessment.TuitionFee < 0 || assessment.MiscellaneousFee < 0 || assessment.OtherFees < 0 || assessment.DiscountAmount < 0)
            {
                errorMessage = "Fee amounts and discounts cannot be negative.";
                return false;
            }

            decimal grossTotal = assessment.TuitionFee + assessment.MiscellaneousFee + assessment.OtherFees;
            if (grossTotal <= 0)
            {
                errorMessage = "Total gross fees must be greater than 0.00.";
                return false;
            }

            if (assessment.DiscountAmount > grossTotal)
            {
                errorMessage = "Discount amount cannot exceed the total gross fees.";
                return false;
            }

            return true;
        }

        private decimal CalculateTotal(AssessmentModel assessment)
        {
            return (assessment.TuitionFee + assessment.MiscellaneousFee + assessment.OtherFees) - assessment.DiscountAmount;
        }
    }
}