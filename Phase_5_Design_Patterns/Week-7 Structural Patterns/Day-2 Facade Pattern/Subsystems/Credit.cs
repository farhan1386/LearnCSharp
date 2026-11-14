using System;
using System.Collections.Generic;
using System.Text;
using Phase_5_Design_Patterns.Week_7_Structural_Patterns.Facade_Pattern.Domain;

namespace Phase_5_Design_Patterns.Week_7_Structural_Patterns.Facade_Pattern.Subsystems
{
    public class Credit
    {
        public bool HasGoodCredit(Customer c)
        {
            Console.WriteLine("Check credit for " + c.Name);
            return true;
        }
    }
}
