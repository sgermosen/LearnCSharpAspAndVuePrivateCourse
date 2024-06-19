using ProgramsForLearning.HomeWork8.Contracts;

namespace ProgramsForLearning.HomeWork8.Services
{
    public class SmsNotificationService : INotificationService
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"SMS enviado: {message}");
        }
    }
}
