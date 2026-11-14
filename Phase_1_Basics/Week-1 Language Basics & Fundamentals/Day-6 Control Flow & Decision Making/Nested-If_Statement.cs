using System;
using System.Collections.Generic;
using System.Text;

namespace Phase_1_Basics.Week_1_Language_Basics_Fundamentals
{
    public class Nested_If_Statement
    {
        public static void Run()
        {
            int number = 10;
            if (number > 0)
            {
                Console.WriteLine("The number is positive.");
                if (number % 2 == 0)
                {
                    Console.WriteLine("The number is even.");
                }
                else
                {
                    Console.WriteLine("The number is odd.");
                }
            }
            else if (number < 0)
            {
                Console.WriteLine("The number is negative.");
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }
        }
    }
}
