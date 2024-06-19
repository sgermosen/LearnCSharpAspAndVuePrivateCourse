using ProgramsForLearning.HomeWork8.Contracts;

namespace ProgramsForLearning.HomeWork8.Services
{
    public class EmailNotificationService : INotificationService
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"Email enviado: {message}");
        }
    }
}
