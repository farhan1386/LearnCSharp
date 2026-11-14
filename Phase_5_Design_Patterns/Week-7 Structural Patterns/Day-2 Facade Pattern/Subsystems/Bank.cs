using System;
using System.Collections.Generic;
using System.Text;
using Phase_5_Design_Patterns.Week_7_Structural_Patterns.Facade_Pattern.Domain;

namespace Phase_5_Design_Patterns.Week_7_Structural_Patterns.Facade_Pattern.Subsystems
{
    public class Bank
    {
        public bool HasSufficientSavings(Customer c, int amount)
        {
            Console.WriteLine("Check bank for " + c.Name);
            return true;
        }
    }
}
