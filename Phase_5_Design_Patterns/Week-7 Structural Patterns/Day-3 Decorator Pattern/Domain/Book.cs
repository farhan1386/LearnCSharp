using System;
using System.Collections.Generic;
using System.Text;
using Phase_5_Design_Patterns.Week_7_Structural_Patterns.Decorator_Pattern.Domain;

namespace Phase_5_Design_Patterns.Week_7_Structural_Patterns.Decorator_Pattern.Domain
{
    public class Book : LibraryItem
    {
        private string author;
        private string title;

        public Book(string author, string title, int numCopies)
        {
            this.author = author;
            this.title = title;
            this.NumCopies = numCopies;
        }

        public override void Display()
        {
            Console.WriteLine("\nBook ------ ");
            Console.WriteLine(" Author: {0}", author);
            Console.WriteLine(" Title: {0}", title);
            Console.WriteLine(" # Copies: {0}", NumCopies);
        }
    }
}