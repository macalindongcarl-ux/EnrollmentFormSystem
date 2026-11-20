namespace Model
{
    public class GradeLevelModel
    {
        public int GradeLevelID { get; set; }
        public string GradeLevelName { get; set; }
        public decimal TuitionFee { get; set; }
        public decimal MiscellaneousFee { get; set; }
        public bool IsActive { get; set; }
    }
}