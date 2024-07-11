using ProgramsForLearning.Program8.Factories;

namespace ProgramsForLearning.Program8.Processors
{
    public class PaymentProcessor
    {
        private readonly IPaymentFactory _paymentFactory;

        public PaymentProcessor(IPaymentFactory paymentFactory)
        {
            _paymentFactory = paymentFactory;
        }
        public void ProcessPayment(decimal ammount)
        {
            var payment = _paymentFactory.CreatePayment();
            payment.ProcessPayment(ammount);
        }
    }
}
