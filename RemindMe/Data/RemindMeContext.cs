using Microsoft.EntityFrameworkCore;
using RemindMe.Models;

namespace RemindMe.Data
{
    public class RemindMeContext : DbContext
    {
        public RemindMeContext(DbContextOptions<RemindMeContext> options) : base(options)
        {

        }

        public DbSet<Calendar> Calendar { get; set; }
        public DbSet<Reminder> Reminder { get; set; }
        public DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var keysProperties = modelBuilder.Model.GetEntityTypes().Select(x => x.FindPrimaryKey()).SelectMany(x => x.Properties);
            foreach (var key in keysProperties)
            {
                key.ValueGenerated = Microsoft.EntityFrameworkCore.Metadata.ValueGenerated.OnAdd;
            }
            modelBuilder.Entity<Reminder>().ToTable("Reminders");
            modelBuilder.Entity<Calendar>().ToTable("Calendar");
            modelBuilder.Entity<Users>().ToTable("User");
        }
    }
}
