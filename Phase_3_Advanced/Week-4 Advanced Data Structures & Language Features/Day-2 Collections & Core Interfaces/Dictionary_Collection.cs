using System;
using System.Collections.Generic;

namespace Phase_3_Advanced.Week_4_Advanced_Data_Structures_Language_Features
{
    public class Dictionary_Collection
    {
        public static void Run()
        {
            // 1. Initialization (Key: Product SKU code, Value: Stock quantity)
            var inventory = new Dictionary<string, int>()
            {
                { "PROD_01", 50 },
                { "PROD_02", 12 }
            };

            // 2. Safe Adding (Prevents ArgumentException if key already exists)
            if (!inventory.ContainsKey("PROD_03"))
            {
                inventory.Add("PROD_03", 85);
            }

            // 3. Updating an existing value using indexer
            inventory["PROD_01"] = 45;

            // 4. Safe Retrieval (TryGetValue avoids KeyNotFoundException if key is missing)
            string searchKey = "PROD_02";
            if (inventory.TryGetValue(searchKey, out int currentStock))
            {
                Console.WriteLine($"Stock for {searchKey}: {currentStock}");
            }
            else
            {
                Console.WriteLine($"Product {searchKey} not found.");
            }

            // 5. Iterating through a dictionary
            Console.WriteLine("\n--- Current Inventory ---");
            foreach (KeyValuePair<string, int> item in inventory)
            {
                Console.WriteLine($"SKU: {item.Key} | Quantity: {item.Value}");
            }

            Console.ReadLine();
        }
    }
}