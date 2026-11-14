using System;

namespace Phase_2_Intermediate.Week_3_Object_Oriented_Programming
{
    public class Abstraction
    {
        public static void Run()
        {
            // 1. Using Abstraction via an Interface
            IMessageSender emailSender = new EmailNotification();
            emailSender.SendMessage("Hello Farhan! Welcome to Phase 2.");

            Console.WriteLine();

            // 2. Using Abstraction via an Abstract Class
            PaymentProcessor payment = new UpiPayment();
            payment.ProcessTransaction(1500.00);

            Console.ReadLine();
        }
    }

    // Layer 1: Interface Abstraction (What it does)
    public interface IMessageSender
    {
        void SendMessage(string message); // Abstract method contract
    }

    public class EmailNotification : IMessageSender
    {
        public void SendMessage(string message)
        {
            // Concrete implementation
            Console.WriteLine("[Email Notification] Connecting to SMTP server...");
            Console.WriteLine($"[Email Sent] Content: {message}");
        }
    }

    // Layer 2: Abstract Class Abstraction (Partial Implementation)
    public abstract class PaymentProcessor
    {
        // Non-abstract method: Shared functionality across all payments
        private void ValidateAmount(double amount)
        {
            Console.WriteLine($"[System] Validating payment amount: ₹{amount}");
        }

        // Abstract method: Must be defined by child classes uniquely
        public abstract void ExecutePayment(double amount);

        // Template pattern combining both
        public void ProcessTransaction(double amount)
        {
            ValidateAmount(amount);
            ExecutePayment(amount);
        }
    }

    public class UpiPayment : PaymentProcessor
    {
        public override void ExecutePayment(double amount)
        {
            // Concrete implementation
            Console.WriteLine($"[UPI Payment] Initiating mobile secure gateway transaction of ₹{amount}...");
            Console.WriteLine("[Success] Payment captured via Virtual Payment Address (VPA).");
        }
    }
}