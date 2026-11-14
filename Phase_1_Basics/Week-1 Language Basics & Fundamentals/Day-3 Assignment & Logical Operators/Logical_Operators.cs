using System;
using System.Collections.Generic;
using System.Text;

namespace Phase_1_Basics.Week_1_Language_Basics_Fundamentals
{
    public class Logical_Operators
    {
        public static void Run()
        {
            int valueOne = 10;
            int valueTwo = 20;

            //Logical Operators
            Console.WriteLine("Logical AND (valueOne < 15 && valueTwo > 15): " + (valueOne < 15 && valueTwo > 15));
            Console.WriteLine("Logical OR (valueOne < 15 || valueTwo > 15): " + (valueOne < 15 || valueTwo > 15));
            Console.WriteLine("Logical NOT !(valueOne < 15): " + (!(valueOne < 15)));
            Console.ReadLine();
        }
    }
}
