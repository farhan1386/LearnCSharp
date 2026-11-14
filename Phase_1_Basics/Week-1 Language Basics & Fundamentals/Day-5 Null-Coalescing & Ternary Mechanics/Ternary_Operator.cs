using System;
using System.Collections.Generic;
using System.Text;

namespace Phase_1_Basics.Week_1_Language_Basics_Fundamentals
{
    public class Ternary_Operator
    {
        public static void Run()
        {
            int valueOne = 10;
            int valueTwo = 20;

            // Ternary Operator
            string result = (valueOne > valueTwo) ? "valueOne is greater than valueTwo" : "valueOne is not greater than valueTwo";
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
