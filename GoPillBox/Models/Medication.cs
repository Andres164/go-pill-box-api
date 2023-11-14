using System.ComponentModel.DataAnnotations.Schema;

namespace GoPillBox.Models
{
    [Table("medication")]
    public class Medication
    {
        [Column("medication_id")]
        public int MedicationId { get; set; }

        [Column("name", TypeName = "character varying(70)")]
        public string Name { get; set; } = string.Empty;
    }
}
