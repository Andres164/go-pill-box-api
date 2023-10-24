namespace GoPillBox.Models
{
    public class Medication
    {
        public int MedicationId { get; set; }
        public string BrandName { get; set; }  = string.Empty;
        public string[] Ingridients { get; set; } = Array.Empty<string>();
    }
}
