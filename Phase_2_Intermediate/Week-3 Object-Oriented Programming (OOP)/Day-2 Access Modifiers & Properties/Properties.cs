using System;

namespace Phase_2_Intermediate.Week_3_Object_Oriented_Programming
{
    public class Properties
    {
        public static void Run()
        {
            Person person = new Person();

            // Set the properties
            person.FirstName = "Farhan";
            person.LastName = "Ahmed";
            person.Age = 21; // Valid data assignment

            // Attempting to set invalid data to test field encapsulation validation logic
            Console.WriteLine("[System Check] Attempting to set negative age value...");
            person.Age = -5;

            // Get the properties
            Console.WriteLine($"\nFirst Name: {person.FirstName}");
            Console.WriteLine($"Last Name : {person.LastName}");
            Console.WriteLine($"Full Name : {person.FullName}"); // Evaluated dynamically
            Console.WriteLine($"Fixed Age : {person.Age}"); // Shows validation fallback value

            Console.ReadLine();
        }
    }

    public class Person
    {
        // 1. Private backing fields used for Full Properties
        private int _age;

        // 2. Auto-implemented properties (Best when no validation logic is needed)
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;

        // 3. Full property with explicit validation guard rules inside the 'set' block
        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 0)
                {
                    _age = 0; // Guard clause handles invalid input safely
                }
                else
                {
                    _age = value;
                }
            }
        }

        // 4. Expression-bodied read-only property (Calculated on-the-fly dynamically)
        public string FullName => $"{FirstName} {LastName}";
    }
}