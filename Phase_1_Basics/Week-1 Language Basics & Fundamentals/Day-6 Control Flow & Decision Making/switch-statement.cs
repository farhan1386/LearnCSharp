using System;
using System.Collections.Generic;
using System.Text;

namespace Phase_1_Basics.Week_1_Language_Basics_Fundamentals
{
    public class switch_statement
    {
        public static void Run()
        {
            // Example of switch statement
            Console.WriteLine("Enter your choice (1 for Salad, 2 for Chicken, 3 for Burger):");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Order Salad");
                    break;
                case 2:
                    Console.WriteLine("Order Chicken");
                    break;
                case 3:
                    Console.WriteLine("Order Burger");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
            Console.ReadLine();
        }
    }
}
