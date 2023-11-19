using System.ComponentModel.DataAnnotations.Schema;

namespace GoPillBox.Models
{
    [Table("alarm_events")]
    public class AlarmEvent
    {
        public enum States { Scheduled, Taken, Postponed, NotTaken };

        [Column("alarm_event_id")]
        public int AlarmEventId { get; set; }

        [Column("user_medication_id")]
        [ForeignKey(nameof(UserMedication))]
        public int UserMedicationId { get; set; }

        [Column("event_time_stamp")]
        public DateTime EventTimeStamp { get; set; }

        [Column("current_state")]
        public AlarmEvent.States CurrentState { get; set; }

        [Column("postponed_for_in_minutes")]
        public int PostponedForInMinutes { get; set; }

    }
}
