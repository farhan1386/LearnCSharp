using System;

namespace Phase_4_SOLID_Principles.Week_5_SOLID_Principles
{
    public class OCP_Violation
    {
        public static void Run()
        {
            var calculator = new DiscountCalculator();
            double finalPrice = calculator.CalculateDiscount("VIP", 200.0);
            Console.WriteLine($"[OCP Violation] Final Price: {finalPrice}");
        }
    }

    public class DiscountCalculator
    {
        public double CalculateDiscount(string customerType, double amount)
        {
            // ❌ Violation: Forcing structural file updates for every new business rule
            if (customerType == "Regular") return amount * 0.90; // 10% off
            if (customerType == "VIP") return amount * 0.80;     // 20% off

            return amount;
        }
    }
}