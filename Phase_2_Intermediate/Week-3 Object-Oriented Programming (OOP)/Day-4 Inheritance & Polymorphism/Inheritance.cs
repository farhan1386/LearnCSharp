using System;

namespace Phase_2_Intermediate.Week_3_Object_Oriented_Programming
{
    public class Inheritance
    {
        public static void Run()
        {
            // Instantiating a specific child class for SMS
            var smsAlert = new SmsNotification()
            {
                RecipientId = "USER_9923",       // Inherited from Notification
                MessageBody = "Your OTP is 4821", // Inherited from Notification
                PhoneNumber = "+919876543210"     // Unique to SmsNotification
            };

            // 1. Call inherited validation method from base class
            if (smsAlert.IsValidNotification())
            {
                // 2. Call specialized child class behavior
                smsAlert.SendSmsThroughGateway();
            }

            Console.ReadLine();
        }
    }

    // BASE CLASS: Contains core features shared by ALL notification channels
    public class Notification
    {
        public string RecipientId { get; set; } = string.Empty;
        public string MessageBody { get; set; } = string.Empty;

        public bool IsValidNotification()
        {
            // Simple base validation logic
            return !string.IsNullOrWhiteSpace(RecipientId) && !string.IsNullOrWhiteSpace(MessageBody);
        }
    }

    // DERIVED CLASS: Inherits from Notification and adds SMS-specific infrastructure
    public class SmsNotification : Notification
    {
        public string PhoneNumber { get; set; } = string.Empty;

        public void SendSmsThroughGateway()
        {
            // Accessing the inherited 'MessageBody' property from the base Notification class
            Console.WriteLine("[Gateway] Routing SMS payload to mobile operator...");
            Console.WriteLine($"[Sent SMS] Destination: {PhoneNumber} | Text: \"{MessageBody}\"");
        }
    }
}
