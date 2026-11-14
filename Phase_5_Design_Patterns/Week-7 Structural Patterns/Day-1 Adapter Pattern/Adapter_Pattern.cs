using Phase_5_Design_Patterns.Week_7_Structural_Patterns.Adapter_Pattern.Adaptee;
using Phase_5_Design_Patterns.Week_7_Structural_Patterns.Adapter_Pattern.Adapter;
using Phase_5_Design_Patterns.Week_7_Structural_Patterns.Adapter_Pattern.Domain;
using Phase_5_Design_Patterns.Week_7_Structural_Patterns.Adapter_Pattern.Enums;
using Phase_5_Design_Patterns.Week_7_Structural_Patterns.Adapter_Pattern.Interfaces;

namespace Phase_5_Design_Patterns.Week_7_Structural_Patterns.Adapter_Pattern
{
    public class Adapter_Pattern
    {
        public static void Run()
        {
            Console.WriteLine("Executing decoupled e-commerce workflow:");

            AdvancedPaymentSDK thirdPartySDK = new AdvancedPaymentSDK();
            IPaymentGatewayTarget adapterLayer = new PaymentSDKAdapter(thirdPartySDK);

            CheckoutProcessor platform = new CheckoutProcessor(adapterLayer);

            TransactionRequest standardOrder = new TransactionRequest
            {
                OrderId = "ORD-99542",
                TotalAmount = 79.99m,
                Currency = Currency.USD
            };

            platform.ExecuteCheckout(standardOrder);
        }
    }
}