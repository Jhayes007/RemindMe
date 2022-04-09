using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace RemindMe.RemindMeDB
{
    /// <summary>
    /// UserReminders
    /// </summary>
    public partial class Reminders
    {
        public string Description { get; set; }
        public string Name { get; set; }
        public int Frequency { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public string Location { get; set; }
        public string Priority { get; set; }
    }
}
