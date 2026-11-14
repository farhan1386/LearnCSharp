using System;
using System.Collections.Generic;

namespace Phase_3_Advanced.Week_4_Advanced_Data_Structures_Language_Features
{
    public class List_Collection
    {
        public static void Run()
        {
            // 1. Initialization
            List<string> employees = new List<string>() { "Alice", "Bob", "Charlie" };

            // 2. Adding items
            employees.Add("David");
            employees.AddRange(new string[] { "Emma", "Frank" });

            // 3. Finding elements using a Predicate (lambda expression)
            string? longName = employees.Find(name => name.Length > 5);
            Console.WriteLine($"First name with > 5 chars: {longName}"); // Charlie

            // 4. Removing items
            employees.Remove("Bob"); // Removes by value
            employees.RemoveAt(0);   // Removes "Alice" at index 0

            // 5. Sorting and Iterating
            employees.Sort();

            Console.WriteLine("\n--- Active Employees List ---");
            foreach (string name in employees)
            {
                Console.WriteLine(name);
            }

            Console.ReadLine();
        }
    }
}