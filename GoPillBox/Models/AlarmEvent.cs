namespace GoPillBox.Models
{
    public class AlarmEvent
    {
        public enum States { Scheduled, Taken, Postponed, NotTaken };

        public int AlarmEventId { get; set; }
        public int MedicationInTreatmentid { get; set; }
        public DateTime EventTimeStamp { get; set; }
        public AlarmEvent.States CurrentState { get; set; }
        public int PostponedForInMinutes { get; set; }

    }
}
