using ProgramsForLearning.Program8.Contracts;
using ProgramsForLearning.Program8.Factories;
using ProgramsForLearning.Program8.Processors;
using ProgramsForLearning.Program8.Services;

namespace ProgramsForLearning.Program8
{ 
    public class Program
    {

        public static void Main(string[] args)
        {

            var calculatorInstance = new CalculatorWithLogic();
            var client = new CalculatorEvolved(calculatorInstance);
            client.MakeOperations(20, 0);

            IPayment payment;
            Console.WriteLine("Digite un metodo de pago: 1. Tarjeta, 2. Efectivo");
            var typeOption = Convert.ToInt32(Console.ReadLine());
            if (typeOption == 1)
            {
                payment = new CreditCardPayment();
            }
            else
            {
                payment = new MoneyPayment();
            }

            var creditCardFactory = new CreditCardPaymentFactory();
            var moneyFactory = new MoneyPaymentFactory();

            var creditCardProcessor = new PaymentProcessor(creditCardFactory);
            var moneyProcessor = new PaymentProcessor(moneyFactory);

            creditCardProcessor.ProcessPayment(1500);
            moneyProcessor.ProcessPayment(50);



            var emaillNotifier = new EmailNotifier();
            var smsNotifier = new SmsNotifier();

            var emailService = new NotificationService(emaillNotifier);
            var smsService = new NotificationService(smsNotifier);

            emailService.Notify("Hola Desde el email");
            smsService.Notify("Hola Desde el mensaje de texto");

            payment.ProcessPayment(15);
        }
    }
}