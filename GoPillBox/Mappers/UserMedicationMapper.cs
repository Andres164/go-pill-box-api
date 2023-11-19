using GoPillBox.Models;
using GoPillBox.Models.ViewModels;

namespace GoPillBox.Mappers
{
    public static class UserMedicationMapper
    {
        public static UserMedication ToModel(UserMedicationView fromView, int userId, int userMedicationId = 0) 
        {
            return new UserMedication
            {
                UserId = userId,
                UserMedicationId = userMedicationId,
                Dose = fromView.Dose,
                DoseUnitOfMesure = fromView.DoseUnitOfMesure,
                DosingFrequencyInHours = fromView.DosingFrequencyInHours,
                MedicationName = fromView.MedicationName,
                MedicNotes = fromView.MedicNotes,
                TimeInTreatmentInDays = fromView.TimeInTreatmentInDays
            };
        }
    }
}
