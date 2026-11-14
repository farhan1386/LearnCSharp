using System;
using System.Collections.Generic;
using System.Text;

namespace Phase_1_Basics.Week_1_Language_Basics_Fundamentals
{
    public class nested_loops
    {
        public static void Run()
        {
            // Example of nested loops
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Outer loop iteration: " + i);
                for (int j = 1; j <= 2; j++)
                {
                    Console.WriteLine("  Inner loop iteration: " + j);
                }
            }
        }
    }
}
