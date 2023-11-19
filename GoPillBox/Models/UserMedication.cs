using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoPillBox.Models
{
    [Table("user_medications")]
    public class UserMedication
    {
        [Column("user_medication_id")]
        public int UserMedicationId { get; set; }

        [Column("user_id")]
        [ForeignKey(nameof(User))]
        public int UserId { get; set; }

        [Column("medic_notes", TypeName = "character varying(350)")]
        public string MedicNotes { get; set; } = string.Empty;

        [Column("medication_name", TypeName = "character varying(70)")]
        public string MedicationName { get; set; } = string.Empty;

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
