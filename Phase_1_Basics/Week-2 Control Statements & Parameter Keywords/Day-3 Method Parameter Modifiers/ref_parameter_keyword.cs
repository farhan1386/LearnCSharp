using System;
using System.Collections.Generic;
using System.Text;

namespace Phase_1_Basics.Week_2_Control_Statements_Parameter_Keywords
{
    public class ref_parameter_keyword
    {
        public static void Run()
        {
            int playerHealthPoints = 65;

            Console.WriteLine("=== RPG GAME SYSTEM ===");
            Console.WriteLine($"Starting HP: {playerHealthPoints}");

            ApplyHealingPotion(ref playerHealthPoints);

            Console.WriteLine($"Post-Potion HP: {playerHealthPoints}");

            Console.ReadLine();
        }

        static void ApplyHealingPotion(ref int currentHealth)
        {
            currentHealth += 35;

            if (currentHealth > 100)
            {
                currentHealth = 100;
            }
        }
    }
}