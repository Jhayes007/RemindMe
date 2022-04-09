using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RemindMe.Data;
using RemindMe.Common.DatabaseModels;

namespace RemindMe.Pages.Calendar
{
    public class IndexModel : PageModel
    {
        private readonly RemindMe.Data.RemindMeContext _context;

        public IndexModel(RemindMe.Data.RemindMeContext context)
        {
            _context = context;
        }

        public IList<Pages_Calendar_Index> Calendar { get;set; }

        public async Task OnGetAsync()
        {
            Calendar = (IList<Pages_Calendar_Index>)await _context.Calendar.ToListAsync();
        }
    }
}
