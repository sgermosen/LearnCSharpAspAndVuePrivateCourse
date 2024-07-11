using Microsoft.EntityFrameworkCore;
using ProgramsForLearning.Program14.Models;

namespace ProgramsForLearning.Program14.Context
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }
        public DbSet<Contact> Contacts { get; set; }
    }
}
