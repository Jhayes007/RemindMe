using Microsoft.EntityFrameworkCore;

namespace RemindMe.RemindMeDB
{
    public partial class ToDoDBContext : DbContext
    {
        public ToDoDBContext()
        {
        }

        public ToDoDBContext(DbContextOptions<ToDoDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Calendar> Calendars { get; set; }
        public virtual DbSet<Reminders> Reminders { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-KFDFE37\\SQLEXPRESS;Database=ToDoDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Calendar>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Calendar", "ToDoApplication");

                entity.HasComment("ASimpleCalendar");

                entity.Property(e => e.Month)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Reminders>(entity =>
            {
                entity.HasKey(e => e.Name);

                entity.ToTable("Reminders", "ToDoApplication");

                entity.HasComment("UserReminders");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Priority).HasMaxLength(50);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User", "ToDoApplication");

                entity.HasComment("ToDoUserRecords");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.Email).IsRequired();

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PasswordHash)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
