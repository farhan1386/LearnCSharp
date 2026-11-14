using System;
using Phase_5_Design_Patterns.Week_8_Behavioral_Patterns.Strategy_Pattern.Interfaces;

namespace Phase_5_Design_Patterns.Week_8_Behavioral_Patterns.Strategy_Pattern.ConcreteStrategy
{
    public class FedexGround : IShipping
    {
        private const decimal PerKgRate = 2.15m;

        public decimal CalculateCost(double packageWeightKg)
        {
            if (packageWeightKg <= 0) return 0;

            decimal calculatedCost = (decimal)packageWeightKg * PerKgRate;
            return Math.Max(calculatedCost, 8.50m);
        }
    }
}
