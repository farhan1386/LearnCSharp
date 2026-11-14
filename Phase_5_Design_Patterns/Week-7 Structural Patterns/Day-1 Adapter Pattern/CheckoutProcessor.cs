using System;
using Phase_5_Design_Patterns.Week_7_Structural_Patterns.Adapter_Pattern.Domain;
using Phase_5_Design_Patterns.Week_7_Structural_Patterns.Adapter_Pattern.Interfaces;

namespace Phase_5_Design_Patterns.Week_7_Structural_Patterns
{
    public class CheckoutProcessor
    {
        private readonly IPaymentGatewayTarget _paymentGateway;

        public CheckoutProcessor(IPaymentGatewayTarget paymentGateway)
        {
            _paymentGateway = paymentGateway ?? throw new ArgumentNullException(nameof(paymentGateway));
        }

        public void ExecuteCheckout(TransactionRequest request)
        {
            Console.WriteLine($"[Core Platform] Initiating transactional workflow for Order: {request.OrderId}");
            _paymentGateway.ProcessPayment(request);
        }
    }
}