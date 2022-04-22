using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RemindMe.Data;

namespace RemindMe.Pages.DeleteReminder
{
    public class DeleteModel : PageModel
    {
        private readonly RemindMeContext _context;

        public DeleteModel(RemindMeContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Models.Reminders Reminder { get; set; }

        public async Task<IActionResult> OnGetAsync(string? name)
        {
            //if (name == null)
            //{
            //    return NotFound();
            //}

            Reminder = await _context.Reminders.FirstOrDefaultAsync(m => m.Name == name);

            //if (Reminder == null)
            //{
            //    return NotFound();
            //}
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string? name)
        {
            //if (name == null)
            //{
            //    return NotFound();
            //}

            Reminder = await _context.Reminders.FindAsync(name);

            if (Reminder != null)
            {
                _context.Reminders.Remove(Reminder);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("/Index");
        }
    }
}
