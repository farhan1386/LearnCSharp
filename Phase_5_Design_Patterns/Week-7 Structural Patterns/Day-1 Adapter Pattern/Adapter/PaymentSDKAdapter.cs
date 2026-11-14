using System;
using Phase_5_Design_Patterns.Week_7_Structural_Patterns.Adapter_Pattern.Adaptee;
using Phase_5_Design_Patterns.Week_7_Structural_Patterns.Adapter_Pattern.Domain;
using Phase_5_Design_Patterns.Week_7_Structural_Patterns.Adapter_Pattern.Interfaces;

namespace Phase_5_Design_Patterns.Week_7_Structural_Patterns.Adapter_Pattern.Adapter
{
    public class PaymentSDKAdapter : IPaymentGatewayTarget
    {
        private readonly AdvancedPaymentSDK _advancedSDK;

        public PaymentSDKAdapter(AdvancedPaymentSDK advancedSDK)
        {
            _advancedSDK = advancedSDK ?? throw new ArgumentNullException(nameof(advancedSDK));
        }

        public void ProcessPayment(TransactionRequest request)
        {
            var nestedPayload = new AdvancedPaymentSDK.VendorPaymentPayload
            {
                OrderDetails = new AdvancedPaymentSDK.VendorOrderInfo
                {
                    ReferenceId = request.OrderId ?? string.Empty
                },
                FinancialDetails = new AdvancedPaymentSDK.VendorFinancials
                {
                    AmountInCents = (int)(request.TotalAmount * 100),
                    CurrencyCode = request.Currency.ToString()
                }
            };

            _advancedSDK.ProcessVendorTransaction(nestedPayload);
        }
    }
}