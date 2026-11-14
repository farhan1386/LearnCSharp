using Phase_5_Design_Patterns.Week_6_Creational_Design_Patterns.Factory.Enum;
using Phase_5_Design_Patterns.Week_6_Creational_Design_Patterns.Factory.Interfaces;
using Phase_5_Design_Patterns.Week_6_Factory_ConcreteProducts;

namespace Phase_5_Design_Patterns.Week_6_Creational_Design_Patterns.SimpleFactory.NotificationFactory
{
    public static class NotificationFactory
    {
        public static INotification CreateNotification(NotificationChannel channel)
        {
            switch (channel)
            {
                case NotificationChannel.Email:
                    return new EmailNotification();
                case NotificationChannel.Sms:
                    return new SmsNotification();
                case NotificationChannel.Push:
                    return new PushNotification();
                case NotificationChannel.WhatsApp:
                    return new WhatsAppNotification();
                default:
                    throw new ArgumentException("Invalid notification channel");
            }
        }
    }
}
