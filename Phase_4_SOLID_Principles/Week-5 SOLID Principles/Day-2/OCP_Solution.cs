using System;
using System.Collections.Generic;

namespace Phase_4_SOLID_Principles.Week_5_SOLID_Principles
{
    public class OCP_Solution
    {
        public static void Run()
        {
            IDiscountStrategy vipStrategy = new VipDiscount();
            var calculator = new RemediationDiscountCalculator(vipStrategy);

            double finalPrice = calculator.GetFinalPrice(200.0);
            Console.WriteLine($"[OCP Remediation] Final Price: {finalPrice}");
        }
    }

    public interface IDiscountStrategy
    {
        double ApplyDiscount(double amount);
    }

    public class RegularDiscount : IDiscountStrategy
    {
        public double ApplyDiscount(double amount) => amount * 0.90;
    }

    public class VipDiscount : IDiscountStrategy
    {
        public double ApplyDiscount(double amount) => amount * 0.80;
    }

    public class PremiumDiscount : IDiscountStrategy
    {
        public double ApplyDiscount(double amount) => amount * 0.70;
    }

    public class RemediationDiscountCalculator
    {
        private readonly IDiscountStrategy _strategy;

        public RemediationDiscountCalculator(IDiscountStrategy strategy)
        {
            _strategy = strategy;
        }

        public double GetFinalPrice(double totalAmount)
        {
            return _strategy.ApplyDiscount(totalAmount);
        }
    }
}