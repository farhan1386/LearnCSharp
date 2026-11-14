using Phase_5_Design_Patterns.Week_8_Behavioral_Patterns.Observer_Pattern.Interfaces;

namespace Phase_5_Design_Patterns.Week_8_Behavioral_Patterns.Observer_Pattern.Domain
{
    public abstract class Stock
    {
        private string symbol;
        private double price;
        private readonly List<IInvestor> investors = new List<IInvestor>();

        protected Stock(string symbol, double price)
        {
            this.symbol = symbol;
            this.price = price;
        }

        public void Attach(IInvestor investor)
        {
            if (investor != null && !investors.Contains(investor))
            {
                investors.Add(investor);
            }
        }

        public void Detach(IInvestor investor)
        {
            if (investor != null)
            {
                investors.Remove(investor);
            }
        }

        public void Notify()
        {
            foreach (IInvestor investor in investors)
            {
                investor.Update(this);
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
                    Notify();
                }
            }
        }

        public string Symbol
        {
            get { return symbol; }
        }
    }
}