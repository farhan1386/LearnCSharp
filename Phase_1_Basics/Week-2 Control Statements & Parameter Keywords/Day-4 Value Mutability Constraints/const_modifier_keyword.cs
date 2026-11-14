using System;
using System.Collections.Generic;
using System.Text;

namespace Phase_1_Basics.Week_2_Control_Statements_Parameter_Keywords
{
    public class const_modifier_keyword
    {
        public static void Run()
        {
            const double StateTaxRate = 0.0825;
            const double PremiumShippingDiscountThreshold = 100.00;

            double cartSubtotal = 120.50;
            double taxAmount = cartSubtotal * StateTaxRate;
            double shippingCost = (cartSubtotal >= PremiumShippingDiscountThreshold) ? 0.00 : 9.99;
            double finalInvoiceTotal = cartSubtotal + taxAmount + shippingCost;

            Console.WriteLine("=== ORDER DISPATCH & TAX CALCULATOR ===");
            Console.WriteLine($"Cart Subtotal   : ${cartSubtotal:F2}");
            Console.WriteLine($"State Tax (8.25%): ${taxAmount:F2}");
            Console.WriteLine($"Shipping Charge : ${shippingCost:F2}");
            Console.WriteLine($"Final Invoice   : ${finalInvoiceTotal:F2}");

            Console.ReadLine();
        }
    }
}