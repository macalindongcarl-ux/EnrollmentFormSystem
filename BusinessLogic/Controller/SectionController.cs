using System;
using System.Collections.Generic;
using BusinessLogic.Repository;
using Model;

namespace BusinessLogic.Controller
{
    public class SectionController
    {
        private readonly SectionRepository _sectionRepo;

        public SectionController()
        {
            _sectionRepo = new SectionRepository();
        }

        public List<SectionModel> GetAll(bool includeInactive)
        {
            return _sectionRepo.GetAll(includeInactive);
        }

        public bool Add(SectionModel section, out string errorMessage)
        {
            errorMessage = string.Empty;

            if (!ValidateSection(section, out errorMessage))
                return false;

            try
            {
                section.SectionName = section.SectionName.Trim();
                section.SchoolYear = section.SchoolYear.Trim();
                section.Adviser = section.Adviser?.Trim();

                _sectionRepo.Add(section);
                return true;
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return false;
            }
        }

        public bool Update(SectionModel section, out string errorMessage)
        {
            errorMessage = string.Empty;

            if (section.SectionID <= 0)
            {
                errorMessage = "Please select a valid section to update.";
                return false;
            }

            if (!ValidateSection(section, out errorMessage))
                return false;

            try
            {
                section.SectionName = section.SectionName.Trim();
                section.SchoolYear = section.SchoolYear.Trim();
                section.Adviser = section.Adviser?.Trim();

                _sectionRepo.Update(section);
                return true;
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return false;
            }
        }

        public bool Deactivate(int sectionId, out string errorMessage)
        {
            errorMessage = string.Empty;

            if (sectionId <= 0)
            {
                errorMessage = "Please select a valid section to delete.";
                return false;
            }

            try
            {
                _sectionRepo.Deactivate(sectionId);
                return true;
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return false;
            }
        }

        private bool ValidateSection(SectionModel section, out string errorMessage)
        {
            errorMessage = string.Empty;

            if (section == null)
            {
                errorMessage = "Invalid section data.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(section.SectionName))
            {
                errorMessage = "Section name cannot be empty.";
                return false;
            }

            if (section.GradeLevelID <= 0)
            {
                errorMessage = "Please select a valid Grade Level.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(section.SchoolYear))
            {
                errorMessage = "School Year is required (e.g., 2026-2027).";
                return false;
            }

            if (section.MaxCapacity.HasValue && section.MaxCapacity.Value <= 0)
            {
                errorMessage = "Maximum capacity must be greater than 0.";
                return false;
            }

            return true;
        }
    }
}