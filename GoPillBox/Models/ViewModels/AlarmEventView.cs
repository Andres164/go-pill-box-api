namespace GoPillBox.Models.ViewModels
{
    public class AlarmEventView
    {
        public int MedicationInTreatmentId { get; set; }
        public DateTime EventTimeStamp { get; set; }
        public AlarmEvent.States State { get; set; }
        public int PosponedForMinutes { get; set; }
    }
}
