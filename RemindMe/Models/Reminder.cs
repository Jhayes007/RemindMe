using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RemindMe.Models
{
    public class Reminder
    {
        public string Description { get; set; }
        [Key]
        [Required]
        public string Name { get; set; }
        [Required]
        public int Frequency { get; set; }

        [Column(TypeName = "date")]
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public TimeSpan Time { get; set; }
        public string Location { get; set; }
        public string Priority { get; set; }

        public Reminder() { }

    }
}
