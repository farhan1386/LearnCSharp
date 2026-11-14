using System;

namespace Phase_2_Intermediate.Week_3_Object_Oriented_Programming
{
    public class Encapsulation
    {
        public static void Run()
        {
            var account = new SecureBankAccount();

            // 1. Try to set valid data through the encapsulation layer
            account.Deposit(1000);
            Console.WriteLine($"Current Balance: ₹{account.Balance}");

            // 2. Try to pass invalid data (Validation logic catches this)
            Console.WriteLine("\n[Attempting invalid actions...]");
            account.Deposit(-500); // ❌ Negative deposits blocked
            account.Withdraw(2000); // ❌ Overdraft blocked

            // 3. Directly editing data is blocked by design
            // account._balance = 999999; // ❌ Compiler Error: '_balance' is private

            Console.ReadLine();
        }
    }

    public class SecureBankAccount
    {
        // 🔐 DATA HIDING: Private backing field cannot be seen or altered from outside this class.
        private double _balance;

        // 🛡️ ENCAPSULATION LAYER: Public property allowing read-only access from outside.
        public double Balance
        {
            get { return _balance; }
            // No 'set' accessor here means the outside world cannot manually overwrite the value.
        }

        // Public method acting as a secure gateway to mutate state with validation
        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Error: Deposit amount must be positive.");
                return;
            }

            _balance += amount;
            Console.WriteLine($"Successfully deposited: ₹{amount}");
        }

        // Another secure gateway method
        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Error: Withdrawal amount must be positive.");
                return;
            }

            if (amount > _balance)
            {
                Console.WriteLine("Error: Insufficient balance for this withdrawal.");
                return;
            }

            _balance -= amount;
            Console.WriteLine($"Successfully withdrew: ₹{amount}");
        }
    }
}