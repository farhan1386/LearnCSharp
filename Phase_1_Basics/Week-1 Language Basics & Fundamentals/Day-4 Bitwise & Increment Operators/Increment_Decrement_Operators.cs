using System;
using System.Collections.Generic;
using System.Text;

namespace Phase_1_Basics.Week_1_Language_Basics_Fundamentals
{
    public class Increment_Decrement_Operators
    {
        public static void Run()
        {
            int valueOne = 10;
            int valueTwo = 20;
           
            //Increment and Decrement Operators
            Console.WriteLine("Initial value of valueOne: " + valueOne);
            Console.WriteLine("Initial value of valueTwo: " + valueTwo);
            
            //Using increment operator
            valueOne++; // equivalent to valueOne = valueOne + 1
            Console.WriteLine("After incrementing, valueOne: " + valueOne);
            
            //Using decrement operator
            valueTwo--; // equivalent to valueTwo = valueTwo - 1
            Console.WriteLine("After decrementing, valueTwo: " + valueTwo);
            Console.ReadLine();
        }   
    }
}
