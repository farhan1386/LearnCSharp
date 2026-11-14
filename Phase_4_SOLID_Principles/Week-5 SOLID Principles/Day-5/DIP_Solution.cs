using System;
using System.Collections.Generic;

namespace Phase_4_SOLID_Principles.Week_5_SOLID_Principles
{
    public class DIP_Solution
    {
        public static void Run()
        {
            IMessageService emailChannel = new RemediationEmailSender();
            IMessageService smsChannel = new RemediationSmsSender();

            var emailAlertManager = new RemediationNotificationManager(emailChannel);
            emailAlertManager.SendAlert("Hello via Email!");

            var smsAlertManager = new RemediationNotificationManager(smsChannel);
            smsAlertManager.SendAlert("Hello via SMS Text!");
        }
    }

    public interface IMessageService
    {
        void Send(string message);
    }

    public class RemediationEmailSender : IMessageService
    {
        public void Send(string message) =>
            Console.WriteLine($"[DIP Remediation - Email Engine] Dispatching: {message}");
    }

    public class RemediationSmsSender : IMessageService
    {
        public void Send(string message) =>
            Console.WriteLine($"[DIP Remediation - SMS Engine] Texting: {message}");
    }

    public class RemediationNotificationManager
    {
        private readonly IMessageService _messageService;

        public RemediationNotificationManager(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public void SendAlert(string alertText)
        {
            _messageService.Send(alertText);
        }
    }
}