using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoPillBox.Models
{
    [Table("medication_in_treatment")]
    public class MedicationInTreatment
    {
        [Column("medication_in_treatment_id")]
        public int MedicationInTreatmentId { get; set; }

        [Column("treatment_id")]
        [ForeignKey(nameof(Treatment))]
        public int TreatmentId { get; set; }

        [Column("medication_id")]
        [ForeignKey(nameof(Medication))]
        public int MedicationId { get; set; }


        [Column("medic_notes", TypeName = "character varying(350)")]
        public string MedicNotes { get; set; } = string.Empty;

        [Column("dose")]
        public float Dose { get; set; }

        [Column("dose_unit_of_mesure", TypeName = "character varying(20)")]
        public string DoseUnitOfMesure { get; set; } = string.Empty;

        [Column("dosing_frequency_in_hours")]
        public float DosingFrequencyInHours { get; set; }

        [Column("time_in_treatment_in_days")]
        public int TimeInTreatmentInDays { get; set; }
    }
}
