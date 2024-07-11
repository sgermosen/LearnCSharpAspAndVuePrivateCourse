using ProgramsForLearning.Program8.Contracts;

namespace ProgramsForLearning.Program8.Services
{
    public class EmailNotifier : INotifier
    {
        public void Send(string message)
        {
            Console.WriteLine("tu mensaje por email fue mandado: " + message);
        }
    }
}
