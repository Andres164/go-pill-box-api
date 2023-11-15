using GoPillBox.Models;
using GoPillBox.Models.ViewModels;

namespace GoPillBox.Mappers
{
    public static class AlarmEventMapper
    {
        public static AlarmEvent ToModel(AlarmEventView fromView, int alarmEventId = 0)
        {
            return new AlarmEvent
            {
                AlarmEventId = alarmEventId,
                CurrentState = fromView.CurrentState,
                EventTimeStamp = fromView.EventTimeStamp,
                MedicationInTreatmentId = fromView.MedicationInTreatmentId,
                PostponedForInMinutes = fromView.PostponedForMinutes
            };
        }
    }
}
