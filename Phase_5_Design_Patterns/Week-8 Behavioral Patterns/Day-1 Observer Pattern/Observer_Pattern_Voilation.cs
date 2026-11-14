using Phase_5_Design_Patterns.Week_8_Behavioral_Patterns.Observer_Pattern.Observers;

namespace Phase_5_Design_Patterns.Week_8_Behavioral_Design_Patterns.Observer_Pattern_Voilation
{
    public class Observer_Pattern_Voilation
    {
        public static void Run()
        {
            Console.WriteLine("=== Executing Coupled Stock Pipeline (VIOLATION) ===");

            // 1. Direct initialization of the tightly coupled subject
            var concreteIbm = new ViolatedIBM("IBM", 120.00);

            // 2. Concrete observer references
            var investor1 = new Investor("Sorros");
            var investor2 = new Investor("Berkshire");

            // ❌ CRITICAL DESIGN VIOLATION: Manual attachment directly to concrete class lists
            concreteIbm.AttachConcreteInvestor(investor1);
            concreteIbm.AttachConcreteInvestor(investor2);

            // 3. Modifying the price triggers the coupled broadcast tracking system
            concreteIbm.Price = 120.10;
            concreteIbm.Price = 121.00;
        }
    }

    // =========================================================================
    // THE COUPLING VIOLATION: Subject bound explicitly to a single observer type
    // =========================================================================
    public class ViolatedIBM
    {
        private string symbol;
        private double price;

        // ❌ CRITICAL DESIGN VIOLATION 1: Explicit concrete collection typing.
        // Instead of managing abstractions (IInvestor), this class hard-binds directly to 'Investor'.
        private readonly List<Investor> concreteInvestors = new List<Investor>();

        public ViolatedIBM(string symbol, double price)
        {
            this.symbol = symbol;
            this.price = price;
        }

        public void AttachConcreteInvestor(Investor investor)
        {
            if (investor != null && !concreteInvestors.Contains(investor))
            {
                concreteInvestors.Add(investor);
            }
        }

        public void DetachConcreteInvestor(Investor investor)
        {
            if (investor != null)
            {
                concreteInvestors.Remove(investor);
            }
        }

        public void NotifyConcreteInvestors()
        {
            // ❌ CRITICAL DESIGN VIOLATION 2: The iteration contract is hardcoded.
            // If the firm introduces a 'Broker', 'AutomatedBot', or 'MobileAppNotification' type tomorrow,
            // this loop structure shatters and you must completely open and rewrite this subject file.
            foreach (Investor investor in concreteInvestors)
            {
                // Passing a 'Stock' reference to an investor requires an abstracted base class instance.
                // Because we broke the inheritance chain here, we pass 'null' or suffer compilation errors.
                investor.Update(null);

                // Print statement showing direct execution bypassing standard patterns
                Console.WriteLine($"[Coupled Push] Directly pushed raw notification sequence bypasses to: {investor.Stock}");
            }
            Console.WriteLine("");
        }

        public double Price
        {
            get { return price; }
            set
            {
                if (price != value)
                {
                    price = value;
                    NotifyConcreteInvestors();
                }
            }
        }

        public string Symbol => symbol;
    }
}