using System;
using System.Collections.Generic;
using System.Text;

namespace Phase_1_Basics.Week_1_Language_Basics_Fundamentals
{
    public class for_each_loop
    {
        public static void Run()
        {
            // Example of foreach loop
            string[] dishes = { "Salad", "Chicken", "Burger" };
            foreach (string dish in dishes)
            {
                Console.WriteLine("Dish: " + dish);
            }
        }
    }
}
