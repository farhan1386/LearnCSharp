using System;

namespace Phase_3_Advanced.Week_4_Advanced_Data_Structures_Language_Features
{
    public class Custom_Exceptions
    {
        public static void Run()
        {
            Console.WriteLine("--- Custom Exception Demo ---\n");

            try
            {
                // Attempt to register an underage user
                RegisterUser("John Doe", 15);
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine($"Error caught: {ex.Message}");
                Console.WriteLine($"Rejected Age: {ex.Age}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
        }

        public static void RegisterUser(string name, int age)
        {
            if (age < 18)
            {
                // Throw our custom exception when business rules are violated
                throw new InvalidAgeException(age, "Users must be at least 18 years old to register.");
            }

            Console.WriteLine($"User '{name}' registered successfully!");
        }
    }

    // Custom business exception following standard .NET naming conventions
    public class InvalidAgeException : Exception
    {
        public int Age { get; }

        // Default constructor
        public InvalidAgeException() : base("Age is invalid for this operation.") { }

        // Constructor that accepts a custom message
        public InvalidAgeException(string message) : base(message) { }

        // Recommended constructor to accept context-specific data and a message
        public InvalidAgeException(int age, string message) : base(message)
        {
            Age = age;
        }

        // Constructor for wrapping inner exceptions
        public InvalidAgeException(string message, Exception innerException) : base(message, innerException) { }
    }
}