using System;
using System.Collections.Generic;
using System.Text;

namespace Phase_1_Basics.Week_1_Language_Basics_Fundamentals
{
    public class Bitwise_Operators
    {
        public static void Run()
        {
            int valueOne = 5;  // Binary: 0101
            int valueTwo = 3;  // Binary: 0011
            // Bitwise AND
            int andResult = valueOne & valueTwo; // Binary: 0001
            Console.WriteLine("Bitwise AND of " + valueOne + " and " + valueTwo + " is: " + andResult);
            // Bitwise OR
            int orResult = valueOne | valueTwo; // Binary: 0111
            Console.WriteLine("Bitwise OR of " + valueOne + " and " + valueTwo + " is: " + orResult);
            // Bitwise XOR
            int xorResult = valueOne ^ valueTwo; // Binary: 0110
            Console.WriteLine("Bitwise XOR of " + valueOne + " and " + valueTwo + " is: " + xorResult);
            // Bitwise NOT
            int notResult = ~valueOne; // Binary: 1010 (in two's complement)
            Console.WriteLine("Bitwise NOT of " + valueOne + " is: " + notResult);
            Console.ReadLine();
        }
    }
}
