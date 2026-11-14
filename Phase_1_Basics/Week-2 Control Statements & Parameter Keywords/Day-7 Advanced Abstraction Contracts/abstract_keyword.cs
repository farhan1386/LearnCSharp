using System;
using System.Collections.Generic;
using System.Text;

namespace Phase_1_Basics.Week_2_Control_Statements_Parameter_Keywords
{
    public class abstract_keyword
    {
        public static void Run()
        {
            List<Document> documents = new List<Document>
            {
                new PdfDocument(),
                new WordDocument()
            };

            foreach (var doc in documents)
            {
                doc.LoadMetadata();
                doc.Open();
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }

    public abstract class Document
    {
        public void LoadMetadata()
        {
            Console.WriteLine("Reading file metadata into memory system...");
        }

        public abstract void Open();
    }

    public class PdfDocument : Document
    {
        public override void Open()
        {
            Console.WriteLine("Opening PDF file in a secure PDF viewer reader.");
        }
    }

    public class WordDocument : Document
    {
        public override void Open()
        {
            Console.WriteLine("Opening Word document in an editable text layout.");
        }
    }
}