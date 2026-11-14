using System;
using System.Collections.Generic;
using System.Text;

namespace Phase_1_Basics.Week_1_Language_Basics_Fundamentals
{
    public class Null_Coalescing_Operator
    {
        public static void Run()
        {
            string? nullableString = null;
            
            // Using the null-coalescing operator to provide a default value
            string result = nullableString ?? "Default Value";
            Console.WriteLine(result); // Output: Default Value
            Console.ReadLine();
        }
    }
}
