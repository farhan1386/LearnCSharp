using System;
using Phase_5_Design_Patterns.Week_8_Behavioral_Patterns.Strategy_Pattern.Interfaces;

namespace Phase_5_Design_Patterns.Week_8_Behavioral_Patterns.Strategy_Pattern.ConcreteStrategy
{
    public class DhlExpress : IShipping
    {
        private const decimal BaseFee = 25.00m;
        private const decimal PerKgRate = 4.50m;

        public decimal CalculateCost(double packageWeightKg)
        {
            if (packageWeightKg <= 0) return 0;

            return BaseFee + ((decimal)packageWeightKg * PerKgRate);
        }
    }
}