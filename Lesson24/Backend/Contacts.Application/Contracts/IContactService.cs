using Contacts.Application.Dtos.Contacts;
using Contacts.Domain;

namespace Contacts.Application.Contracts
{
    public interface IContactService
    {
        Task<List<Contact>> GetAllContactsAsync();
        Task<Contact> GetContactByIdAsync(int id);
        Task AddContactAsync(Contact contact);
        Task UpdateContactAsync(UpdateContactDto contact);
        Task DeleteContactAsync(int id);
        Task<List<Contact>> GetContactsWithAppointmentsAsync();
        Task<List<Contact>> GetContactsWithNotificationsAsync();
        Task<List<Contact>> GetContactsWithNotificationsAndAppointmentsAsync();
    }

}
