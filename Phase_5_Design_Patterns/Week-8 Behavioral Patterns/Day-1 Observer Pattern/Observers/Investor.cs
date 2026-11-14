using Phase_5_Design_Patterns.Week_8_Behavioral_Patterns.Observer_Pattern.Domain;
using Phase_5_Design_Patterns.Week_8_Behavioral_Patterns.Observer_Pattern.Interfaces;

namespace Phase_5_Design_Patterns.Week_8_Behavioral_Patterns.Observer_Pattern.Observers
{
    public class Investor : IInvestor
    {
        private string name;
        private Stock stock;

        public Investor(string name)
        {
            this.name = name;
        }

        public void Update(Stock stock)
        {
            Console.WriteLine("Notified {0} of {1}'s change to {2:C}",
                name, stock.Symbol, stock.Price);
        }

        public Stock Stock
        {
            get { return stock; }
            set { stock = value; }
        }
    }
}