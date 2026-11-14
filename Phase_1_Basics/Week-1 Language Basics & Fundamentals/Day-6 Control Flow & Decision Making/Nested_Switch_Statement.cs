using System;
using System.Collections.Generic;
using System.Text;

namespace Phase_1_Basics.Week_1_Language_Basics_Fundamentals
{
    public class Nested_Switch_Statement
    {
        public static void Run()
        {
            int outter = 2;
            int inner = 3;

            // Using Nested Switch Case
            switch (outter)
            {
                case 1:
                    Console.WriteLine("Outter Case 1");
                    break;
                case 2:
                    Console.WriteLine("Outter Case 2");
                    switch (inner)
                    {
                        case 1:
                            Console.WriteLine("Inner Case 1");
                            break;
                        case 2:
                            Console.WriteLine("Inner Case 2");
                            break;
                        case 3:
                            Console.WriteLine("Inner Case 3");
                            break;
                        default:
                            Console.WriteLine("Default Inner Run");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Default Outter Run");
                    break;
            }
        }
    }
}
