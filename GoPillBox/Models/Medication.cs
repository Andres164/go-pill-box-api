namespace GoPillBox.Models
{
    public class Medication
    {
        public int MedicationId { get; set; }
        public string[] Name { get; set; } = Array.Empty<string>();
    }
}
