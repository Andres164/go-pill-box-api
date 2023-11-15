namespace GoPillBox.Models.ViewModels
{
    public class AlarmEventView
    {
        public int MedicationInTreatmentId { get; set; }
        public DateTime EventTimeStamp { get; set; }
        public AlarmEvent.States CurrentState { get; set; }
        public int PostponedForMinutes { get; set; }
    }
}
