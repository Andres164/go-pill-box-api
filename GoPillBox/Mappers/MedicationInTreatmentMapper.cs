using GoPillBox.Models;
using GoPillBox.Models.ViewModels;

namespace GoPillBox.Mappers
{
    public static class MedicationInTreatmentMapper
    {
        public static MedicationInTreatment ToModel(MedicationInTreatmentRequest fromRequest, int treatmentId, int medicationInTreatmentId = 0) 
        {
            return new MedicationInTreatment
            {
                TreatmentId = treatmentId,
                MedicationInTreatmentId = medicationInTreatmentId,
                Dose = fromRequest.Dose,
                DoseUnitOfMesure = fromRequest.DoseUnitOfMesure,
                DosingFrequencyInHours = fromRequest.DosingFrequencyInHours,
                MedicationName = fromRequest.MedicationName,
                MedicNotes = fromRequest.MedicNotes,
                TimeInTreatmentInDays = fromRequest.TimeInTreatmentInDays
            };
        }
    }
}
