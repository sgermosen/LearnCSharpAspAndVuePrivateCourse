using Contacts.Domain;

namespace  Contacts.Application.Contracts
{
    public interface IContactRepository
    {
        void Add(Contact contact);
        void Update(Contact contact);
        void Delete(int id);
        Contact GetById(int id);
        List<Contact> GetAll();
    }
}
