using System;
using System.Collections.Generic;
using System.Text;

namespace Phase_5_Design_Patterns.Week_6_Creational_Design_Patterns.Simple_Factory_Violation
{
    /// <summary>
    /// ANTI-PATTERN: Tight Instantiation.
    /// Hardcoding instantiation directly across client pathways. Adding new notification 
    /// channels (like "WhatsApp") forces you to modify this core class, 
    /// breaking existing closed configurations and violating the Open-Closed Principle (OCP).
    /// </summary>
    public class Simple_Factory_Violation
    {
        public static void Run()
        {
            var notifier = new Simple_Factory_Violation();
            notifier.SendAlert("Email", "john@example.com", "This is an email alert.");
            notifier.SendAlert("SMS", "jane@example.com", "This is an SMS alert.");
            notifier.SendAlert("Push", "bob@example.com", "This is a push alert.");
            notifier.SendAlert("WhatsApp", "alice@example.com", "This is a WhatsApp alert.");
        }

        public void SendAlert(string platform, string recipient, string message)
        {
            // Direct object coupling prevents easy extension
            if (platform.Equals("Email", StringComparison.OrdinalIgnoreCase))
            {
                var email = new EmailNotificationChannel();
                email.Send(recipient, message);
            }
            else if (platform.Equals("SMS", StringComparison.OrdinalIgnoreCase))
            {
                var sms = new SmsNotificationChannel();
                sms.Send(recipient, message);
            }
            // ❌ VIOLATION: Adding Push and WhatsApp forces structural modifications to this code file
            else if (platform.Equals("Push", StringComparison.OrdinalIgnoreCase))
            {
                var push = new PushNotificationChannel();
                push.Send(recipient, message);
            }
            else
            {
                throw new ArgumentException("Unsupported notification channel platform.");
            }
        }
    }

    public class EmailNotificationChannel { public void Send(string to, string msg) => Console.WriteLine($"Email to {to}: {msg}"); }
    public class SmsNotificationChannel { public void Send(string to, string msg) => Console.WriteLine($"SMS to {to}: {msg}"); }
    public class PushNotificationChannel { public void Send(string to, string msg) => Console.WriteLine($"Push to {to}: {msg}"); }
    public class WhatsAppNotificationChannel { public void Send(string to, string msg) => Console.WriteLine($"WhatsApp to {to}: {msg}"); }
}
