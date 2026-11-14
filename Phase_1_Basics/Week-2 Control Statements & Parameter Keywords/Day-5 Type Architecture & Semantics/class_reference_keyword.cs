using System;
using System.Collections.Generic;
using System.Text;

namespace Phase_1_Basics.Week_2_Control_Statements_Parameter_Keywords
{
    public class class_reference_keyword
    {
        public static void Run()
        {
            BankAccount primaryCard = new BankAccount("Farhan Ahmed", 2500.00);
            BankAccount jointCard = primaryCard;

            Console.WriteLine("=== INITIAL ACCOUNT STATUS ===");
            Console.WriteLine($"Primary Holder Balance: ${primaryCard.Balance:F2}");
            Console.WriteLine($"Joint Holder Balance:   ${jointCard.Balance:F2}");

            jointCard.Balance -= 450.00;

            Console.WriteLine("\n=== STATUS AFTER JOINT CARD TRANSACTION ===");
            Console.WriteLine($"Primary Holder Balance: ${primaryCard.Balance:F2}");
            Console.WriteLine($"Joint Holder Balance:   ${jointCard.Balance:F2}");

            Console.ReadLine();
        }

        public class BankAccount
        {
            public string AccountHolder { get; set; }
            public double Balance { get; set; }

            public BankAccount(string accountHolder, double balance)
            {
                AccountHolder = accountHolder;
                Balance = balance;
            }
        }
    }
}