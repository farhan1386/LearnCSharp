using Phase_5_Design_Patterns.Week_6_Creational_Design_Patterns.Factory.Interfaces;

namespace Phase_5_Design_Patterns.Week_6_Factory_ConcreteProducts
{
    public class WhatsAppNotification : INotification
    {
        public void Send(string recipient, string message)
        {
            Console.WriteLine($"Sending WhatsApp notification to {recipient}: {message}");
        }
    }
}