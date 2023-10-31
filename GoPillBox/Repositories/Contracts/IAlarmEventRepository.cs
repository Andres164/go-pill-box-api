using GoPillBox.Models;
using GoPillBox.Models.ViewModels;

namespace GoPillBox.Repositories.Contracts
{
    public interface IAlarmEventRepository
    {
        Task<List<AlarmEvent>> ReadAllAsync();
        Task<AlarmEvent?> ReadAsync(int alarmEventId);
        Task<AlarmEvent?> CreateAsync(AlarmEventView alarmEvent);
        Task UpdateAsync(AlarmEventView alarmEvent);
        Task DeleteAsync(int alarmEventId);

    }
}
