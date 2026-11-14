using System;
using System.Collections.Generic;
using System.Text;

namespace Phase_5_Design_Patterns.Week_7_Structural_Patterns.Decorator_Pattern.Domain
{
    public abstract class LibraryItem
    {
        private int numCopies;

        public int NumCopies
        {
            get { return numCopies; }
            set { numCopies = value; }
        }

        public abstract void Display();
    }
}