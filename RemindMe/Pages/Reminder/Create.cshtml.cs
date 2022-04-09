using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RemindMe.Models;

namespace RemindMe.Pages.CreateReminder
{
    public class CreateModel : PageModel
    {
        private readonly RemindMe.Data.RemindMeContext _context;

        public CreateModel(RemindMe.Data.RemindMeContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {

            Reminder = new Reminders { Description = "Take out the trash", Name = "Trash reminder", Frequency = 1, Date = DateTime.Today, Location = "Home", Priority = "High", Time = TimeSpan.MinValue };

            return Page();

        }


        [BindProperty]
        public Reminders Reminder { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Reminder = new Reminders { Description = "Take out the trash", Name = "Trash reminder", Frequency = 1, Date = DateTime.Today, Location = "Home", Priority = "High", Time = TimeSpan.MinValue };
            _context.Reminders.Add(Reminder);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
