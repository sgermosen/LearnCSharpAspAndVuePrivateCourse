using Microsoft.EntityFrameworkCore;
using ProgramsForLearning.HomeWork14.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramsForLearning.HomeWork14.Context
{
    public class ApplicationContext: DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }
        public DbSet<Contact> Contacts { get; set; }
    }
}
