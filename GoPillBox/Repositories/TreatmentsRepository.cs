using GoPillBox.Database;
using GoPillBox.Models;
using GoPillBox.Models.ViewModels;
using GoPillBox.Repositories.Contracts;

namespace GoPillBox.Repositories
{
    public class TreatmentsRepository : ITreatmentsRepository
    {
        private readonly GoPillBoxDbContext _dbContext;

        public TreatmentsRepository(GoPillBoxDbContext dbContext)
        {
            this._dbContext = dbContext;
        }


    public Task<Treatment?> CreateAsync(TreatmentView newTreatment)
        {
            throw new NotImplementedException();
        }

        public Task<Treatment?> DeleteAsync(int treatmentId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Treatment>> ReadAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Treatment?> ReadAsync(int treatmentId)
        {
            throw new NotImplementedException();
        }

        public Task<Treatment?> UpdateAsync(int id, TreatmentView modifiedTreatment)
        {
            throw new NotImplementedException();
        }
    }
}
