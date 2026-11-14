using Phase_5_Design_Patterns.Week_5_Creational_Design_Patterns.Builder.Interfaces;
using Phase_5_Design_Patterns.Week_6_Creational_Design_Patterns.Builder.Contracts;

namespace Phase_5_Design_Patterns.Week_6_Creational_Design_Patterns.Builder.Concretes
{
    public class OrderManifestBuilder : IOrderBuilder
    {
        private OrderManifest _order = new OrderManifest();

        public IOrderBuilder InitializeOrder(string orderId, string customerId, string sku, int quantity)
        {
            if (string.IsNullOrWhiteSpace(orderId)) throw new ArgumentException("Order tracking references cannot be blank.");
            if (quantity <= 0) throw new ArgumentOutOfRangeException(nameof(quantity), "Checkout quantities must exceed zero.");

            _order.OrderId = orderId;
            _order.CustomerId = customerId;
            _order.Sku = sku;
            _order.Quantity = quantity;
            return this;
        }

        public IOrderBuilder ApplyPromoCode(string promoCode)
        {
            _order.PromoCode = promoCode;
            return this;
        }

        public IOrderBuilder EnableGiftWrap()
        {
            _order.IsGiftWrapped = true;
            return this;
        }

        public IOrderBuilder AddDeliveryNotes(string notes)
        {
            _order.Notes = notes;
            return this;
        }

        public OrderManifest Build()
        {
            // Don’t worry: the objects are still created via the new operator, but it’s being called from within the factory method.
            if (string.IsNullOrEmpty(_order.OrderId) || string.IsNullOrEmpty(_order.CustomerId))
            {
                throw new InvalidOperationException("Incomplete Context Allocation: Core identity tracking profile values are completely unassigned.");
            }

            // Deliver the completely built product object reference
            OrderManifest completedProduct = _order;

            // Instantly clear out internal pipeline channels to safely recycle subsequent builder loops
            _order = new OrderManifest();

            return completedProduct;
        }
    }
}
