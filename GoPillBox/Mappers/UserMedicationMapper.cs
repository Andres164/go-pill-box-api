using GoPillBox.Models;
using GoPillBox.Models.ViewModels;

namespace GoPillBox.Mappers
{
    public static class UserMedicationMapper
    {
        public static UserMedication ToModel(UserMedicationView fromView, int userMedicationId = 0) 
        {
            return new UserMedication
            {
                UserMedicationId = userMedicationId,
                UserId = fromView.UserId,
                Dose = fromView.Dose,
                DoseUnitOfMesure = fromView.DoseUnitOfMesure,
                DosingFrequencyInHours = fromView.DosingFrequencyInHours,
                MedicationName = fromView.MedicationName,
                MedicNotes = fromView.MedicNotes,
                TimeInTreatmentInDays = fromView.TimeInTreatmentInDays
            };
        }

        public static void CopyModel(UserMedication fromModel,  UserMedication toModel)
        {
            toModel.UserId = fromModel.UserId;
            toModel.MedicNotes = fromModel.MedicNotes;
            toModel.MedicationName = fromModel.MedicationName;
            toModel.Dose = fromModel.Dose;
            toModel.DoseUnitOfMesure = fromModel.DoseUnitOfMesure;
            toModel.DosingFrequencyInHours = fromModel.DosingFrequencyInHours;
            toModel.TimeInTreatmentInDays = fromModel.TimeInTreatmentInDays;
        }
    }
}
