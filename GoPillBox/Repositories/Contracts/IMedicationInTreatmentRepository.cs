using GoPillBox.Models.ViewModels;
using GoPillBox.Models;

namespace GoPillBox.Repositories.Contracts
{
    public interface IMedicationInTreatmentRepository
    {
        Task<List<MedicationInTreatment>> ReadAllAsync();
        Task<MedicationInTreatment?> ReadAsync(int medicationInTreatmentId);
        Task<MedicationInTreatment?> CreateAsync(MedicationInTreatmentRequest newMedicationInTreatment);
        Task<MedicationInTreatment?> UpdateAsync(int id, MedicationInTreatmentRequest modifiedMedicationInTreatment);
        Task<MedicationInTreatment?> DeleteAsync(int medicationInTreatmentId);
    }
}
