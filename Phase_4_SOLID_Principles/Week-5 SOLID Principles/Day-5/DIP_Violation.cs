using System;

namespace Phase_4_SOLID_Principles.Week_5_SOLID_Principles
{
    public class DIP_Violation
    {
        public static void Run()
        {
            var manager = new NotificationManager();
            manager.SendAlert("Your order has shipped!");
        }
    }

    // ❌ Low-Level Module
    public class EmailSender
    {
        public void SendEmail(string message) =>
            Console.WriteLine($"[Email Engine] Sent: {message}");
    }

    // ❌ High-Level Module (Violates DIP due to tight coupling via 'new')
    public class NotificationManager
    {
        private readonly EmailSender _emailSender = new EmailSender();

        public void SendAlert(string alertText)
        {
            // Tightly bound to EmailSender. Cannot swap this out easily.
            _emailSender.SendEmail(alertText);
        }
    }
}