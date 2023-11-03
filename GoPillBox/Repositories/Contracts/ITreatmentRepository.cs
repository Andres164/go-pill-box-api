using GoPillBox.Models.ViewModels;
using GoPillBox.Models;

namespace GoPillBox.Repositories.Contracts
{
    public interface ITreatmentRepository
    {
        Task<List<Treatment>> ReadAllAsync();
        Task<Treatment?> ReadAsync(int treatmentId);
        Task<Treatment?> CreateAsync(TreatmentView newTreatment);
        Task<Treatment?> UpdateAsync(int id, TreatmentView modifiedTreatment); 
        Task<Treatment?> DeleteAsync(int treatmentId);
    }
}
