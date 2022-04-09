using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RemindMe.Pages
{
    public class EditReminders : PageModel
    {
        public void onGet()
        {

        }

        [BindProperty]
        public RemindMeDB.Reminders Description { get; set; }
        public RemindMeDB.Reminders Frequency { get; set; }
        public RemindMeDB.Reminders ReminderName { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        //public async Task<IActionResult> OnPostAsync()
        //{
        //    var emptyReminder = new Reminder();

        //    if (await TryUpdateModelAsync<Reminder>(
        //        emptyReminder,
        //        "reminder",
        //        r => r.Description, r => r.Name, r => r.Frequency, r => r.))
        //}
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return Page();
        //    }

        //    _context.Attach(reminder).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!CalendarExists(reminder.Date))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return RedirectToPage("./Index");
        //}

        //private bool CalendarExists(int id)
        //{
        //    return _context.Calendar.Any(e => e.ID == id);
        //}
    }
}
