using System;
using System.Collections.Generic;
using System.Text;

namespace Phase_1_Basics.Week_1_Language_Basics_Fundamentals
{
    public class Relational_Operators
    {
        public static void Run()
        {
            int userAge = 21;
            int restrictedContentAgeLimit = 18;
            double userAccountBalance = 45.00;
            double goldMembershipCost = 50.00;
            string inputPromoCode = "SUMMER20";
            string validPromoCode = "WINTER20";

            bool isOfLegalAge = userAge >= restrictedContentAgeLimit;
            bool isUnderage = userAge < restrictedContentAgeLimit;
            bool canAffordGold = userAccountBalance >= goldMembershipCost;
            bool hasShortfall = userAccountBalance < goldMembershipCost;
            bool isPromoCodeValid = inputPromoCode == validPromoCode;
            bool isPromoCodeMismatched = inputPromoCode != validPromoCode;

            Console.WriteLine("=== ACCESS & ELIGIBILITY REPORT ===\n");
            Console.WriteLine($"User Age: {userAge}");
            Console.WriteLine($"Is Legal Age: {isOfLegalAge}");
            Console.WriteLine($"Is Underage: {isUnderage}");

            Console.WriteLine($"\nAccount Balance: ${userAccountBalance:F2}");
            Console.WriteLine($"Can Afford Gold: {canAffordGold}");
            Console.WriteLine($"Has Cash Shortfall: {hasShortfall}");

            Console.WriteLine($"\nPromo Code Entered: {inputPromoCode}");
            Console.WriteLine($"Matches System Code: {isPromoCodeValid}");
            Console.WriteLine($"Is Incorrect Code: {isPromoCodeMismatched}");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
