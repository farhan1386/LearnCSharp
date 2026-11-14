using System;
using System.Collections.Generic;
using System.Text;

namespace Phase_1_Basics.Week_1_Language_Basics_Fundamentals
{
    public class Assignment_Operators
    {
        public static void Run()
        {
            int playerScore = 500;
            int playerHealth = 100;
            double attackMultiplier = 1.0;
            int standardItemCount = 24;

            playerScore += 150;
            playerHealth -= 25;
            attackMultiplier *= 1.5;
            standardItemCount /= 2;

            Console.WriteLine("=== REAL-TIME COMBAT ENGINE LOG ===\n");
            Console.WriteLine($"Current Score: {playerScore}");
            Console.WriteLine($"Remaining Health: {playerHealth}%");
            Console.WriteLine($"Attack Modifier: {attackMultiplier:F1}x");
            Console.WriteLine($"Items Remaining: {standardItemCount}");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
