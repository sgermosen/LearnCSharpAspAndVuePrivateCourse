using ProgramsForLearning.Program8.Contracts;

namespace ProgramsForLearning.Program8
{
    public class MoneyPayment : IPayment, IValidatePayment //Payment
    {
        //public override void ProcessPayment(decimal amount)
        //{
        //    Console.WriteLine("Su pago en efectivo fue procesado");
        //}
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine("Su pago en efectivo fue procesado");
        }

        public bool Validate()
        {
            return true;
        }
    }
}
