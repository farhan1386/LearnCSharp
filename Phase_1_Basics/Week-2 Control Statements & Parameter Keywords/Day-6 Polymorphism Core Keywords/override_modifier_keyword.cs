using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Phase_1_Basics.Week_2_Control_Statements_Parameter_Keywords
{
    public class override_modifier_keyword
    {
        public static void Run()
        {
            PaymentProcessor processor1 = new CreditCardProcessor();
            PaymentProcessor processor2 = new PayPalProcessor();

            ExecuteTransaction(processor1, 99.99m);
            ExecuteTransaction(processor2, 45.50m);

            Console.ReadLine();
        }

        public static void ExecuteTransaction(PaymentProcessor processor, decimal total)
        {
            processor.ProcessPayment(total);
        }
    }

    public abstract class PaymentProcessor
    {
        public abstract void ProcessPayment(decimal amount);
    }

    public class CreditCardProcessor : PaymentProcessor
    {
        public override void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Starting security check for payment of ${amount}...");
            Console.WriteLine("[Credit Card] Routing transaction through Visa/Mastercard network.");
            Console.WriteLine($"[Credit Card] Charged successfully: ${amount}\n");
        }
    }

    public class PayPalProcessor : PaymentProcessor
    {
        public override void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Starting security check for payment of ${amount}...");
            Console.WriteLine("[PayPal] Redirecting user to PayPal secure login API.");
            Console.WriteLine($"[PayPal] Express checkout completed for: ${amount}\n");
        }
    }
}