using Contacts.Application.Contracts;
using Contacts.Domain;
using Contacts.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Contacts.Infraestructure.Repositories
{
    public class ContactEfRepository : Repository<Contact>, IContactRepository
    {
        private readonly ApplicationContext _context;
        public ContactEfRepository(ApplicationContext context) : base(context)
        {
            _context = context;
        }


        public async Task<List<Contact>> GetContactsWithAppointments()
        {
            return await _context.Contacts
                .Include(c => c.Appointments).ToListAsync();
        }

        public async Task<List<Contact>> GetContactsWithNotifications()
        {
            return await _context.Contacts
                .Include(c => c.Notifications).ToListAsync();
        }


        public async Task<List<Contact>> GetContactsWithNotificationsAndAppointments()
        {
            return await _context.Contacts
                .Include(c => c.Appointments)
                .Include(c => c.Notifications)
                .ToListAsync();

        }

    }
}