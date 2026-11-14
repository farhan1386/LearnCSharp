using System;
using System.Collections.Generic;
using System.Linq;

namespace Phase_3_Advanced.Week_4_Advanced_Data_Structures_Language_Features
{
    public class Lambda_Expressions
    {
        public static void Run()
        {
            Console.WriteLine("--- C# Lambda Expressions Demo ---\n");

            // 1. Statement Lambda (Uses curly braces, explicit body, and return)
            Func<int, int, int> multiply = (x, y) => {
                int result = x * y;
                return result;
            };
            Console.WriteLine($"Statement Lambda (Multiply): {multiply(4, 5)}");

            // 2. Expression Lambda (Single expression, implicit return, highly compact)
            Func<int, int> square = x => x * x;
            Console.WriteLine($"Expression Lambda (Square): {square(6)}");

            // 3. Real-World Use Case: Filtering collections with LINQ lambda expressions
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // The lambda 'n => n % 2 == 0' is passed as an inline predicate function
            List<int> evenNumbers = numbers.Where(n => n % 2 == 0).ToList();

            Console.WriteLine("\nFiltered Even Numbers:");
            foreach (int num in evenNumbers)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();
        }
    }
}