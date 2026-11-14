using System;
using System.Collections.Generic;
using System.Text;

namespace Phase_1_Basics.Week_2_Control_Statements_Parameter_Keywords
{
    public class Continue_Statement
    {
        public static void Run()
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i == 5)
                {
                    continue; 
                }
                Console.WriteLine(i);
            }
        }
    }
}