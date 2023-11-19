using GoPillBox.Models.ViewModels;
using GoPillBox.Models;

namespace GoPillBox.Repositories.Contracts
{
    public interface IUserMedicationsRepository
    {
        Task<List<UserMedication>> ReadAllAsync();
        Task<UserMedication?> ReadAsync(int userMedicationId);
        Task<UserMedication?> CreateAsync(UserMedicationView newUserMedication);
        Task<UserMedication?> UpdateAsync(int id, UserMedicationView modifiedUserMedication);
        Task<UserMedication?> DeleteAsync(int UserMedicationId);
    }
}
