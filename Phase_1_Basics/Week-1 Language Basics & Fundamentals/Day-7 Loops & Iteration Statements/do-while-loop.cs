using System;
using System.Collections.Generic;
using System.Text;

namespace Phase_1_Basics.Week_1_Language_Basics_Fundamentals
{
    public class do_while_loop
    {
        public static void Run()
        {
            // Example of do-while loop
            int k = 1;
            do
            {
                Console.WriteLine("Iteration: " + k);
                k++;
            } while (k <= 5);
        }
    }
}
