using System;
using System.Collections.Generic;
using Phase_5_Design_Patterns.Week_7_Structural_Patterns.Decorator_Pattern.Domain;

namespace Phase_5_Design_Patterns.Week_7_Structural_Patterns.Decorator_Pattern_Violation
{
    public class Decorator_Pattern_Violation
    {
        public static void Run()
        {
            Console.WriteLine("=== Executing Inheritance-Based Responsibility Assignment (VIOLATION) ===");

            // Create a standard book
            Book standardBook = new Book("Worley", "Inside ASP.NET", 10);
            standardBook.Display();

            // ❌ CRITICAL DESIGN VIOLATION 1: Static Type Lock
            // We cannot dynamically convert an existing 'Video' object into a borrowable one at runtime.
            // We must instantiate a completely different subclass explicitly.
            Console.WriteLine("\nInstantiating a hardcoded BorrowableVideo subclass:");
            BorrowableVideo borrowableVideo = new BorrowableVideo("Spielberg", "Jaws", 23, 92);

            borrowableVideo.BorrowItem("Customer #1");
            borrowableVideo.BorrowItem("Customer #2");
            borrowableVideo.Display();
        }
    }

    // =========================================================================
    // THE VIOLATION: Creating concrete subclasses to add behavior via inheritance
    // =========================================================================

    // ❌ CRITICAL DESIGN VIOLATION 2: Class Explosion
    // If we want a borrowable book, we have to duplicate this exact code inside a 'BorrowableBook' class!
    public class BorrowableVideo : Video
    {
        protected readonly List<string> borrowers = new List<string>();

        public BorrowableVideo(string director, string title, int numCopies, int playTime)
            : base(director, title, numCopies, playTime)
        {
        }

        public void BorrowItem(string name)
        {
            borrowers.Add(name);
            NumCopies--; // Mutating base properties directly
        }

        public void ReturnItem(string name)
        {
            borrowers.Remove(name);
            NumCopies++;
        }

        public override void Display()
        {
            // Reuses base video print layout but has to append code here
            base.Display();
            foreach (string borrower in borrowers)
            {
                Console.WriteLine(" borrower: " + borrower);
            }
        }
    }
}