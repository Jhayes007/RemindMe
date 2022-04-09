using RemindMe.Common.DatabaseModels.Reminders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemindMe.Common.Models
{
    public class Reminder
    {
        public int ReminderId { get; set; }
        public string Description { get; set; } = string.Empty;
        public string ReminderName { get; set; } = string.Empty;
        public string Frequency { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }

        public Reminder() { }

        public Reminder(ReminderModel remindermodel)
        {
            ReminderId = remindermodel.ReminderId;
            Description = remindermodel.Description;
            ReminderName = remindermodel.ReminderName;
            Frequency = remindermodel.Frequency;
            Date = remindermodel.Date;
            Time = remindermodel.Time;
        }
    }
}
