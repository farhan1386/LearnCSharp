using System;
using System.Collections.Generic;
using System.Text;
using Phase_5_Design_Patterns.Week_8_Behavioral_Patterns.Strategy_Pattern.ConcreteStrategy;
using Phase_5_Design_Patterns.Week_8_Behavioral_Patterns.Strategy_Pattern.Context;
using Phase_5_Design_Patterns.Week_8_Behavioral_Patterns.Strategy_Pattern.Interfaces;

namespace Phase_5_Design_Patterns.Week_8_Behavioral_Design_Patterns.Strategy_Pattern
{
    public class Strategy_Pattern
    {
        public static void Run()
        {
            Console.WriteLine("=== Strategy Design Pattern - Shipping Module ===\n");

            // 1. Define sample order data
            double samplePackageWeight = 8.5; // 8.5 Kg
            Console.WriteLine($"Package Weight: {samplePackageWeight} kg\n");

            // 2. Initialize the client / context with FedEx Ground Strategy
            Console.WriteLine("--- Selecting FedEx Ground ---");
            IShipping fedexStrategy = new FedexGround();
            OrderProcessor orderProcessor = new OrderProcessor(fedexStrategy);

            // Calculate billing using FedEx
            decimal fedexBill = orderProcessor.ProcessOrderBill(samplePackageWeight);
            Console.WriteLine($"Total Order Bill (FedEx): {fedexBill:C}");

            Console.WriteLine(); // Spacing

            // 3. Dynamically switch to DHL Express Strategy at runtime
            Console.WriteLine("--- Switching to DHL Express ---");
            IShipping dhlStrategy = new DhlExpress();
            orderProcessor.SetShippingMethod(dhlStrategy);

            // Calculate billing using DHL
            decimal dhlBill = orderProcessor.ProcessOrderBill(samplePackageWeight);
            Console.WriteLine($"Total Order Bill (DHL): {dhlBill:C}");

            Console.WriteLine("\nExecution completed. Press any key to exit.");
            Console.ReadKey();
        }
    }
}