using System;
using System.Collections.Generic;
using System.Linq; 

namespace Phase_3_Advanced.Week_4_Advanced_Data_Structures_Language_Features
{
    public class Linq_Method_syntax
    {
        public static void Run()
        {
            Console.WriteLine("--- C# LINQ Method Syntax Demo ---\n");

            var products = new List<Product>
            {
                new Product { Name = "Laptop", Price = 1200, Category = "Electronics" },
                new Product { Name = "Mouse", Price = 25, Category = "Electronics" },
                new Product { Name = "Desk Chair", Price = 150, Category = "Furniture" },
                new Product { Name = "Coffee Mug", Price = 15, Category = "Kitchen" }
            };

            // 1. Where & Select (Filter and Transform)
            List<string> electronicsNames = products
                .Where(p => p.Category == "Electronics")
                .Select(p => p.Name)
                .ToList();

            // 2. OrderBy & OrderByDescending (Sorting)
            var sortedProducts = products
                .OrderBy(p => p.Price)
                .ToList();

            // 3. FirstOrDefault (Safe element retrieval)
            Product? cheapProduct = products.FirstOrDefault(p => p.Price < 20);

            // 4. Aggregates (Sum, Average, Count)
            decimal totalFurnitureCost = products
                .Where(p => p.Category == "Furniture")
                .Sum(p => p.Price);

            // Display outputs
            Console.WriteLine($"Electronics: {string.Join(", ", electronicsNames)}");
            Console.WriteLine($"Cheapest match found: {cheapProduct?.Name ?? "None"}");
            Console.WriteLine($"Total Furniture Cost: {totalFurnitureCost:C}");
        }
    }

    public class Product
    {
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string Category { get; set; } = string.Empty;
    }
}