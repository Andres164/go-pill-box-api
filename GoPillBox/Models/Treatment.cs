using System.ComponentModel.DataAnnotations.Schema;

namespace GoPillBox.Models
{
    [Table("treatment")]
    public class Treatment
    {
        [Column("treatment_id")]
        public int TreatmentId { get; set; }

        [Column("user_id")]
        [ForeignKey(nameof(User))]
        public int UserId { get; set; }

        [Column("general_description", TypeName = "character varying(250)")]
        public string GeneralDescription { get; set; } = string.Empty;
    }
}
