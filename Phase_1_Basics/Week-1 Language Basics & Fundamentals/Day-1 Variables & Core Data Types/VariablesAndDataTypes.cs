using System;

namespace Phase_1_Basics.Week_1_Language_Basics_Fundamentals
{
    public class VariablesAndDataTypes
    {
        public static void Run()
        {
            // Value Type Variables
            int age = 42;
            float height = 5.10f;
            double workRatePerHour = 45.5; 
            char gender = 'M';
            bool isEmployed = true;

            Console.WriteLine("Value Type Variables:\n");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Height: {height}");
            Console.WriteLine($"Work Rate Per Hour: ${workRatePerHour}");
            Console.WriteLine($"Gender: {gender}");
            Console.WriteLine($"Is Employed: {isEmployed}");

            // Reference Type Variables
            string name = "Farhan Ahmed";
            object obj = 10;
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("\nReference Type:\n");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Object Value: {obj}");
            Console.WriteLine($"Numbers Array: {string.Join(", ", numbers)}");

            // Regular Value Type (Simulating the value placeholder)
            int placeholderValue = 42;

            Console.WriteLine("\nPlaceholder Variable:\n");
            Console.WriteLine($"Value: {placeholderValue}");

            Console.WriteLine("\nPress any key to exit...");
        }
    }
}