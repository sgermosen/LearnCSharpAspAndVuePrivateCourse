using Contacts.Application.Contracts;
using Contacts.Domain;
using Contacts.Persistence;

namespace Contacts.Infraestructure.Repositories
{
    public class AppointmentEfRepository : Repository<Appointment>, IRepository<Appointment>
    { 
        public AppointmentEfRepository(ApplicationContext context) : base(context)
        { 
        }

    }
}
