using RemindMe.Models;

namespace RemindMe.Data
{
    public static class DbInitializer
    {
        public static void Initialize(RemindMeContext context)
        {
            context.Database.EnsureCreated();

            // Look for reminders
            if (context.Reminders.Any())
            {
                return; // Seed the database
            }

            var reminders = new Reminders[]
            {
                new Reminders{Description="Take out the trash", Name="Trash reminder", Frequency=1, Date=DateTime.Now.AddDays(4-13-22), Location="Home", Priority="Medium", Time=TimeSpan.FromHours(10)},
                new Reminders{Description="Call Mom", Name="Check on parents", Frequency=1, Date=DateTime.Now.AddDays(4-14-22), Location="Home", Priority="High", Time=TimeSpan.FromHours(6)},
                new Reminders{Description="Wash Clothes", Name="Laundry", Frequency=1, Date=DateTime.Now.AddDays(4-15-22), Location="Home", Priority="High", Time=TimeSpan.FromHours(8)}
            };

            context.Reminders.AddRange(reminders);
            context.SaveChanges();
        }
    }
}
