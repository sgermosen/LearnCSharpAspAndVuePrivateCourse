using ProgramsForLearning.HomeWork8.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
