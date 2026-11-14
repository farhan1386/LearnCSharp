using System;
using System.Collections.Generic;
using System.Text;

namespace Phase_1_Basics.Week_2_Control_Statements_Parameter_Keywords
{
    public class virtual_modifier_keyword
    {
        public static void Run()
        {
            List<Character> party = new List<Character>
            {
                new Warrior(),
                new Mage()
            };

            foreach (var hero in party)
            {
                hero.Attack();
            }

            Console.ReadLine();
        }
    }

    public class Character
    {
        public virtual void Attack()
        {
            Console.WriteLine("The character performs a basic attack.");
        }
    }

    public class Warrior : Character
    {
        public override void Attack()
        {
            Console.WriteLine("Warrior swings a massive greatsword for heavy damage!");
        }
    }

    public class Mage : Character
    {
        public override void Attack()
        {
            Console.WriteLine("Mage casts a brilliant fireball spell from afar!");
        }
    }
}
