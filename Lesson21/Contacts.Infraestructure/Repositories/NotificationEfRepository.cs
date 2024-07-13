using Contacts.Application.Contracts;
using Contacts.Domain;
using Contacts.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Infraestructure.Repositories
{
    public class NotificationEfRepository : Repository<Notification>, IRepository<Notification>
    {
        private readonly ApplicationContext _context;

        public NotificationEfRepository(ApplicationContext context) : base(context)
        {
            _context = context;
        }

    }
}
