using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RemindMe.Data;
using RemindMe.Models;

namespace RemindMe.Pages.Calendar
{
    public class DetailsModel : PageModel
    {
        private readonly RemindMe.Data.RemindMeContext _context;

        public DetailsModel(RemindMe.Data.RemindMeContext context)
        {
            _context = context;
        }

        public Pages_Calendar_Details Calendar { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Calendar = await _context.Calendar.FirstOrDefaultAsync(m => m.ID == id);

            if (Calendar == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
