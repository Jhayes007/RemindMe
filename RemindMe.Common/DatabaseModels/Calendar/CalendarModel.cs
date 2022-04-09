using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RemindMe.Common.Models;

namespace RemindMe.DatabaseModels
{
    public class CalendarModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime DayOfWeek { get; set; }
        public int Year { get; set; }
        public string Month { get; set; } = string.Empty;

        public CalendarModel() { }

        public CalendarModel(Calendar calendar)
        {
            Id = calendar.Id;
            DayOfWeek = calendar.DayOfWeek; 
            Year = calendar.Year;
            Month = calendar.Month;
        }
    }
}
