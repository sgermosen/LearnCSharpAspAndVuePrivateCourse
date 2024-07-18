using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Application.Contracts
{
    using Contacts.Domain;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface INotificationService
    {
        Task<IEnumerable<Notification>> GetAllNotifications();
        Task<Notification> GetNotificationById(int id);
        Task AddNotification(Notification notification);
        Task UpdateNotification(Notification notification);
        Task DeleteNotification(int id);
    }

}
