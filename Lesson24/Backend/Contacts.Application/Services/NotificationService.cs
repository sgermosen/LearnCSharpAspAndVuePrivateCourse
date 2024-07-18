namespace Contacts.Application.Services
{
    using Contacts.Application.Contracts;
    using Contacts.Domain;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class NotificationService : INotificationService
    {
        private readonly IRepository<Notification> _notificationRepository;

        public NotificationService(IRepository<Notification> notificationRepository)
        {
            _notificationRepository = notificationRepository;
        }

        public async Task<IEnumerable<Notification>> GetAllNotifications()
        {
            return await _notificationRepository.GetAll();
        }

        public async Task<Notification> GetNotificationById(int id)
        {
            return await _notificationRepository.GetById(id);
        }

        public async Task AddNotification(Notification notification)
        {
            await _notificationRepository.Add(notification);
        }

        public async Task UpdateNotification(Notification notification)
        {
            await _notificationRepository.Update(notification);
        }

        public async Task DeleteNotification(int id)
        {
            await _notificationRepository.Delete(id);
        }
    }

}
