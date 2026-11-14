using System;
using System.Collections.Generic;
using System.Text;

namespace Phase_1_Basics.Week_1_Language_Basics_Fundamentals
{
    public class while_loop
    {
        public static void Run()
        {
            // Example of while loop
            int j = 1;
            while (j <= 5)
            {
                Console.WriteLine("Iteration: " + j);
                j++;
            }
        }
    }
}
