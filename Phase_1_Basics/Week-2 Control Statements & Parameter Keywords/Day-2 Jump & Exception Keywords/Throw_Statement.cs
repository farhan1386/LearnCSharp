using System;
using System.Collections.Generic;
using System.Text;

namespace Phase_1_Basics.Week_2_Control_Statements_Parameter_Keywords
{
    public class Throw_Statement
    {
        public static void Run()
        {
            try
            {
                int number = -5;
                if (number < 0)
                {
                    throw new ArgumentException("Number cannot be negative.");
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.ReadLine();
        }
    }
}