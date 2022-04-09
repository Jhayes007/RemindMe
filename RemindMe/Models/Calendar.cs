using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemindMe.Models
{
    public class Calendar
    {
        public int Id { get; set; }
        public DateTime DayOfWeek { get; set; }
        public int Year { get; set; }
        public string Month { get; set; } = string.Empty;

        public Calendar() { }

    }
}
