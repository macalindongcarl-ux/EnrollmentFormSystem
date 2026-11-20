using System;

namespace Model
{
    public class SectionModel
    {
        public int SectionID { get; set; }
        public string SectionName { get; set; }
        public int GradeLevelID { get; set; }
        public string GradeLevelName { get; set; }
        public string SchoolYear { get; set; }
        public string Adviser { get; set; }
        public int? MaxCapacity { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateCreated { get; set; }
    }
}