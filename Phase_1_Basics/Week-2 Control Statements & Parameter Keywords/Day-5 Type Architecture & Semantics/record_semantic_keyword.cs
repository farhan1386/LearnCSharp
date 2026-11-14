using System;
using System.Collections.Generic;
using System.Text;

namespace Phase_1_Basics.Week_2_Control_Statements_Parameter_Keywords
{
    public class record_semantic_keyword
    {
        public static void Run()
        {
            ProductStock itemA = new ProductStock("LAP-PRO-092", 1299.99, "Zone-A");
            ProductStock itemB = new ProductStock("LAP-PRO-092", 1299.99, "Zone-A");

            Console.WriteLine("=== RECORD EQUALITY CHECK ===");
            Console.WriteLine($"Item A details: {itemA}");
            Console.WriteLine($"Item B details: {itemB}");
            Console.WriteLine($"Do items have identical data? {itemA == itemB}");

            ProductStock movedItem = itemA with { WarehouseZone = "Zone-C" };

            Console.WriteLine("\n=== NON-DESTRUCTIVE MUTATION ===");
            Console.WriteLine($"Moved Item details: {movedItem}");
            Console.WriteLine($"Is original item unaffected? {itemA != movedItem}");

            Console.ReadLine();
        }

        public record ProductStock(string Sku, double UnitPrice, string WarehouseZone);
    }
}