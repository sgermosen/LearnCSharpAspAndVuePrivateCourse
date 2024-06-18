using ProgramsForLearning.Program8.Contracts;

namespace ProgramsForLearning.Program8.Factories
{
    public interface IPaymentFactory
    {
        IPayment CreatePayment();
    }

    public class MoneyPaymentFactory : IPaymentFactory
    {
        public IPayment CreatePayment()
        {
            return new MoneyPayment();
        }
    }

    public class CreditCardPaymentFactory : IPaymentFactory
    {
        public IPayment CreatePayment()
        {
            return new CreditCardPayment();
        }
    }
}
