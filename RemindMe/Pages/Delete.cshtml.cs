//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.RazorPages;
//using Microsoft.EntityFrameworkCore;
//using RemindMe.Data;

//namespace RemindMe.Pages.Calendar
//{
//    public class CalendarDelete : PageModel
//    {
//        private readonly RemindMe.Data.RemindMeContext _context;

//        public CalendarDelete(RemindMe.Data.RemindMeContext context)
//        {
//            _context = context;
//        }

//        [BindProperty]
//        public CalendarDelete Calendar { get; set; }

//        public async Task<IActionResult> OnGetAsync(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            Calendar = await _context.Calendar.FirstOrDefaultAsync(m => m.ID == id);

//            if (Calendar == null)
//            {
//                return NotFound();
//            }
//            return Page();
//        }

//        public async Task<IActionResult> OnPostAsync(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            Calendar = await _context.Calendar.FindAsync(id);

//            if (Calendar != null)
//            {
//                _context.Calendar.Remove(Calendar);
//                await _context.SaveChangesAsync();
//            }

//            return RedirectToPage("./Index");
//        }
//    }
//}
