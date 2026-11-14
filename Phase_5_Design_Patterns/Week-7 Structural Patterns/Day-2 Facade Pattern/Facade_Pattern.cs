using System;
using System.Collections.Generic;
using System.Text;
using Phase_5_Design_Patterns.Week_7_Structural_Patterns.Facade_Pattern.Domain;

namespace Phase_5_Design_Patterns.Week_7_Structural_Patterns.Facade_Pattern
{
    public class Facade_Pattern
    {
        public static void Run()
        {
            Console.WriteLine("=== Executing Simplified Facade Pattern Workflow ===");

            // Instantiating the high-level Facade gateway wrapper
            Mortgage mortgage = new Mortgage();

            // Initializing domain entity
            Customer customer = new Customer("Ann McKinsey");

            // Complex validations occur implicitly behind this single gateway abstraction layer
            bool eligible = mortgage.IsEligible(customer, 125000);

            Console.WriteLine("\n" + customer.Name + " has been " + (eligible ? "Approved" : "Rejected"));

            Console.WriteLine("\nPress any key to finalize simulation...");
            Console.ReadKey();
        }
    }
}