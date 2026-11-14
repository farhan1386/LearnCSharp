using System;

namespace Phase_2_Intermediate.Week_3_Object_Oriented_Programming
{
    public class Static_and_Synthesis
    {
        public static void Run()
        {
            // 1. Accessing Static Fields and Properties directly via the class name
            Console.WriteLine($"Clinic Name: {DentalClinicRegistry.ClinicName}");
            Console.WriteLine($"Current Active Patient Count: {DentalClinicRegistry.ActivePatientsCount}");

            Console.WriteLine("\n--- Simulating Patient Admissions ---");

            // 2. Instantiating regular objects that interact with static tracking data
            var patient1 = new PatientRecord("Farhan Ahmed");
            var patient2 = new PatientRecord("Anya Sharma");

            // Check how the static counter changed across all instances
            Console.WriteLine($"Updated Active Patient Count: {DentalClinicRegistry.ActivePatientsCount}");

            Console.WriteLine("\n--- Using Static Utility Methods ---");

            // 3. Using a Static Utility Method for calculations (No 'new' required)
            double cashPrice = 2500.00;
            double taxComponent = DentalCalculators.CalculateServiceTax(cashPrice);
            double finalInvoice = DentalCalculators.ApplyClinicDiscount(cashPrice, 10); // 10% off

            Console.WriteLine($"Base Price: ₹{cashPrice:N2}");
            Console.WriteLine($"Tax component (18% GST): ₹{taxComponent:N2}");
            Console.WriteLine($"Final Post-Discount Invoice: ₹{finalInvoice:N2}");

            Console.ReadLine();
        }
    }

    // REGULAR CLASS sharing global data via static counters
    public class PatientRecord
    {
        public string PatientName { get; set; }

        public PatientRecord(string name)
        {
            PatientName = name;

            // Increments the shared, central counter whenever a new patient file is opened
            DentalClinicRegistry.ActivePatientsCount++;
            Console.WriteLine($"[Registry Office] Created record for: {PatientName}");
        }
    }

    // STATIC CLASS 1: Central Registry Storage (Global Data Holder)
    public static class DentalClinicRegistry
    {
        // Static properties share exactly one copy across the entire application runtime
        public static string ClinicName { get; set; }
        public static int ActivePatientsCount { get; set; }

        // Static Constructor: Initializes static values. Runs exactly once automatically.
        static DentalClinicRegistry()
        {
            ClinicName = "Apex Dental & Maxillofacial Care";
            ActivePatientsCount = 0; // Baseline setup
            Console.WriteLine("[System Boot] Global Clinic Registry initialized.");
        }
    }

    // STATIC CLASS 2: Functional Utility Helper (Pure computation logic)
    public static class DentalCalculators
    {
        private const double GstRate = 0.18; // 18% standard healthcare service metric

        public static double CalculateServiceTax(double amount)
        {
            return amount * GstRate;
        }

        public static double ApplyClinicDiscount(double subtotal, double discountPercentage)
        {
            double savings = subtotal * (discountPercentage / 100);
            return subtotal - savings;
        }
    }
}