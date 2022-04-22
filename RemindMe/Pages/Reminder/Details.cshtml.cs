using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RemindMe.Data;

namespace RemindMe.Pages.Calendar
{
    public class DetailsModel : PageModel
    {
        private readonly RemindMeContext _context;

        public DetailsModel(RemindMeContext context)
        {
            _context = context;
        }

        public Models.Reminders Reminders { get; set; }

        public async Task<IActionResult> OnGetAsync(string? name)
        {
            if (name == null)
            {
                return NotFound();
            }

            Reminders = await _context.Reminders
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Name == name);

            if (Reminders == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}
