using System;
using System.Collections.Generic;
using BusinessLogic.Repository;
using Model;

namespace BusinessLogic.Controller
{
    public class GradeLevelController
    {
        private readonly GradeLevelRepository _gradeLevelRepo;

        public GradeLevelController()
        {
            _gradeLevelRepo = new GradeLevelRepository();
        }

        public List<GradeLevelModel> GetAll(bool includeInactive)
        {
            return _gradeLevelRepo.GetAll(includeInactive);
        }

        public bool Add(GradeLevelModel gradeLevel, out string errorMessage)
        {
            errorMessage = string.Empty;

            if (!ValidateGradeLevel(gradeLevel, out errorMessage))
                return false;

            try
            {
                gradeLevel.GradeLevelName = gradeLevel.GradeLevelName.Trim();
                _gradeLevelRepo.Add(gradeLevel);
                return true;
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return false;
            }
        }

        public bool Update(GradeLevelModel gradeLevel, out string errorMessage)
        {
            errorMessage = string.Empty;

            if (gradeLevel == null || gradeLevel.GradeLevelID <= 0)
            {
                errorMessage = "Please select a valid grade level to update.";
                return false;
            }

            if (!ValidateGradeLevel(gradeLevel, out errorMessage))
                return false;

            try
            {
                gradeLevel.GradeLevelName = gradeLevel.GradeLevelName.Trim();
                _gradeLevelRepo.Update(gradeLevel);
                return true;
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return false;
            }
        }

        public bool Deactivate(int gradeLevelId, out string errorMessage)
        {
            errorMessage = string.Empty;

            if (gradeLevelId <= 0)
            {
                errorMessage = "Please select a valid grade level to delete.";
                return false;
            }

            try
            {
                _gradeLevelRepo.Deactivate(gradeLevelId);
                return true;
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return false;
            }
        }

        private bool ValidateGradeLevel(GradeLevelModel gradeLevel, out string errorMessage)
        {
            errorMessage = string.Empty;

            if (gradeLevel == null || string.IsNullOrWhiteSpace(gradeLevel.GradeLevelName))
            {
                errorMessage = "Grade Level name is required.";
                return false;
            }

            if (gradeLevel.TuitionFee < 0 || gradeLevel.MiscellaneousFee < 0)
            {
                errorMessage = "Tuition and Miscellaneous fees cannot be negative.";
                return false;
            }

            return true;
        }
    }
}