using ProgramsForLearning.HomeWork14.Models;

namespace ProgramsForLearning.HomeWork14.Contracts
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
