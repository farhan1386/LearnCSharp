using System;
using System.Collections.Generic;
using System.Text;

namespace Phase_3_Advanced.Week_4_Advanced_Data_Structures_Language_Features
{
    public class IEnumerable_Example
    {
        // Property holding the sequence of days
        public IEnumerable<DayOfWeek> DayOfWeeks { get; set; }

        // Constructor to initialize the property
        public IEnumerable_Example()
        {
            // An Array implements IEnumerable, making it a perfect fit
            DayOfWeeks = new DayOfWeek[]
            {
                DayOfWeek.Monday,
                DayOfWeek.Tuesday,
                DayOfWeek.Wednesday,
                DayOfWeek.Thursday,
                DayOfWeek.Friday,
                DayOfWeek.Saturday,
                DayOfWeek.Sunday
            };
        }

        public static void Run()
        {
            IEnumerable_Example example = new IEnumerable_Example();

            Console.WriteLine("Days of the week:");
            // You can loop through the IEnumerable using foreach
            foreach (var day in example.DayOfWeeks)
            {
                Console.WriteLine($"- {day}");
            }
        }
    }
}
