using System;

namespace Phase_5_Design_Patterns.Week_7_Structural_Patterns.Adapter_Pattern.Adaptee
{
    public class AdvancedPaymentSDK
    {
        public class VendorOrderInfo
        {
            public string ReferenceId { get; set; } = string.Empty;
        }

        public class VendorFinancials
        {
            public int AmountInCents { get; set; }
            public string CurrencyCode { get; set; } = string.Empty;
        }

        public class VendorPaymentPayload
        {
            public VendorOrderInfo OrderDetails { get; set; } = new VendorOrderInfo();
            public VendorFinancials FinancialDetails { get; set; } = new VendorFinancials();
        }

        public void ProcessVendorTransaction(VendorPaymentPayload payload)
        {
            Console.WriteLine($"[SDK Success] Processed ${payload.FinancialDetails.AmountInCents / 100.0} via vendor network for Ref: {payload.OrderDetails.ReferenceId}");
        }
    }
}