using GoPillBox.Models;
using GoPillBox.Models.ViewModels;
using GoPillBox.Repositories.Contracts;

namespace GoPillBox.Repositories
{
    public class MedicationsRepository : IMedicationsRepository
    {
        public Task<Medication?> CreateAsync(MedicationView newMedication)
        {
            throw new NotImplementedException();
        }

        public Task<Medication?> DeleteAsync(int medicationId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Medication>> ReadAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Medication?> ReadAsync(int medicationId)
        {
            throw new NotImplementedException();
        }

        public Task<Medication?> UpdateAsync(int id, MedicationView modifiedMedication)
        {
            throw new NotImplementedException();
        }
    }
}
