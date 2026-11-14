using Phase_5_Design_Patterns.Week_7_Structural_Patterns.Adapter_Pattern.Adaptee;
using Phase_5_Design_Patterns.Week_7_Structural_Patterns.Adapter_Pattern.Domain;
using Phase_5_Design_Patterns.Week_7_Structural_Patterns.Adapter_Pattern.Enums;
using System;

namespace Phase_5_Design_Patterns.Week_7_Structural_Patterns.Adapter_Pattern_Violation
{
    public class Adapter_Pattern_Violation
    {
        // Marked public so it can be called from your main Program entry point
        public static void Run()
        {
            Console.WriteLine("--- RUNNING VIOLATION PIPELINE (TIGHTLY COUPLED) ---");

            // 1. Direct creation of the incompatible SDK dependency
            AdvancedPaymentSDK thirdPartySDK = new AdvancedPaymentSDK();

            // 2. Client processor depends directly on the concrete SDK instance instead of an interface
            CheckoutProcessorViolation platform = new CheckoutProcessorViolation(thirdPartySDK);

            // 3. Preparing internal application domain data format
            TransactionRequest standardOrder = new TransactionRequest
            {
                OrderId = "ORD-VIOLATION-99542",
                TotalAmount = 79.99m,
                Currency = Currency.USD
            };

            // Run the method showing the bad architectural design pattern
            platform.ExecuteViolatedCheckout(standardOrder);
        }
    }

    // =========================================================================
    // THE VIOLATION CLASS: Directly ties business rules to external vendor SDK contracts
    // =========================================================================
    public class CheckoutProcessorViolation
    {
        // VIOLATION: Hard binding to a concrete external SDK class instead of an interface
        private readonly AdvancedPaymentSDK _directSDK;

        public CheckoutProcessorViolation(AdvancedPaymentSDK directSDK)
        {
            _directSDK = directSDK ?? throw new ArgumentNullException(nameof(directSDK));
        }

        public void ExecuteViolatedCheckout(TransactionRequest request)
        {
            Console.WriteLine($"[Violated Platform] Initiating tight integration workflow for Order: {request.OrderId}");

            // CRITICAL DESIGN VIOLATION 1: Business logic layers are explicitly polluted with 
            // structural knowledge of third-party nested entities (VendorPaymentPayload, VendorOrderInfo, etc.)
            var legacyPayload = new AdvancedPaymentSDK.VendorPaymentPayload
            {
                OrderDetails = new AdvancedPaymentSDK.VendorOrderInfo
                {
                    ReferenceId = request.OrderId ?? string.Empty
                },
                FinancialDetails = new AdvancedPaymentSDK.VendorFinancials
                {
                    // CRITICAL DESIGN VIOLATION 2: Data mutation, business assumptions (dollars to cents conversion), 
                    // and enum translations are leaking directly into application handlers instead of an isolated adapter class.
                    AmountInCents = (int)(request.TotalAmount * 100),
                    CurrencyCode = request.Currency.ToString()
                }
            };

            // CRITICAL DESIGN VIOLATION 3: Bound to a proprietary method signature name. 
            // If the provider changes tomorrow, this whole core application pipeline breaks.
            _directSDK.ProcessVendorTransaction(legacyPayload);
        }
    }
}