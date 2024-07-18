using Contacts.Domain;

namespace  Contacts.Application.Contracts
{
    public interface IContactRepository: IRepository<Contact>
    { 
        Task<List<Contact>> GetContactsWithAppointments();
        Task<List<Contact>> GetContactsWithNotifications();
        Task<List<Contact>> GetContactsWithNotificationsAndAppointments();
        Task<Contact> GetByIdNoTrackeable(int id);

    }
}
