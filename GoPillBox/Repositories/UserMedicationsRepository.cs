using GoPillBox.Database;
using GoPillBox.Mappers;
using GoPillBox.Models;
using GoPillBox.Models.ViewModels;
using GoPillBox.Repositories.Contracts;
using GoPillBox.Services;
using Microsoft.EntityFrameworkCore;

namespace GoPillBox.Repositories
{
    public class UserMedicationsRepository : IUserMedicationsRepository
    {
        private readonly GoPillBoxDbContext _dbContext;
        private readonly ILoggingService _logger;

        public UserMedicationsRepository(GoPillBoxDbContext dbContext, ILoggingService loggingService)
        {
            this._dbContext = dbContext;
            this._logger = loggingService;
        }

        public async Task<List<UserMedication>> ReadAllAsync()
        {
            try
            {
                List<UserMedication> userMedications = await this._dbContext.UserMedications.ToListAsync();
                return userMedications;
            }
            catch (Exception ex)
            {
                this._logger.LogException(ex);
                throw;
            }
        }

        public async Task<UserMedication?> ReadAsync(int userMedicationId)
        {
            try
            {
                UserMedication? userMedication = await this._dbContext.UserMedications.FindAsync(userMedicationId);
                return userMedication;
            }
            catch (Exception ex)
            {
                this._logger.LogException(ex);
                throw;
            }
        }

        public async Task<UserMedication?> CreateAsync(UserMedicationView newUserMedication)
        {
            try
            {
                UserMedication newUserMedicationModel = UserMedicationMapper.ToModel(newUserMedication);
                var createdUserMedication = await this._dbContext.UserMedications.AddAsync(newUserMedicationModel);
                await this._dbContext.SaveChangesAsync();
                return createdUserMedication.Entity;
            }
            catch (Exception ex)
            {
                this._logger.LogException(ex);
                throw;
            }
        }

        public async Task<UserMedication?> DeleteAsync(int userMedicationId)
        {
            try
            {
                UserMedication? userMedicationToDelete = await this._dbContext.UserMedications.FindAsync(userMedicationId);
                if (userMedicationToDelete == null) return null;
                var deletedUserMedication = this._dbContext.UserMedications.Remove(userMedicationToDelete);
                await this._dbContext.SaveChangesAsync();
                return deletedUserMedication.Entity;
            }
            catch (Exception ex)
            {
                this._logger.LogException(ex);
                throw;
            }
        }


        public async Task<UserMedication?> UpdateAsync(int userMedicationId, UserMedicationView modifiedUserMedication)
        {
            try
            {
                UserMedication modifiedUserMedicationModel = UserMedicationMapper.ToModel(modifiedUserMedication);
                UserMedication? userMedicationToUpdate = await this._dbContext.UserMedications.FindAsync(userMedicationId);
                if(userMedicationToUpdate == null) return null;
                UserMedicationMapper.CopyModel(modifiedUserMedicationModel, userMedicationToUpdate);
                await this._dbContext.SaveChangesAsync();
                return modifiedUserMedicationModel;
            }
            catch (Exception ex)
            {
                this._logger.LogException(ex);
                throw;
            }
        }
    }
}
