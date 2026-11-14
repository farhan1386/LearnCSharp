using Phase_5_Design_Patterns.Week_7_Structural_Patterns.Decorator_Pattern.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Phase_5_Design_Patterns.Week_7_Structural_Patterns.Decorator_Pattern
{
    public abstract class Decorator : LibraryItem
    {
        protected LibraryItem libraryItem;
        // Constructor
        public Decorator(LibraryItem libraryItem)
        {
            this.libraryItem = libraryItem;
        }
        public override void Display()
        {
            libraryItem.Display();
        }
    }
}
