using System;
using System.IO;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Phase_4_SOLID_Principles.Week_5_SOLID_Principles
{
    public class SRP_Solution
    {
        public static void Run()
        {
            var calculator = new InvoiceCalculator();
            var formatter = new InvoiceFormatter();
            var fileRepository = new InvoiceFileRepository();
            var logger = new SimpleLogger();

            var processor = new InvoiceProcessor(calculator, formatter, fileRepository, logger);

            double total = processor.CalculateTotal(100.0, 15.0);
            Console.WriteLine($"Invoice calculated total: {total}");

            processor.SaveInvoiceReport("invoice_record.txt");
            Console.WriteLine("Invoice saved to disk.");

            Console.ReadKey();
        }
    }

    public class InvoiceCalculator
    {
        public double CalculateTotal(double price, double tax)
        {
            if (price <= 0) throw new ArgumentException("Price must be positive.");
            return price + tax;
        }
    }

    public class InvoiceFormatter
    {
        public string FormatReport(string rawDetails)
        {
            return $"--- INVOICE REPORT ---\nGenerated: {DateTime.Now}\nDetails: {rawDetails}";
        }
    }

    public class InvoiceFileRepository
    {
        public void WriteToDisk(string filename, string content)
        {
            File.WriteAllText(filename, content);
        }
    }

    public class SimpleLogger
    {
        private const string LogFile = "application_log.txt";
        public void LogInformation(string message)
        {
            File.AppendAllText(LogFile, $"[{DateTime.Now}] {message}\n");
        }
    }

    public class InvoiceProcessor
    {
        private readonly InvoiceCalculator _calculator;
        private readonly InvoiceFormatter _formatter;
        private readonly InvoiceFileRepository _repository;
        private readonly SimpleLogger _logger;

        public InvoiceProcessor(
            InvoiceCalculator calculator,
            InvoiceFormatter formatter,
            InvoiceFileRepository repository,
            SimpleLogger logger)
        {
            _calculator = calculator;
            _formatter = formatter;
            _repository = repository;
            _logger = logger;
        }

        public double CalculateTotal(double price, double tax)
        {
            return _calculator.CalculateTotal(price, tax);
        }

        public void SaveInvoiceReport(string filename)
        {
            string formattedContent = _formatter.FormatReport("Invoice Details");
            _repository.WriteToDisk(filename, formattedContent);
            _logger.LogInformation($"Invoice written cleanly to {filename}");
        }
    }
}