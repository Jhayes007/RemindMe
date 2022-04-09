using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RemindMe.Common.Models;

namespace RemindMe.Common.DatabaseModels.Reminders
{
    public class ReminderModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        
        public int ReminderId { get; set; }
        public string Description { get; set; } = string.Empty;
        public string ReminderName { get; set; } = string.Empty;
        public string Frequency { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }

        public ReminderModel() { }

        public ReminderModel(Reminder reminder)
        {
            ReminderId = reminder.ReminderId;
            Description = reminder.Description;
            ReminderName = reminder.ReminderName;
            Frequency = reminder.Frequency;
            Date = reminder.Date;
            Time = reminder.Time;
        }


    }
}
