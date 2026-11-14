using System;
using System.IO;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Phase_4_SOLID_Principles.Week_5_SOLID_Principles
{
    public class SRP_Violation
    {
        public static void Run()
        {
            var invoice = new Invoice();

            double total = invoice.CalculateTotal(100.0, 15.0);
            Console.WriteLine($"Invoice calculated total: {total}");

            invoice.SaveToFile("invoice_record.txt");
            Console.WriteLine("Invoice saved to disk.");

            Console.ReadKey();
        }
    }

    public class Invoice
    {
        public double CalculateTotal(double price, double tax)
        {
            if (price <= 0) throw new ArgumentException("Price must be positive.");
            return price + tax;
        }

        public void SaveToFile(string filename)
        {
            string fileContent = $"--- INVOICE REPORT ---\nGenerated: {DateTime.Now}\nDetails: Invoice Details";

            File.WriteAllText(filename, fileContent);

            File.AppendAllText("application_log.txt", $"[{DateTime.Now}] Invoice written to {filename}\n");
        }
    }
}