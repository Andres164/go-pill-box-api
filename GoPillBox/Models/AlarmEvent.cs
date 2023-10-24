namespace GoPillBox.Models
{
    public class AlarmEvent
    {
        public enum States { Taken, Scheduled, NotTaken, Postponed };

        public int AlarmEventId { get; set; }
        public int MedicationInTreatmentid { get; set; }
        public DateTime EventTimeStamp { get; set; }
        public AlarmEvent.States CurrentState { get; set; }
        public int PostponedForInMinutes { get; set; }

    }
}
