using Phase_5_Design_Patterns.Week_6_Creational_Design_Patterns.Builder.Contracts;

namespace Phase_5_Design_Patterns.Week_5_Creational_Design_Patterns.Builder.Interfaces
{
    public interface IOrderBuilder
    {
        IOrderBuilder InitializeOrder(string orderId, string customerId, string sku, int quantity);
        IOrderBuilder ApplyPromoCode(string promoCode);
        IOrderBuilder EnableGiftWrap();
        IOrderBuilder AddDeliveryNotes(string notes);
        OrderManifest Build();
    }
}
