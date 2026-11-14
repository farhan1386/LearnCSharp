using System;
using System.Collections.Generic;
using System.Text;

namespace Phase_5_Design_Patterns.Week_8_Behavioral_Design_Patterns.Strategy_Pattern_Violation
{
    public class Strategy_Pattern_Violation
    {
        public static void Run()
        {
            Console.WriteLine("=== Strategy Design Pattern Violation - Shipping Module ===\n");

            double samplePackageWeight = 8.5; // 8.5 Kg
            Console.WriteLine($"Package Weight: {samplePackageWeight} kg\n");

            // ❌ CRITICAL DESIGN VIOLATION 1: No dynamic encapsulation
            // The client is forced to use an architectural enum marker flag to toggle behaviors 
            // instead of injecting decoupled interface implementations.
            var billingSystem = new ViolatedOrderProcessor();

            Console.WriteLine("--- Selecting FedEx Ground (Via Enum Flag) ---");
            decimal fedexBill = billingSystem.ProcessOrderBill(samplePackageWeight, ShippingType.FedexGround);
            Console.WriteLine($"Total Order Bill (FedEx): {fedexBill:C}");

            Console.WriteLine();

            Console.WriteLine("--- Switching to DHL Express (Via Enum Flag) ---");
            decimal dhlBill = billingSystem.ProcessOrderBill(samplePackageWeight, ShippingType.DhlExpress);
            Console.WriteLine($"Total Order Bill (DHL): {dhlBill:C}");
        }
    }

    // =========================================================================
    // ENUM AND CONTEXT LAYER MIXED TOGETHER
    // =========================================================================
    public enum ShippingType
    {
        FedexGround,
        DhlExpress,
        UpsStandard // Added to show the fragility of this model
    }

    public class ViolatedOrderProcessor
    {
        public decimal ProcessOrderBill(double packageWeightKg, ShippingType shippingType)
        {
            if (packageWeightKg < 0)
            {
                throw new ArgumentException("Package weight cannot be negative.", nameof(packageWeightKg));
            }

            if (packageWeightKg == 0) return 0;

            // ❌ CRITICAL DESIGN VIOLATION 2: Open/Closed Principle (OCP) Infraction
            // This method is tightly coupled to every single carrier logic implementation.
            // If your business adds a new provider (like UPS) or modifies DHL fees, you are forced 
            // to open, modify, and risk breaking this entire core application billing service file.
            switch (shippingType)
            {
                case ShippingType.FedexGround:
                    const decimal fedexPerKgRate = 2.15m;
                    decimal fedexCost = (decimal)packageWeightKg * fedexPerKgRate;
                    return Math.Max(fedexCost, 8.50m);

                case ShippingType.DhlExpress:
                    const decimal dhlBaseFee = 25.00m;
                    const decimal dhlPerKgRate = 4.50m;
                    return dhlBaseFee + ((decimal)packageWeightKg * dhlPerKgRate);

                case ShippingType.UpsStandard:
                    // Hardcoded algorithms clutter your high-level transaction orchestration workflows
                    return 12.00m + ((decimal)packageWeightKg * 3.10m);

                default:
                    throw new NotSupportedException($"The shipping method '{shippingType}' is not supported.");
            }
        }
    }
}