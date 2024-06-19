using ProgramsForLearning.Program8.Contracts;

namespace ProgramsForLearning.Program8.Services
{
    public class SmsNotifier : INotifier
    {
        public void Send(string message)
        {
            Console.WriteLine("tu mensaje por sms fue mandado: " + message);

        }
    }
}
