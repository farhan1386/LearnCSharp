using System;
using System.Collections.Generic;
using System.Text;

namespace Phase_1_Basics.Week_2_Control_Statements_Parameter_Keywords
{
    public class Return_Statement
    {
        public static void Run()
        {
            int result = AddNumbers(5, 10);
            Console.WriteLine($"The sum is: {result}");
        }

        static int AddNumbers(int a, int b)
        {
            return a + b; 
        }
    }
}