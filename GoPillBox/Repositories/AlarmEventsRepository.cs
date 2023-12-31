﻿using GoPillBox.Database;
using GoPillBox.Mappers;
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
        private readonly ILoggingService _logger;

        public AlarmEventsRepository(GoPillBoxDbContext dbContext, ILoggingService loggingService)
        {
            this._dbContext = dbContext;
            this._logger = loggingService;
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
                this._logger.LogException(ex);
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
                this._logger.LogException(ex);
                throw;
            }
        }

        public async Task<AlarmEvent?> CreateAsync(AlarmEventView alarmEventView)
        {
            try
            {
                AlarmEvent alarmEventModel = AlarmEventMapper.ToModel(alarmEventView);
                var createdAlarmEvent = await this._dbContext.AlarmEvents.AddAsync(alarmEventModel);
                await this._dbContext.SaveChangesAsync();
                return createdAlarmEvent.Entity;
            }
            catch (Exception ex)
            {
                this._logger.LogException(ex);
                throw;
            }
        }

        public async Task<AlarmEvent?> DeleteAsync(int alarmEventId)
        {
            try
            {
                AlarmEvent? alarmEventToDelete = await this._dbContext.AlarmEvents.FindAsync(alarmEventId);
                if (alarmEventToDelete == null) return null;
                var deletedAlarmEvent = this._dbContext.AlarmEvents.Remove(alarmEventToDelete);
                await this._dbContext.SaveChangesAsync();

                return deletedAlarmEvent.Entity;

            }
            catch (Exception ex)
            {
                this._logger.LogException(ex);
                throw;
            }
        }


        public async Task<AlarmEvent?> UpdateAsync(int id, AlarmEventView alarmEventView)
        {
            try
            {
                AlarmEvent? alarmEventToUpdate = await this._dbContext.AlarmEvents.FindAsync(id);
                if (alarmEventToUpdate == null) return null;

                AlarmEvent modifiedAlarmEvent = AlarmEventMapper.ToModel(alarmEventView, id);
                AlarmEventMapper.CopyModel(modifiedAlarmEvent, alarmEventToUpdate);
                await this._dbContext.SaveChangesAsync();
                return modifiedAlarmEvent;
            }
            catch (Exception ex)
            {
                this._logger.LogException(ex);
                throw;
            }
        }
    }
}
