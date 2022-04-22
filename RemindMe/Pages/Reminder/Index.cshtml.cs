using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RemindMe.Data;

namespace RemindMe.Pages.Reminder
{
    public class IndexModel : PageModel
    {
        private readonly RemindMeContext _context;

        public IndexModel(RemindMeContext context)
        {
            _context = context;
        }

        public IList<Models.Reminders> Reminders { get; set; }

        public async Task OnGetAsync()
        {
            Reminders = await _context.Reminders
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
