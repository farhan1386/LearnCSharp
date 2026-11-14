using System;

namespace Phase_4_SOLID_Principles.Week_5_SOLID_Principles
{
    public class ISP_Solution
    {
        public static void Run()
        {
            RemediationSuperLaserPrinter officeHardware = new RemediationSuperLaserPrinter();
            officeHardware.Print();
            officeHardware.Scan();

            IPrinter homeHardware = new RemediationLiquidInkPrinter();
            homeHardware.Print();
        }
    }

    public interface IPrinter
    {
        void Print();
    }

    public interface IScanner
    {
        void Scan();
    }

    public interface IFaxMachine
    {
        void Fax();
    }

    public class RemediationSuperLaserPrinter : IPrinter, IScanner, IFaxMachine
    {
        public void Print() => Console.WriteLine("Laser printing completed.");
        public void Scan() => Console.WriteLine("Document scanned via cloud scanner.");
        public void Fax() => Console.WriteLine("Fax sent across business network.");
    }

    public class RemediationLiquidInkPrinter : IPrinter
    {
        public void Print() => Console.WriteLine("Inkjet printing completed.");
    }
}
