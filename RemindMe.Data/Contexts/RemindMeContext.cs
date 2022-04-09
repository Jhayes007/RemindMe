using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RemindMe.Models;

namespace RemindMe.Data
{
    public class RemindMeContext : DbContext
    {
        public RemindMeContext (DbContextOptions<RemindMeContext> options)
            : base(options)
        {
        }

        public DbSet<RemindMe.Models.Calendar> Calendar { get; set; }
    }
}
