using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RemindMe.Models
{
    public class Users
    {
        [Key]
        public int UserId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        [NotMapped]
        public HashCode Password { get; set; }

        public Users() { }

    }
}
