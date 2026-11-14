using System;

namespace Phase_3_Advanced.Week_4_Advanced_Data_Structures_Language_Features
{
    // 1. Custom Delegate Declaration (Defines the method signature contract)
    public delegate void LogMessage(string text);

    public class Delegates_Basics
    {
        public static void Run()
        {
            Console.WriteLine("--- C# Delegates Basics Demo ---\n");

            // 2. Instantiating and using a Custom Delegate
            LogMessage logger = LogToConsole;
            logger("Hello via Custom Delegate!");

            // 3. Multicast Delegate (Chaining multiple methods together)
            logger += LogToUppercaseConsole;
            Console.WriteLine("\n--- Invoking Multicast Delegate ---");
            logger("this is multicast text"); // Fires both methods in order

            // 4. Built-in Modern C# Delegates (Action and Func)
            Console.WriteLine("\n--- Built-in Delegates ---");

            // Action<T>: Returns void, takes up to 16 parameters
            Action<string> modernLogger = message => Console.WriteLine($"[Action Log]: {message}");
            modernLogger("No custom declaration needed.");

            // Func<T, TResult>: Returns a value (last parameter is the return type)
            Func<int, int, int> addNumbers = (a, b) => a + b;
            int sum = addNumbers(5, 10);
            Console.WriteLine($"Func Add Result: {sum}");
        }

        // Target methods matching the custom delegate signature
        static void LogToConsole(string message) => Console.WriteLine($"Console: {message}");
        static void LogToUppercaseConsole(string message) => Console.WriteLine($"UPPERCASE: {message.ToUpper()}");
    }
}