using System;

namespace Phase_2_Intermediate.Week_3_Object_Oriented_Programming
{
    public class Method_Overriding
    {
        public static void Run()
        {
            // 1. Base class reference pointing to a Standard shipping object
            ShippingProvider standardDelivery = new ShippingProvider();

            // 2. Base class references pointing to specialized child objects (Polymorphism)
            ShippingProvider expressDelivery = new ExpressShipping();
            ShippingProvider droneDelivery = new DroneShipping();

            // Calling the overridden methods
            Console.WriteLine($"Standard cost (10kg): ₹{standardDelivery.CalculateCost(10)}");
            Console.WriteLine($"Express cost (10kg):  ₹{expressDelivery.CalculateCost(10)}");
            Console.WriteLine($"Drone cost (10kg):    ₹{droneDelivery.CalculateCost(10)}");

            Console.ReadLine();
        }
    }

    // BASE CLASS (Parent)
    public class ShippingProvider
    {
        // 'virtual' tells C# that child classes are allowed to override this logic
        public virtual double CalculateCost(double weightInKg)
        {
            // Standard rate: ₹50 per kg
            return weightInKg * 50;
        }
    }

    // DERIVED CLASS 1 (Child)
    public class ExpressShipping : ShippingProvider
    {
        // 'override' changes the parent's default behavior for Express shipping
        public override double CalculateCost(double weightInKg)
        {
            // Express rate: ₹100 per kg + flat ₹150 priority fee
            return (weightInKg * 100) + 150;
        }
    }

    // DERIVED CLASS 2 (Child)
    public class DroneShipping : ShippingProvider
    {
        // 'override' changes the parent's default behavior for Drone delivery
        public override double CalculateCost(double weightInKg)
        {
            // Drone rate: Flat fee of ₹500 regardless of weight (up to limits)
            return 500.00;
        }
    }
}