using ProgramsForLearning.Program8.Contracts;

namespace ProgramsForLearning.Program8.Services
{
    public class NotificationService
    {
        private readonly INotifier _notifier;

        public NotificationService(INotifier notifier)
        {
            _notifier = notifier;
        }

        public void Notify(string message)
        {
            _notifier.Send(message);
        } 
    }
}
