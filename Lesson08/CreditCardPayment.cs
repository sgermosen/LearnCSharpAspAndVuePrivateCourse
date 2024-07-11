using ProgramsForLearning.Program8.Contracts;

namespace ProgramsForLearning.Program8
{
    public class CreditCardPayment : IPayment, IValidatePayment// Payment
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine("Tu pago con trajeta de credito ha sido procesado");
        }

        public bool Validate()
        {
            return true;
        }
    }
}
