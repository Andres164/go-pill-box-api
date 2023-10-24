namespace GoPillBox.Models
{
    public class Treatment
    {
        public int TreatmentId { get; set; }
        public int UserId { get; set; }
        public string GeneralDescription { get; set; } = string.Empty;
    }
}
