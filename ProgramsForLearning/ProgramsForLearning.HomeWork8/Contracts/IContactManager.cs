using ProgramsForLearning.HomeWork8.Models;

namespace ProgramsForLearning.HomeWork8.Contracts
{
    public interface IContactManager
    {
        //void AddNotification(Contact contact);
        void AddContact(Contact contact);
        void UpdateContact(Contact contact);
        void DeleteContact(int id);
        List<Contact> ListContacts();
    }
}
