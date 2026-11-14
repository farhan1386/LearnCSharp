using System;
using System.Collections.Generic;
using System.Text;

namespace Phase_1_Basics.Week_1_Language_Basics_Fundamentals
{
    public class If_Else_If_Ladder_Statement
    {
        public static void Run()
        {
            int marks = 85;
            if (marks >= 90)
            {
                Console.WriteLine("Grade: A");
            }
            else if (marks >= 80)
            {
                Console.WriteLine("Grade: B");
            }
            else if (marks >= 70)
            {
                Console.WriteLine("Grade: C");
            }
            else if (marks >= 60)
            {
                Console.WriteLine("Grade: D");
            }
            else
            {
                Console.WriteLine("Grade: F");
            }
        }
    }
}
