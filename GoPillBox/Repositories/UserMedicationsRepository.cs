using GoPillBox.Database;
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

        public Task<UserMedication?> CreateAsync(UserMedicationView newUserMedication)
        {
            throw new NotImplementedException();
        }

        public Task<UserMedication?> DeleteAsync(int userMedicationId)
        {
            throw new NotImplementedException();
        }


        public Task<UserMedication?> UpdateAsync(int id, UserMedicationView modifiedUserMedication)
        {
            throw new NotImplementedException();
        }
    }
}
