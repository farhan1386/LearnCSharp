using System;
using System.Collections.Generic;
using System.Text;

namespace Phase_1_Basics.Week_1_Language_Basics_Fundamentals
{
    public class if_statement
    {
        public static void Run()
        {
            
            Console.WriteLine("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if(age >= 18)
            {
                Console.WriteLine("You are eligible to vote.");
            }
            else
            {
                Console.WriteLine("You are not eligible to vote.");
            }

            Console.ReadLine();
        }
    }
}
