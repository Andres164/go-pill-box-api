namespace GoPillBox.Models
{
    public class MedicationInTreatment
    {
        public int MedicationInTreatmentId { get; set; }
        public int TreatmentId { get; set; }
        public int MedicationId { get; set; }
        public string MedicNotes { get; set; } = string.Empty;
        public float Dose { get; set; }
        public string DoseUnitOfMesure { get; set; } = string.Empty;
        public float DosingFrequencyInHours { get; set; }
        public int TimeInTreatmentInDays { get; set; }
    }
}
