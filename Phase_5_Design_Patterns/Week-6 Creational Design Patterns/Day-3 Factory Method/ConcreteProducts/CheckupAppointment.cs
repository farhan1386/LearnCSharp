using Phase_5_Design_Patterns.Week_6_Creational_Design_Patterns.FactoryMethod.Interfaces;

namespace Phase_5_Design_Patterns.Week_6_Creational_Design_Patterns.FactoryMethod.ConcreteProducts
{
    public class CheckupAppointment : IAppointment
    {
        public void prepareRoom()
        {
            Console.WriteLine("Preparing exam room for checkup.");
        }

        public decimal calculateCost()
        {
            decimal baseFee = 50.00m;
            decimal supplies = 9.99m;
            return baseFee + supplies;
        }
    }
}