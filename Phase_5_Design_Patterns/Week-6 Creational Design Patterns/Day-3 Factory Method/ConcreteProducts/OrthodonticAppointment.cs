using Phase_5_Design_Patterns.Week_6_Creational_Design_Patterns.FactoryMethod.Interfaces;

namespace Phase_5_Design_Patterns.Week_6_Creational_Design_Patterns.FactoryMethod.ConcreteProducts
{
    public class OrthodonticAppointment : IAppointment
    {
        public void prepareRoom()
        {
            Console.WriteLine("Preparing operatory for orthodontic treatment.");
        }

        public decimal calculateCost()
        {
            decimal baseFee = 200.00m;
            decimal supplies = 75.00m;
            return baseFee + supplies;
        }
    }
}