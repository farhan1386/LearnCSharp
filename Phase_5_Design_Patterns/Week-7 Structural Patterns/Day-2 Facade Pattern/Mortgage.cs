using Phase_5_Design_Patterns.Week_7_Structural_Patterns.Facade_Pattern.Domain;
using Phase_5_Design_Patterns.Week_7_Structural_Patterns.Facade_Pattern.Subsystems;

namespace Phase_5_Design_Patterns.Week_7_Structural_Patterns.Facade_Pattern
{
    public class Mortgage
    {
        Bank bank = new Bank();
        Loan loan = new Loan();
        Credit credit = new Credit();

        public bool IsEligible(Customer cust, int amount)
        {
            Console.WriteLine("{0} applies for {1:C} loan\n", cust.Name, amount);

            bool eligible = true;

            if (!bank.HasSufficientSavings(cust, amount))
            {
                eligible = false;
            }
            else if (!loan.HasNoBadLoans(cust))
            {
                eligible = false;
            }
            else if (!credit.HasGoodCredit(cust))
            {
                eligible = false;
            }

            return eligible;
        }
    }
}