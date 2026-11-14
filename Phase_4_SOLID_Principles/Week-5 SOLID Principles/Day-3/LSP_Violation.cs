using System;
using System.Collections.Generic;

namespace Phase_4_SOLID_Principles.Week_5_SOLID_Principles
{
    public class LSP_Violation
    {
        public static void Run()
        {
            var cartItems = new List<IPaymentGateway>
            {
                new CreditCardPayment(),
                new StoreCreditPayment() // ❌ Breaks substitution rules!
            };

            foreach (var gateway in cartItems)
            {
                // ❌ BOOM! The loop crashes when it hits StoreCreditPayment.
                // The client expected ALL gateways to support CaptureOnlinePayment().
                gateway.CaptureOnlinePayment(150.00);
            }
        }
    }

    public interface IPaymentGateway
    {
        void CaptureOnlinePayment(double amount);
    }

    public class CreditCardPayment : IPaymentGateway
    {
        public void CaptureOnlinePayment(double amount) =>
            Console.WriteLine($"Successfully charged ${amount} via Merchant API.");
    }

    public class StoreCreditPayment : IPaymentGateway
    {
        public void CaptureOnlinePayment(double amount)
        {
            // ❌ Violation: Forcing an inappropriate behavior onto a subclass
            // which breaks the expectation of the base interface contract.
            throw new NotSupportedException("Store credit cannot process online bank gateways!");
        }
    }
}