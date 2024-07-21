using Contacts.Application.Responses.Contacts;
using Contacts.Application.Responses;
using Contacts.Domain;

namespace Contacts.Application.Contracts
{
    public interface IContactService
    {
        Task<List<Contact>> GetAllContacts();
        Task<Response<ContactResponse>> GetContactById(int id);
        Task AddContact(Contact contact);
        Task UpdateContact(Contact contact);
        Task DeleteContact(int id);
        Task<List<Contact>> GetContactsWithAppointments();
        Task<List<Contact>> GetContactsWithNotifications();
        Task<List<Contact>> GetContactsWithNotificationsAndAppointments();
    }

}
