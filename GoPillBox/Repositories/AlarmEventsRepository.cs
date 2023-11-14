using GoPillBox.Models;
using GoPillBox.Models.ViewModels;
using GoPillBox.Repositories.Contracts;

namespace GoPillBox.Repositories
{
    public class AlarmEventsRepository : IAlarmEventsRepository
    {
        public Task<AlarmEvent?> CreateAsync(AlarmEventView alarmEvent)
        {
            throw new NotImplementedException();
        }

        public Task<AlarmEvent?> DeleteAsync(int alarmEventId)
        {
            throw new NotImplementedException();
        }

        public Task<List<AlarmEvent>> ReadAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<AlarmEvent?> ReadAsync(int alarmEventId)
        {
            throw new NotImplementedException();
        }

        public Task<AlarmEvent?> UpdateAsync(int id, AlarmEventView alarmEvent)
        {
            throw new NotImplementedException();
        }
    }
}
