using Contacts.Domain;
using Microsoft.EntityFrameworkCore;

namespace Contacts.Persistence
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }
        public DbSet<Contact> Contacts { get; set; }
    }
}
