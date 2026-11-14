using Phase_5_Design_Patterns.Week_6_Creational_Design_Patterns.Factory.Enum;
using Phase_5_Design_Patterns.Week_6_Creational_Design_Patterns.Factory.Interfaces;
using Phase_5_Design_Patterns.Week_6_Creational_Design_Patterns.SimpleFactory.NotificationFactory;

namespace Phase_5_Design_Patterns.Week_6_Creational_Design_Patterns.Simple_Factory
{
    public static class Simple_Factory
    {
        public static void Run()
        {
            INotification notification = NotificationFactory.CreateNotification(NotificationChannel.Email);
            notification.Send("user@example.com", "Hello, this is a emailnotificationtest message.");
            Console.ReadLine();
        }
    }
}