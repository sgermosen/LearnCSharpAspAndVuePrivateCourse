using Contacts.Application.Dtos.Contacts;
using Contacts.Domain;

namespace Contacts.Application.Contracts
{
    public interface IContactService
    {
        Task<List<Contact>> GetAllContacts();
        Task<Contact> GetContactById(int id);
        Task AddContact(Contact contact);
        Task UpdateContact(UpdateContactDto contact);
        Task DeleteContact(int id);
        Task<List<Contact>> GetContactsWithAppointments();
        Task<List<Contact>> GetContactsWithNotifications();
        Task<List<Contact>> GetContactsWithNotificationsAndAppointments();
    }

}
