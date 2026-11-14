using Phase_5_Design_Patterns.Week_8_Behavioral_Patterns.Observer_Pattern.Observers;
using Phase_5_Design_Patterns.Week_8_Behavioral_Patterns.Observer_Pattern.Subject;

namespace Phase_5_Design_Patterns.Week_8_Behavioral_Design_Patterns.Observer_Pattern
{
    public class Observer_Pattern
    {
        public static void Run()
        {
            Console.WriteLine("=== Executing Decoupled Observer Pattern Ticker Workflow ===");

            // 1. Create IBM stock entry (Subject)
            IBM ibm = new IBM("IBM", 120.00);

            // 2. Attach market investors (Observers) to listen for mutations
            ibm.Attach(new Investor("Sorros"));
            ibm.Attach(new Investor("Berkshire"));

            // 3. Fluctuating price updates trigger automated broadcast state notifications
            ibm.Price = 120.10;
            ibm.Price = 121.00;
            ibm.Price = 120.50;
            ibm.Price = 120.75;

            Console.WriteLine("Press any key to finalize simulation...");
            Console.ReadKey();
        }
    }
}