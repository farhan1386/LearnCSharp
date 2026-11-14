using System;

namespace Phase_2_Intermediate.Week_3_Object_Oriented_Programming
{
    public class Abstract_Class
    {
        public static void Run()
        {
            // var baseProcedure = new DentalProcedure("Dr. Roy"); // ❌ Compiler Error: Cannot create an instance of an abstract class.

            // Using polymorphic references to build a treatment workflow
            DentalProcedure cleaning = new RoutineCleaning("Dr. Ananya Sharma", true);
            DentalProcedure rootCanal = new RootCanalTreatment("Dr. Farhan Ahmed", 2);

            Console.WriteLine("--- Patient Treatment Processing System ---\n");

            // Executing the structured workflow step-by-step
            cleaning.PerformFullAppointment();

            Console.WriteLine("\n-------------------------------------------\n");

            rootCanal.PerformFullAppointment();

            Console.ReadLine();
        }
    }

    // ABSTRACT BASE CLASS
    public abstract class DentalProcedure
    {
        public string AssignedDentist { get; set; }

        protected DentalProcedure(string dentistName)
        {
            AssignedDentist = dentistName;
        }

        // Concrete Method: Shared business logic used identically across all treatments
        public void PrepareOperatoryRoom()
        {
            Console.WriteLine($"[Sterilization] Clinic room sanitized and prepped for {AssignedDentist}.");
        }

        // Abstract Method: Has no body. Every concrete procedure must write its own treatment steps.
        public abstract void ExecuteClinicalProcedure();

        // Template Method: Combines the concrete setup rules and abstract execution contract cleanly
        public void PerformFullAppointment()
        {
            PrepareOperatoryRoom();
            ExecuteClinicalProcedure();
            Console.WriteLine("[Billing] Procedure recorded. Invoice processed for insurance.");
        }
    }

    // DERIVED CLASS 1: Routine Cleaning
    public class RoutineCleaning : DentalProcedure
    {
        public bool NeedsFluorideTreatment { get; set; }

        public RoutineCleaning(string dentistName, bool needsFluoride) : base(dentistName)
        {
            NeedsFluorideTreatment = needsFluoride;
        }

        // Mandatory override implementation
        public override void ExecuteClinicalProcedure()
        {
            Console.WriteLine("[Clinical] Scaling plaque deposits and polishing enamel layers.");
            if (NeedsFluorideTreatment)
            {
                Console.WriteLine("[Clinical] Applied protective topical fluoride varnish layer.");
            }
        }
    }

    // DERIVED CLASS 2: Root Canal Treatment
    public class RootCanalTreatment : DentalProcedure
    {
        public int AffectedCanalCount { get; set; }

        public RootCanalTreatment(string dentistName, int canalCount) : base(dentistName)
        {
            AffectedCanalCount = canalCount;
        }

        // Mandatory override implementation
        public override void ExecuteClinicalProcedure()
        {
            Console.WriteLine($"[Clinical] Administering local anesthesia block.");
            Console.WriteLine($"[Clinical] Cleaning and shaping {AffectedCanalCount} infected root canals.");
            Console.WriteLine("[Clinical] Sealing canals with biocompatible gutta-percha compound.");
        }
    }
}