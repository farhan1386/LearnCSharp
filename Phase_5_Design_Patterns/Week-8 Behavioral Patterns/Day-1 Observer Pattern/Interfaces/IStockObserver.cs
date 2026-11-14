namespace Phase_5_Design_Patterns.Week_8_Behavioral_Patterns.Observer_Pattern.Interfaces
{
    public interface IStockObserver
    {
        void OnStockLow(string productName, int currentQuantity);
    }
}