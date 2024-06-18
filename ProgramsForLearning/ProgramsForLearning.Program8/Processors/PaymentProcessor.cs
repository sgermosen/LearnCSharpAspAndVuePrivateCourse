using ProgramsForLearning.Program8.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
