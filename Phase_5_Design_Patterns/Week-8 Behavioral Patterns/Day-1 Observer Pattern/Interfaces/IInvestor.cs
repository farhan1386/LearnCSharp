using Phase_5_Design_Patterns.Week_8_Behavioral_Patterns.Observer_Pattern.Domain;

namespace Phase_5_Design_Patterns.Week_8_Behavioral_Patterns.Observer_Pattern.Interfaces
{
    public interface IInvestor
    {
        void Update(Stock stock);
    }
}