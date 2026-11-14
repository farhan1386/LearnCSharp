using System;
using System.Collections.Generic;
using System.Text;

namespace Phase_1_Basics.Week_1_Language_Basics_Fundamentals
{
    public class if_else_statement
    {
        public static void Run()
        {
            // Example of if-else statement
            bool isVegetarian = true;
            if (isVegetarian)
            {
                Console.WriteLine("Order Salad");
            }
            else if (!isVegetarian)
            {
                Console.WriteLine("Order Chicken");
            }
            else
            {
                Console.WriteLine("Order Burger");
            }
        }
    }
}
