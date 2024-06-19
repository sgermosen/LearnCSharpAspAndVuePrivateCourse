using ProgramsForLearning.Program9.Contracts;
using ProgramsForLearning.Program9.Models;

namespace ProgramsForLearning.Program9.Repositories
{
    public class NotificationRepository : INotificationRepository
    {
        private readonly List<Notification> _notifications = new List<Notification>();

        public Notification GetById(int id)
        {
            return _notifications.Where(c => c.Id == id).FirstOrDefault();
        }

        public List<Notification> GetAll()
        {
            return _notifications;
        }

        public void Add(Notification contact)
        {
            int newId = _notifications.Count + 1;
            contact.Id = newId;
            _notifications.Add(contact);
        }

        public void Update(Notification contact)
        {
            Notification existingContact = GetById(contact.Id);

            if (existingContact != null)
            {
                existingContact.Message = contact.Message;
                 
                _notifications.RemoveAt(contact.Id - 1);
                _notifications.Add(existingContact);
            }
        }

        public void Delete(int id)
        {
            Notification existingContact = GetById(id);

            if (existingContact != null)
            {
                _notifications.RemoveAt(id - 1);
            }
        }

    }
}
