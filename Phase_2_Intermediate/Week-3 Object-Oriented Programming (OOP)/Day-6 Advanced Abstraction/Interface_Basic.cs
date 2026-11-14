using System;

namespace Phase_2_Intermediate.Week_3_Object_Oriented_Programming
{
    public class Interface_Basic
    {
        public static void Run()
        {
            // Interfaces cannot be instantiated directly:
            // IInsurable claim = new IInsurable(); // ❌ Compiler Error

            // Creating instances of classes that implement our interfaces
            IInsurable treatmentClaim = new DentalProcedureClaim("Root Canal", 4500.00);
            IInsurable medicineClaim = new PharmacyPrescription("Antibiotics", 650.00);

            Console.WriteLine("--- Insurance Processing Portal ---\n");

            // Process both items through the exact same insurance interface contract
            SubmitClaimToProvider(treatmentClaim);
            Console.WriteLine();
            SubmitClaimToProvider(medicineClaim);

            Console.ReadLine();
        }

        // This method doesn't care what the object is, as long as it follows the IInsurable contract
        public static void SubmitClaimToProvider(IInsurable insurableItem)
        {
            string systemCode = insurableItem.GetInsuranceCode();
            double claimAmount = insurableItem.TotalCost;

            Console.WriteLine($"[Portal] Submitting Claim under Code: {systemCode}");
            Console.WriteLine($"[Portal] Processing structural payout of: ₹{claimAmount:N2}");
        }
    }

    // INTERFACE DEFINITION
    // Convention: Always start interface names with a capital 'I'
    public interface IInsurable
    {
        // Interfaces only declare signatures. No access modifiers (like public/private) are allowed inside.
        double TotalCost { get; set; }
        string GetInsuranceCode();
    }

    // CLASS 1: Implements IInsurable contract
    public class DentalProcedureClaim : IInsurable
    {
        public string ProcedureName { get; set; }
        public double TotalCost { get; set; } // Implemented from Interface

        public DentalProcedureClaim(string name, double cost)
        {
            ProcedureName = name;
            TotalCost = cost;
        }

        public string GetInsuranceCode() // Implemented from Interface
        {
            return $"DEN-PROC-{ProcedureName.Replace(" ", "").ToUpper()}";
        }
    }

    // CLASS 2: An entirely different type of class that also implements IInsurable contract
    public class PharmacyPrescription : IInsurable
    {
        public string MedicineName { get; set; }
        public double TotalCost { get; set; } // Implemented from Interface

        public PharmacyPrescription(string name, double cost)
        {
            MedicineName = name;
            TotalCost = cost;
        }

        public string GetInsuranceCode() // Implemented from Interface
        {
            return $"PHARMA-RX-{MedicineName.ToUpper()}";
        }
    }
}
