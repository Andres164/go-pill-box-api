using GoPillBox.Database;
using GoPillBox.Models;
using GoPillBox.Models.ViewModels;
using GoPillBox.Repositories.Contracts;
using GoPillBox.Services;
using Microsoft.EntityFrameworkCore;

namespace GoPillBox.Repositories
{
    public class MedicationInTreatmentRepository : IMedicationInTreatmentRepository
    {
        private readonly GoPillBoxDbContext _dbContext;
        private readonly ILoggingService _logger;

        public MedicationInTreatmentRepository(GoPillBoxDbContext dbContext, ILoggingService loggingService)
        {
            this._dbContext = dbContext;
            this._logger = loggingService;
        }

        public async Task<List<MedicationInTreatment>> ReadAllAsync()
        {
            try
            {
                List<MedicationInTreatment> medicationInTreatments = await this._dbContext.MedicationInTreatments.ToListAsync();
                return medicationInTreatments;
            }
            catch (Exception ex)
            {
                this._logger.LogException(ex);
                throw;
            }
        }

        public async Task<MedicationInTreatment?> ReadAsync(int medicationInTreatmentId)
        {
            try
            {
                MedicationInTreatment? medicationInTreatment = await this._dbContext.MedicationInTreatments.FindAsync(medicationInTreatmentId);
                return medicationInTreatment;
            }
            catch (Exception ex)
            {
                this._logger.LogException(ex);
                throw;
            }
        }

        public Task<MedicationInTreatment?> CreateAsync(MedicationInTreatmentRequest newMedicationInTreatment)
        {
            throw new NotImplementedException();
        }

        public Task<MedicationInTreatment?> DeleteAsync(int medicationInTreatmentId)
        {
            throw new NotImplementedException();
        }


        public Task<MedicationInTreatment?> UpdateAsync(int id, MedicationInTreatmentRequest modifiedMedicationInTreatment)
        {
            throw new NotImplementedException();
        }
    }
}
