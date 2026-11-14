using System;

namespace Phase_4_SOLID_Principles.Week_5_SOLID_Principles
{ 
    public class Diagnostics_Violation
    {
        public static void Run()
        {
            var processor = new Diagnostics_Violation();
            processor.ProcessUserAction("Admin");
            processor.ProcessUserAction("Guest");
        }
        public void ProcessUserAction(string userRole)
        {
            // ❌ Code Smell: Type-checking switch blocks. 
            // Indicates Open-Closed Principle violation.
            switch (userRole)
            {
                case "Admin":
                    Console.WriteLine("Accessing database configurations...");
                    break;
                case "Guest":
                    // ❌ Code Smell: Throwing NotImplementedException inside shared processing routines.
                    // Indicates Liskov Substitution Principle violation.
                    throw new NotImplementedException("Guests cannot modify database states.");
            }
        }
    }
}