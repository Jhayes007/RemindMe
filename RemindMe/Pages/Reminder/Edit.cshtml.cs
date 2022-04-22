using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RemindMe.Data;

namespace RemindMe.Pages.EditReminder
{
    public class EditModel : PageModel
    {
        private readonly RemindMeContext _context;

        public EditModel(RemindMeContext context)
        {
            _context = context;
        }


        [BindProperty]
        public Models.Reminders Reminder { get; set; }


        public async Task<IActionResult> OnGetAsync(string? name)
        {
            if (name == null)
            {
                return NotFound();
            }

            Reminder = await _context.Reminders.FindAsync(name);

            if (Reminder == null)
            {
                return NotFound();
            }
            return Page();

        }

        public async Task<IActionResult> OnPostAsync(string name)
        {
            var reminderToUpdate = await _context.Reminders.FindAsync(name);

            if (reminderToUpdate == null)
            {
                return NotFound();
            }

            if (await TryUpdateModelAsync<Models.Reminders>(
                reminderToUpdate,
                "reminder",
                s => s.Name, s => s.Description, s => s.Frequency))
            {
                await _context.SaveChangesAsync();
                return RedirectToPage("/Index");
            }

            return Page();
        }
    }
}



