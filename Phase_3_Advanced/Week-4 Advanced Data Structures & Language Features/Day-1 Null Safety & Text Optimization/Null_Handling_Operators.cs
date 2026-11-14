using System;
using System.Collections.Generic;

namespace Phase_3_Advanced.Week_4_Advanced_Data_Structures_Language_Features
{
    public class Null_Handling_Operators
    {
        public static void Run()
        {
            User? user = null;
            List<string>? tags = null;

            // 1. ?. and ?[] (Null-Conditional)
            string? city = user?.Address?.City;
            string? firstTag = tags?[0]; 

            // 2. ?? (Null-Coalescing)
            string displayName = city ?? "Anonymous";

            // 3. ??= (Null-Coalescing Assignment)
            tags ??= new List<string>();
            tags.Add("C#");

            Console.WriteLine($"City: {displayName}");
            Console.WriteLine($"Tags Count: {tags.Count}");

            Console.ReadLine();
        }

    }

    public class User
    {
        public Address? Address { get; set; }
    }

    public class Address
    {
        public string City { get; set; } = "";
    }
}