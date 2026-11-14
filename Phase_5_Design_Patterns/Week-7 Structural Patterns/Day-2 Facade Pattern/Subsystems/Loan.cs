using System;
using System.Collections.Generic;
using System.Text;
using Phase_5_Design_Patterns.Week_7_Structural_Patterns.Facade_Pattern.Domain;

namespace Phase_5_Design_Patterns.Week_7_Structural_Patterns.Facade_Pattern.Subsystems
{
    public class Loan
    {
        public bool HasNoBadLoans(Customer c)
        {
            Console.WriteLine("Check loans for " + c.Name);
            return true;
        }
    }
}
