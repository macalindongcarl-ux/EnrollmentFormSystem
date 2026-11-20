using System;

namespace Model
{
    public class SectionCapacityModel
    {
        public int SectionID { get; set; }
        public string SectionName { get; set; }
        public int GradeLevelID { get; set; }
        public string SchoolYear { get; set; }
        public string Adviser { get; set; }
        public int? MaxCapacity { get; set; }
        public int CurrentEnrolled { get; set; }

        public string DisplayLabel
        {
            get
            {
                string capacityText = MaxCapacity.HasValue
                    ? $"{CurrentEnrolled} / {MaxCapacity.Value}"
                    : $"{CurrentEnrolled} / No Limit";
                return $"{SectionName} ({capacityText})";
            }
        }
    }
}