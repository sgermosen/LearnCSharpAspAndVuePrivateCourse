using Contacts.Domain;
using Microsoft.EntityFrameworkCore;

namespace Contacts.Persistence
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Notification> Notifications { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>()
                .HasMany(c => c.Appointments)
                .WithOne(a => a.Contact)
                .HasForeignKey(a => a.ContactId);

            modelBuilder.Entity<Contact>().Property(p => p.LastName).IsRequired();

            modelBuilder.Entity<Contact>()
                .HasMany(c => c.Notifications)
                .WithOne(n => n.Contact)
                .HasForeignKey(n => n.ContactId);
              
            base.OnModelCreating(modelBuilder);
        }
    }
}
