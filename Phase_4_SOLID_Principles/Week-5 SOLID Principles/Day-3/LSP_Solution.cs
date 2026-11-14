using System;
using System.Collections.Generic;

namespace Phase_4_SOLID_Principles.Week_5_SOLID_Principles
{
    public class LSP_Solution
    {
        public static void Run()
        {
            var onlineGateways = new List<IOnlinePaymentGateway>
            {
                new RemediationCreditCardPayment()
            };

            foreach (var liveGateway in onlineGateways)
            {
                liveGateway.CaptureOnlinePayment(150.00);
            }

            var paymentAccounts = new List<PaymentAccount>
            {
                new RemediationCreditCardPayment(),
                new RemediationStoreCreditPayment()
            };

            foreach (var account in paymentAccounts)
            {
                account.PrintReceiptHeader();
            }
        }
    }

    public abstract class PaymentAccount
    {
        public void PrintReceiptHeader() =>
            Console.WriteLine("--- Transaction Log Entry ---");
    }

    public interface IOnlinePaymentGateway
    {
        void CaptureOnlinePayment(double amount);
    }

    public class RemediationCreditCardPayment : PaymentAccount, IOnlinePaymentGateway
    {
        public void CaptureOnlinePayment(double amount) =>
            Console.WriteLine($"Successfully charged ${amount} via Merchant API.");
    }

    public class RemediationStoreCreditPayment : PaymentAccount
    {
        public void DeductFromInternalBalance(double amount) =>
            Console.WriteLine($"Subtracted ${amount} from client internal ledger.");
    }
}