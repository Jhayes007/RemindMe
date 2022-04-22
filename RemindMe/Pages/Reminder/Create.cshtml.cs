using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RemindMe.Pages.CreateReminder
{
    public class CreateModel : PageModel
    {
        private readonly Data.RemindMeContext _context;

        public CreateModel(Data.RemindMeContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {

            Reminder = new Models.Reminders { };

            return Page();

        }


        [BindProperty]
        public Models.Reminders Reminder { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {

            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Reminders.Add(Reminder);
            await _context.SaveChangesAsync();

            return RedirectToPage("/Index");

        }
    }
}
