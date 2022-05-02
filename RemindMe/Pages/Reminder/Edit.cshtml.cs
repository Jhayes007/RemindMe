using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RemindMe.Data;

namespace RemindMe.Pages.Reminder
{
    public class EditModel : PageModel
    {
        private readonly RemindMeContext _context;

        public EditModel(RemindMeContext context)
        {
            _context = context;
        }


        [BindProperty]
        public Models.Reminder Reminder { get; set; }

        public async Task<IActionResult> OnGetAsync(string? name)
        {

            Reminder = await _context.Reminder.FirstOrDefaultAsync(x => x.Name == name);
            return Page();

        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Reminder).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReminderExists(Reminder.Name))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("/Index");
        }
        private bool ReminderExists(string name)
        {
            return _context.Reminder.Any(r => r.Name == name);
        }
    }
}



