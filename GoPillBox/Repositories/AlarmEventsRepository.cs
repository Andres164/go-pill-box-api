using GoPillBox.Database;
using GoPillBox.Models;
using GoPillBox.Models.ViewModels;
using GoPillBox.Repositories.Contracts;
using GoPillBox.Services;
using Microsoft.EntityFrameworkCore;

namespace GoPillBox.Repositories
{
    public class AlarmEventsRepository : IAlarmEventsRepository
    {
        private readonly GoPillBoxDbContext _dbContext;
        private readonly ILoggingService _loggingService;

        public AlarmEventsRepository(GoPillBoxDbContext dbContext, ILoggingService loggingService)
        {
            this._dbContext = dbContext;
            this._loggingService = loggingService;
        }

        public async Task<List<AlarmEvent>> ReadAllAsync()
        {
            try
            {
                List<AlarmEvent> alarmEvents = await this._dbContext.AlarmEvents.ToListAsync();
                return alarmEvents;
            }
            catch (Exception ex)
            {
                this._loggingService.LogException(ex);
                throw;
            }
        }

        public async Task<AlarmEvent?> ReadAsync(int alarmEventId)
        {
            try
            {
                AlarmEvent? alarmEvent = await this._dbContext.AlarmEvents.FindAsync(alarmEventId);
                return alarmEvent;
            }
            catch (Exception ex)
            {
                this._loggingService.LogException(ex);
                throw;
            }
        }

        public async Task<AlarmEvent?> CreateAsync(AlarmEventView alarmEvent)
        {
            try
            {
                AlarmEvent alarmEventModel = new (AlarmEvent)alarmEvent; // CONVERT VIEW
                var createdAlarmEvent = await this._dbContext.AlarmEvents.AddAsync(alarmEventModel);
                await this._dbContext.SaveChangesAsync();
                return createdAlarmEvent.Entity;
            }
            catch (Exception ex)
            {
                this._loggingService.LogException(ex);
                throw;
            }
        }

        public Task<AlarmEvent?> DeleteAsync(int alarmEventId)
        {
            try
            {
                var deletedAlarmEvent = this._dbContext.Attach
            }
            catch (Exception ex)
            {
                this._loggingService.LogException(ex);
                throw;
            }
        }


        public Task<AlarmEvent?> UpdateAsync(int id, AlarmEventView alarmEvent)
        {
            try
            {

            }
            catch (Exception ex)
            {
                this._loggingService.LogException(ex);
                throw;
            }
        }
    }
}
