using Phase_5_Design_Patterns.Week_7_Structural_Patterns.Facade_Pattern.Domain;
using Phase_5_Design_Patterns.Week_7_Structural_Patterns.Facade_Pattern.Subsystems;

namespace Phase_5_Design_Patterns.Week_7_Structural_Patterns.Facade_Pattern_Violation
{
    public class Facade_Pattern_Violation
    {
        public static void Run()
        {
            Console.WriteLine("=== Executing Fragmented/Coupled Subsystem Workflow (VIOLATION) ===");

            // ❌ CRITICAL DESIGN VIOLATION 1: Direct architectural coupling.
            // The client must know about, manage, and manually instantiate every independent subsystem component.
            Bank bankSubsystem = new Bank();
            Loan loanSubsystem = new Loan();
            Credit creditSubsystem = new Credit();

            // Initializing domain entity
            Customer customer = new Customer("Ann McKinsey");
            int loanAmount = 125000;

            Console.WriteLine("{0} applies for {1:C} loan directly through raw subsystems...\n", customer.Name, loanAmount);

            bool eligible = true;

            // ❌ CRITICAL DESIGN VIOLATION 2: Fragile operational flow orchestration.
            // The logic tracking the steps and requirements is exposed to the client.
            // If any method signature shifts tomorrow, this orchestrator logic breaks immediately.
            if (!bankSubsystem.HasSufficientSavings(customer, loanAmount))
            {
                eligible = false;
            }
            else if (!loanSubsystem.HasNoBadLoans(customer))
            {
                eligible = false;
            }
            else if (!creditSubsystem.HasGoodCredit(customer))
            {
                eligible = false;
            }

            Console.WriteLine("\n" + customer.Name + " has been " + (eligible ? "Approved" : "Rejected"));

            Console.WriteLine("\nPress any key to finalize simulation...");
            Console.ReadKey();
        }
    }
}