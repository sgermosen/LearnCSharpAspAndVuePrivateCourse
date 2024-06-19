using ProgramsForLearning.Program9.Models;

namespace ProgramsForLearning.Program9.Contracts
{
    public interface IContactRepository
    {
        Contact GetById(int id);
        List<Contact> GetAll();
        void Add(Contact contact);
        void Update(Contact contact);
        void Delete(int id);
     
    }
}
