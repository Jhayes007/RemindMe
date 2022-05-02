using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RemindMe.Data;

namespace RemindMe.Pages.Reminder
{
    public class DetailsModel : PageModel
    {
        private readonly RemindMeContext _context;

        public DetailsModel(RemindMeContext context)
        {
            _context = context;
        }

        public IList<Models.Reminder> Reminders { get; set; }

        public async Task OnGetAsync()
        {
            Reminders = await _context.Reminder
                .AsNoTracking()
                .ToListAsync();

        }
    }
}
