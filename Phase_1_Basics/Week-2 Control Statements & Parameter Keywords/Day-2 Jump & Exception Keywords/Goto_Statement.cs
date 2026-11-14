using System;
using System.Collections.Generic;
using System.Text;

namespace Phase_1_Basics.Week_2_Control_Statements_Parameter_Keywords
{
    public class Goto_Statement
    {
        public static void Run()
        {
            int number = 10;
            if (number > 0)
            {
                goto PositiveNumber; 
            }
            else
            {
                goto NonPositiveNumber; 
            }

        PositiveNumber:
            Console.WriteLine("The number is positive.");
            return;
        NonPositiveNumber:
            Console.WriteLine("The number is zero or negative.");
        }
    }
}