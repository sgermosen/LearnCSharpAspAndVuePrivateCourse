using ProgramsForLearning.HomeWork8.Contracts;
using ProgramsForLearning.HomeWork8.Models;

namespace ProgramsForLearning.HomeWork8.Services
{
    public class ContactManagerWithNotification : IContactManager
    {
        private readonly IContactManager _contactManager;
        private readonly INotificationService _notificationService;

        public ContactManagerWithNotification(IContactManager contactManager, INotificationService notificationService)
        {
            _contactManager = contactManager;
            _notificationService = notificationService;
        }
        public void AddContact(Contact contact)
        {
            _contactManager.AddContact(contact);
            _notificationService.SendNotification("Usuario Creado");
        }

        public void DeleteContact(int id)
        {
            _contactManager.DeleteContact(id);
            _notificationService.SendNotification("Usuario Eliminado");

        }

        public List<Contact> ListContacts()
        {
            return _contactManager.ListContacts();
        }

        public void UpdateContact(Contact contact)
        {
            _contactManager.UpdateContact(contact);
            _notificationService.SendNotification("Usuario Actualizado");

        }
    }
}
