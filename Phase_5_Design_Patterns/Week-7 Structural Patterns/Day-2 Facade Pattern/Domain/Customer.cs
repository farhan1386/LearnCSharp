using System;
using System.Collections.Generic;
using System.Text;

namespace Phase_5_Design_Patterns.Week_7_Structural_Patterns.Facade_Pattern.Domain
{
    public class Customer
    {
        private string name;

        public Customer(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
        }
    }
}