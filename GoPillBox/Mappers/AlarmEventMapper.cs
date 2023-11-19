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
                UserMedicationId = fromView.UserMedicationId,
                PostponedForInMinutes = fromView.PostponedForMinutes
            };
        }

        public static void CopyModel(AlarmEvent fromModel,  AlarmEvent toModel)
        {
            toModel.UserMedicationId = fromModel.UserMedicationId;
            toModel.CurrentState = fromModel.CurrentState;
            toModel.EventTimeStamp = fromModel.EventTimeStamp;
            toModel.PostponedForInMinutes = fromModel.PostponedForInMinutes;
        }
    }
}
