using System;
using System.Collections.Generic;
using System.Text;

namespace Phase_3_Advanced.Week_4_Advanced_Data_Structures_Language_Features
{
    public class code_refactoring
    {
        public static void Run()
        {
            // Call the method with parameters
            int result = AddNumbers(5, 10);
            Console.WriteLine("The sum is: " + result);
            // Call the method without parameters
            GreetUser();
            // Call the method to find the maximum number
            int[] numbers = { 1, 2, 3, 4, 5 };
            int max = FindMax(numbers);
            Console.WriteLine("The maximum number is: " + max);

            Console.ReadLine(); // Wait for user input before closing the console
        }
        // Method with parameters
        public static int AddNumbers(int a, int b)
        {
            return a + b;
        }
        // Method without parameters
        public static void GreetUser()
        {
            Console.WriteLine("Hello, user!");
        }

        public static int FindMax(int[] numbers)
        {
            int max = numbers[0];
            foreach (int number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }
            return max;
        }
    }
}
