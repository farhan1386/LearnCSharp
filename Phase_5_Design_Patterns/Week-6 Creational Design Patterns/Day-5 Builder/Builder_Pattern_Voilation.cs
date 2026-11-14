using System;
using System.Collections.Generic;
using System.Text;

namespace Phase_5_Design_Patterns.Week_6_Creational_Design_Patterns.Builder_Pattern_Voilation
{
    /// <summary>
    /// ANTI-PATTERN: Telescoping Constructor (Builder Pattern Violation).
    /// This implementation forces multi-parameter object instantiation through a rigid chain of 
    /// overloaded constructors. It is highly unreadable, error-prone due to positional parameter 
    /// swapping hazards, and breaks easily when new optional checkout requirements are added.
    /// </summary>
    public class Builder_Pattern_Voilation
    {
        public static void Run()
        {
            // ❌ Brittle, highly unreadable assignment filled with positional parameter hazards and magic literals.
            // Accidentally swapping the "DISCOUNT20" and "Leave at side door" strings compiles cleanly 
            // but instantly corrupts your business logic and discount evaluation runs.
            var legacyOrder = new OrderManifestViolation(
                "ORD-8812",
                "CUST-9904",
                "SNK-NIKE-PRO-01",
                2,
                "DISCOUNT20",
                true,
                "Leave at side door"
            );

            Console.WriteLine($"Legacy violation order {legacyOrder.OrderId} instantiated via telescoping mechanics.");
        }

        public class OrderManifestViolation
        {
            public string OrderId { get; }
            public string CustomerId { get; }
            public string Sku { get; }
            public int Quantity { get; }
            public string PromoCode { get; }
            public bool IsGiftWrapped { get; }
            public string Notes { get; }

            // ❌ Overload 1: Minimum baseline parameters
            public OrderManifestViolation(string orderId, string customerId, string sku, int quantity)
            {
                OrderId = orderId;
                CustomerId = customerId;
                Sku = sku;
                Quantity = quantity;
                PromoCode = "None";
                IsGiftWrapped = false;
                Notes = string.Empty;
            }

            // ❌ Overload 2: Adding a promotional code modifier
            public OrderManifestViolation(string orderId, string customerId, string sku, int quantity, string promoCode)
                : this(orderId, customerId, sku, quantity)
            {
                PromoCode = promoCode;
            }

            // ❌ Overload 3: Adding gift wrapping flag options
            public OrderManifestViolation(string orderId, string customerId, string sku, int quantity, string promoCode, bool isGiftWrapped)
                : this(orderId, customerId, sku, quantity, promoCode)
            {
                IsGiftWrapped = isGiftWrapped;
            }

            // ❌ Overload 4: The full telescoping nightmare. Adding even one more field forces a signature rewrite.
            public OrderManifestViolation(string orderId, string customerId, string sku, int quantity, string promoCode, bool isGiftWrapped, string notes)
                : this(orderId, customerId, sku, quantity, promoCode, isGiftWrapped)
            {
                Notes = notes;
            }
        }
    }
}