using System;

namespace Phase_2_Intermediate.Week_3_Object_Oriented_Programming
{
    public class Method_Overloading
    {
        public static void Run()
        {
            var invoice = new InvoiceCalculator();

            // 1. Basic Calculation (Single item price)
            double basicTotal = invoice.CalculateTotal(500.00);
            Console.WriteLine($"Scenario 1 (Single Item): ₹{basicTotal}");

            // 2. Quantity Calculation (Price * Qty)
            double quantityTotal = invoice.CalculateTotal(120.00, 5);
            Console.WriteLine($"Scenario 2 (Multiple Items): ₹{quantityTotal}");

            // 3. Discount Code Calculation (Price * Qty - Promo Value)
            double promoTotal = invoice.CalculateTotal(120.00, 5, 50.00);
            Console.WriteLine($"Scenario 3 (With Flat Promo Code): ₹{promoTotal}");

            // 4. Percentage Discount Calculation (Price * Qty - Percentage)
            double percentageTotal = invoice.CalculateTotal(1000.00, 2, "SAVE10");
            Console.WriteLine($"Scenario 4 (With Percentage Coupon): ₹{percentageTotal}");

            Console.ReadLine();
        }
    }

    public class InvoiceCalculator
    {
        // Overload 1: Takes only 1 parameter (base item price)
        public double CalculateTotal(double itemPrice)
        {
            return itemPrice;
        }

        // Overload 2: Takes 2 parameters (Price and Quantity)
        public double CalculateTotal(double unitPrice, int quantity)
        {
            return unitPrice * quantity;
        }

        // Overload 3: Takes 3 parameters (Price, Quantity, and Flat Cash Discount)
        public double CalculateTotal(double unitPrice, int quantity, double flatDiscount)
        {
            double subtotal = unitPrice * quantity;
            return subtotal - flatDiscount;
        }

        // Overload 4: Different parameter types (Price, Quantity, and a String Coupon Code)
        public double CalculateTotal(double unitPrice, int quantity, string couponCode)
        {
            double subtotal = unitPrice * quantity;

            if (couponCode == "SAVE10")
            {
                subtotal -= subtotal * 0.10; // 10% discount applied
            }

            return subtotal;
        }
    }
}