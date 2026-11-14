using System;

namespace Phase_4_SOLID_Principles.Week_5_SOLID_Principles
{
    public class ISP_Violation
    {
        public static void Run()
        {
            IAllInOnePrinter officePrinter = new SuperLaserPrinter();
            officePrinter.PrintDocument();
            officePrinter.ScanDocument();

            IAllInOnePrinter homePrinter = new LiquidInkPrinter();
            homePrinter.PrintDocument();

            // ❌ Crash! The client didn't know this budget printer couldn't scan.
            homePrinter.ScanDocument();
        }
    }

    // ❌ Violation: A bloated interface mixing unrelated behaviors
    public interface IAllInOnePrinter
    {
        void PrintDocument();
        void ScanDocument();
        void FaxDocument();
    }

    public class SuperLaserPrinter : IAllInOnePrinter
    {
        public void PrintDocument() => Console.WriteLine("Laser printing completed.");
        public void ScanDocument() => Console.WriteLine("Document scanned via cloud scanner.");
        public void FaxDocument() => Console.WriteLine("Fax sent across business network.");
    }

    public class LiquidInkPrinter : IAllInOnePrinter
    {
        public void PrintDocument() => Console.WriteLine("Inkjet printing completed.");

        // ❌ Violation: Forced to implement methods it physically cannot do
        public void ScanDocument() => throw new NotImplementedException("Hardware error: No scanner available.");
        public void FaxDocument() => throw new NotImplementedException("Hardware error: No telephone modem.");
    }
}