using GoPillBox.Models.ViewModels;
using GoPillBox.Models;

namespace GoPillBox.Repositories.Contracts
{
    public interface IMedicationRepository
    {
        Task<List<Medication>> ReadAllAsync();
        Task<Medication?> ReadAsync(int medicationId);
        Task<Medication?> CreateAsync(MedicationView newMedication);
        Task<Medication?> UpdateAsync(MedicationView modifiedMedication); 
        Task<Medication?> DeleteAsync(int medicationId);
    }
}
