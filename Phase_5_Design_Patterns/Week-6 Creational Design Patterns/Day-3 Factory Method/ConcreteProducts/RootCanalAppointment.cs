using Phase_5_Design_Patterns.Week_6_Creational_Design_Patterns.FactoryMethod.Interfaces;

namespace Phase_5_Design_Patterns.Week_6_Creational_Design_Patterns.FactoryMethod.ConcreteProducts
{
    public class RootCanalAppointment : IAppointment
    {
        public void prepareRoom()
        {
            Console.WriteLine("Preparing operatory for root canal.");
        }

        public decimal calculateCost()
        {
            decimal baseFee = 350.00m;
            decimal supplies = 45.00m;
            return baseFee + supplies;
        }
    }
}