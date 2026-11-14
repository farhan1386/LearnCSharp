using Phase_5_Design_Patterns.Week_5_Creational_Design_Patterns.Builder.Interfaces;
using Phase_5_Design_Patterns.Week_6_Creational_Design_Patterns.Builder.Concretes;
using Phase_5_Design_Patterns.Week_6_Creational_Design_Patterns.Builder.Contracts;

namespace Phase_5_Design_Patterns.Week_6_Creational_Design_Patterns.Builder
{
    public class Builder_Pattern
    {
        public static void Run()
        {
            IOrderBuilder builder = new OrderManifestBuilder();

            Console.WriteLine("--- Initializing Encapsulated Order Construction Pipeline --- \n");

            // Safe, self-documenting, readable object configuration assembly completely immune to parameter swapping
            OrderManifest freshOrder = builder
                .InitializeOrder("ORD-8812", "CUST-9904", "SNK-NIKE-PRO-01", 2)
                .ApplyPromoCode("DISCOUNT20")
                .EnableGiftWrap()
                .AddDeliveryNotes("Leave at side door")
                .Build();

            Console.WriteLine($"[Success] Order {freshOrder.OrderId} built cleanly. Coupon applied: {freshOrder.PromoCode}");
        }
    }
}
