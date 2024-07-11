using ProgramsForLearning.Program14.Models;

namespace ProgramsForLearning.Program14.Contracts
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
