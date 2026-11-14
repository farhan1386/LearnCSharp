using System;
using System.Collections.Generic;
using System.Linq; 

namespace Phase_3_Advanced.Week_4_Advanced_Data_Structures_Language_Features
{
    public class Linq_Query_syntax
    {
        public static void Run()
        {
            Console.WriteLine("--- C# LINQ Query Syntax Demo ---\n");

            var students = new List<Student>
            {
                new Student { Name = "Alice", Score = 92, GradeLevel = "Senior" },
                new Student { Name = "Bob", Score = 78, GradeLevel = "Junior" },
                new Student { Name = "Charlie", Score = 85, GradeLevel = "Senior" },
                new Student { Name = "David", Score = 64, GradeLevel = "Junior" }
            };

            // 1. Core LINQ Query Syntax (Always starts with 'from', ends with 'select' or 'group')
            var honorRollSeniors = from s in students
                                   where s.Score >= 80 && s.GradeLevel == "Senior"
                                   orderby s.Score descending
                                   select s.Name;

            // 2. Printing the result expressions
            Console.WriteLine("Honor Roll Seniors:");
            foreach (var name in honorRollSeniors)
            {
                Console.WriteLine($" - {name}");
            }

            // 3. Transformation / Projection into an Anonymous Type
            var briefReport = from s in students
                              select new { s.Name, IsPassing = s.Score >= 70 };

            Console.WriteLine("\nStudent Status Briefing:");
            foreach (var summary in briefReport)
            {
                Console.WriteLine($"Student: {summary.Name} | Passing: {summary.IsPassing}");
            }
        }
    }

    public class Student
    {
        public string Name { get; set; } = string.Empty;
        public int Score { get; set; }
        public string GradeLevel { get; set; } = string.Empty;
    }
}