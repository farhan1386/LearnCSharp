using System;
using Phase_5_Design_Patterns.Week_8_Behavioral_Patterns.Observer_Pattern.Domain;

namespace Phase_5_Design_Patterns.Week_8_Behavioral_Patterns.Observer_Pattern.Subject
{
    public class IBM : Stock
    {
        public IBM(string symbol, double price): base(symbol, price)
        {
        }
    }
}