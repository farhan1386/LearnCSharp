using System;
using Phase_5_Design_Patterns.Week_8_Behavioral_Patterns.Strategy_Pattern.Interfaces;

namespace Phase_5_Design_Patterns.Week_8_Behavioral_Patterns.Strategy_Pattern.Context
{
    public class OrderProcessor
    {
        private IShipping _shipping;

        public OrderProcessor(IShipping shippingStrategy)
        {
            _shipping = shippingStrategy ?? throw new ArgumentNullException(nameof(shippingStrategy), "An initial shipping strategy must be provided.");
        }

        public void SetShippingMethod(IShipping shippingStrategy)
        {
            _shipping = shippingStrategy ?? throw new ArgumentNullException(nameof(shippingStrategy), "Shipping strategy cannot be null.");
        }

        public decimal ProcessOrderBill(double packageWeightKg)
        {
            if (_shipping == null)
            {
                throw new InvalidOperationException("Shipping strategy is not initialized.");
            }

            if (packageWeightKg < 0)
            {
                throw new ArgumentException("Package weight cannot be negative.", nameof(packageWeightKg));
            }

            return _shipping.CalculateCost(packageWeightKg);
        }
    }
}