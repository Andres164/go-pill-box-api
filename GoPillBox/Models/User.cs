using System.ComponentModel.DataAnnotations.Schema;

namespace GoPillBox.Models
{
    [Table("users")]
    public class User
    {
        [Column("user_id")]
        public int UserId { get; set; }

        [Column("user_name", TypeName = "character varying(50)")]
        public string UserName { get; set; } = string.Empty;

        [Column("password", TypeName = "character varying(50)")]
        public string Password { get; set; } = string.Empty;
    }
}
