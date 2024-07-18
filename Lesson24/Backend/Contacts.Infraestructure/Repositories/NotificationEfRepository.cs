using Contacts.Application.Contracts;
using Contacts.Domain;
using Contacts.Persistence;

namespace Contacts.Infraestructure.Repositories
{
    public class NotificationEfRepository : Repository<Notification>, IRepository<Notification>
    {

        public NotificationEfRepository(ApplicationContext context) : base(context)
        {
        }

    }
}
