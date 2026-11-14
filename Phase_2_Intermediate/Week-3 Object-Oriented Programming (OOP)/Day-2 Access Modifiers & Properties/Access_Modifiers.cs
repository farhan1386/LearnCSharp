using System;

namespace Phase_2_Intermediate.Week_3_Object_Oriented_Programming
{
    public class Access_Modifiers
    {
        public static void Run()
        {
            var myAccount = new SavingsAccount();

            // 1. PUBLIC: Accessible anywhere
            myAccount.AccountHolder = "Farhan Ahmed";

            // 2. INTERNAL: Accessible within this project assembly
            myAccount.BranchName = "Downtown Branch";

            // 3. PRIVATE: Not accessible here
            // myAccount.AccountPin = 1234; // ❌ Compiler Error: Inaccessible due to protection level

            // 4. PROTECTED: Not accessible here directly
            // myAccount.RoutingNumber = "RT9876"; // ❌ Compiler Error: Only accessible inside the class or child classes

            // Using public methods to interact with hidden data securely
            myAccount.InitializeAccount(8899, "RT-IND-9876");
            myAccount.Deposit(5000);
            myAccount.ApplyInterest();
            myAccount.DisplayAccountSummary();

            Console.ReadLine();
        }
    }

    // Base Class
    public class BankAccount
    {
        // PUBLIC: Visible everywhere
        public string AccountHolder { get; set; } = string.Empty;

        // INTERNAL: Visible inside the same project
        internal string BranchName { get; set; } = string.Empty;

        // PRIVATE: Strictly visible ONLY within this BankAccount class
        private int AccountPin { get; set; }

        // PROTECTED: Visible inside this class AND inherited child classes (like SavingsAccount)
        protected string RoutingNumber { get; set; } = string.Empty;

        // Public helper method to set private and protected fields safely
        public void InitializeAccount(int pin, string routing)
        {
            AccountPin = pin;
            RoutingNumber = routing;
        }

        public void DisplayAccountSummary()
        {
            Console.WriteLine($"Holder: {AccountHolder}");
            Console.WriteLine($"Branch: {BranchName}");
            // Can access private field safely from inside the class
            Console.WriteLine($"PIN Masked: ****{(AccountPin % 100):D2}");
        }
    }

    // Child Class inheriting from BankAccount
    public class SavingsAccount : BankAccount
    {
        public double Balance { get; private set; }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void ApplyInterest()
        {
            // Demonstrating PROTECTED: SavingsAccount can access RoutingNumber from the parent class
            if (!string.IsNullOrEmpty(RoutingNumber))
            {
                Balance += Balance * 0.04; // 4% interest applied
                Console.WriteLine($"[Success] Interest applied via routing pipeline: {RoutingNumber}");
            }
        }
    }
}