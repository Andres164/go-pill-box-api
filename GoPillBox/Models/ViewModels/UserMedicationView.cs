namespace GoPillBox.Models.ViewModels
{
    public class UserMedicationView
    {
        public int UserId { get; set; }
        public string MedicationName { get; set; } = string.Empty;
        public string MedicNotes { get; set; } = string.Empty;
        public float Dose { get; set; }
        public string DoseUnitOfMesure { get; set; } = string.Empty;
        public float DosingFrequencyInHours { get; set; }
        public int TimeInTreatmentInDays { get; set; }
    }
}
