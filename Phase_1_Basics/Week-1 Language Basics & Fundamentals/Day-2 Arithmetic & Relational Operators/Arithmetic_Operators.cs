using System;

namespace Phase_1_Basics.Week_1_Language_Basics_Fundamentals
{
    class Arithmetic_Operators
    {
        public static void Run()
        {

            double itemPrice = 24.99;
            int quantityRequested = 5;
            double discountAmount = 15.00;
            double taxRate = 0.08;

            double subtotal = itemPrice * quantityRequested;
            double totalAfterDiscount = subtotal - discountAmount;
            double salesTax = totalAfterDiscount * taxRate;
            double finalInvoiceTotal = totalAfterDiscount + salesTax;

            double averageCostPerItem = finalInvoiceTotal / quantityRequested;

            int totalItemsInWarehouse = 43;
            int itemsPerShippingBox = 10;
            int fullBoxesReady = totalItemsInWarehouse / itemsPerShippingBox;
            int remainingLooseItems = totalItemsInWarehouse % itemsPerShippingBox;

            Console.WriteLine("=== ORDER FINANCIAL SUMMARY ===");
            Console.WriteLine($"Subtotal: ${subtotal:F2}");
            Console.WriteLine($"Discount Applied: -${discountAmount:F2}");
            Console.WriteLine($"Sales Tax (8%): ${salesTax:F2}");
            Console.WriteLine($"Final Total: ${finalInvoiceTotal:F2}");
            Console.WriteLine($"Effective Cost Per Item: ${averageCostPerItem:F2}");

            Console.WriteLine("\n=== WAREHOUSE FULFILLMENT ===");
            Console.WriteLine($"Total Stock Processed: {totalItemsInWarehouse}");
            Console.WriteLine($"Full Shipping Boxes: {fullBoxesReady}");
            Console.WriteLine($"Loose Items Remaining: {remainingLooseItems}");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}