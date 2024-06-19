using ProgramsForLearning.Program9.Models;

namespace ProgramsForLearning.Program9.Contracts
{
    public interface INotificationRepository
    {
        Notification GetById(int id);
        List<Notification> GetAll();
        void Add(Notification contact);
        void Update(Notification contact);
        void Delete(int id);
     
    }
}
