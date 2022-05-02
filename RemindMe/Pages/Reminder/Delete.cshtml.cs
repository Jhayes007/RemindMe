using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RemindMe.Data;

namespace RemindMe.Pages.Reminder
{
    public class DeleteModel : PageModel
    {
        private readonly RemindMeContext _context;

        public DeleteModel(RemindMeContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Models.Reminder Reminder { get; set; }

        public async Task<IActionResult> OnGetAsync(string? name)
        {

            Reminder = await _context.Reminder.FirstOrDefaultAsync(m => m.Name == name);

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string? name)
        {

            Reminder = await _context.Reminder.FindAsync(name);

            if (Reminder != null)
            {
                _context.Reminder.Remove(Reminder);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("/Index");
        }
    }
}
