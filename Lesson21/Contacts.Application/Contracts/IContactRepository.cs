using Contacts.Domain;

namespace  Contacts.Application.Contracts
{
    public interface IContactRepository: IRepository<Contact>
    {
        //void Add(Contact contact);
        //void Update(Contact contact);
        //void Delete(int id);
        //Contact GetById(int id);
        //List<Contact> GetAll();
        Task<List<Contact>> GetContactsWithAppointments();
        Task<List<Contact>> GetContactsWithNotifications();
        Task<List<Contact>> GetContactsWithNotificationsAndAppointments();

    }
}
