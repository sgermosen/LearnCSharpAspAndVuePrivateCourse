using ProgramsForLearning.Program10.Models;

namespace ProgramsForLearning.Program10.Contracts
{
    public interface IContacManager
    {
        Contact GetContactById(int id);
        List<Contact> GetContacts();
        void AddContact(Contact contact);
        void UpdateContact(Contact contact);
        void DeleteContact(int id);
        Contact GetContactByName(string name);
        List<Contact> GetContactsSortedByName();
    }
}
