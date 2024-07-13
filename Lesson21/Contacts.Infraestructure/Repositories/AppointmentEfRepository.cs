using Contacts.Application.Contracts;
using Contacts.Domain;
using Contacts.Persistence;

namespace Contacts.Infraestructure.Repositories
{
    public class AppointmentEfRepository : Repository<Appointment>, IRepository<Appointment>
    {
        private readonly ApplicationContext _context;

        public AppointmentEfRepository(ApplicationContext context) : base(context)
        {
            _context = context;
        }

    }
}
