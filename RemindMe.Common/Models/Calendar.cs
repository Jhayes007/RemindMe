using RemindMe.DatabaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemindMe.Common.Models
{
    public class Calendar
    {
        public int Id { get; set; }
        public DateTime DayOfWeek { get; set; }
        public int Year { get; set; }
        public string Month { get; set; } = string.Empty;

        public Calendar() { }

        public Calendar(CalendarModel calendarModel)
        {
            Id = calendarModel.Id;
            DayOfWeek = calendarModel.DayOfWeek;
            Year = calendarModel.Year;
            Month = calendarModel.Month;
        }
    }
}
