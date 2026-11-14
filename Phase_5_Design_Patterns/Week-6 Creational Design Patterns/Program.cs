using Phase_5_Design_Patterns.Week_6_Creational_Design_Patterns.Abstract_Factory;
using Phase_5_Design_Patterns.Week_6_Creational_Design_Patterns.Abstract_Factory_Violation;
using Phase_5_Design_Patterns.Week_6_Creational_Design_Patterns.Builder;
using Phase_5_Design_Patterns.Week_6_Creational_Design_Patterns.Builder_Pattern_Voilation;
using Phase_5_Design_Patterns.Week_6_Creational_Design_Patterns.Factory_Method;
using Phase_5_Design_Patterns.Week_6_Creational_Design_Patterns.Factory_Method_Voilation;
using Phase_5_Design_Patterns.Week_6_Creational_Design_Patterns.Simple_Factory;
using Phase_5_Design_Patterns.Week_6_Creational_Design_Patterns.Simple_Factory_Violation;
using Phase_5_Design_Patterns.Week_6_Creational_Design_Patterns.Singleton_Pattern;
using Phase_5_Design_Patterns.Week_6_Creational_Design_Patterns.Singleton_Violation;
using System.Text;

namespace Phase_5_Design_Patterns.Week_6
{
    public class Program
    {
        private record TopicItem(Action RuntimeTask, string DisplayTitle, int DayNumber);

        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            var topicsRegistry = new TopicItem[]
            {
                new(Singleton_Pattern.Run, "Singleton Pattern", 1),
                new(Singleton_Violation.Run, "Singleton Violation", 1),
                new(Simple_Factory.Run, "Simple Factory", 2),
                new(Simple_Factory_Violation.Run, "Simple Factory Violation", 2),
                new(Factory_Method.Run, "Factory Method", 3),
                new(Factory_Method_Voilation.Run, "Factory Method Violation", 3),
                new(Abstract_Factory.Run, "Abstract Factory", 4),
                new(Abstract_Factory_Violation.Run, "Abstract Factory Violation", 4),
                new(Builder_Pattern.Run, "Builder Pattern", 5),
                new(Builder_Pattern_Voilation.Run, "Builder Pattern Violation", 5)
            };

            bool keepRunningWorkspace = true;

            while (keepRunningWorkspace)
            {
                Console.Clear();
                Console.WriteLine("==================================================================");
                Console.WriteLine("🚀 Phase 5 Design Patterns: Week-6 Creational Design Patterns");
                Console.WriteLine("==================================================================");
                Console.WriteLine("Select a topic file to execute:\n");

                for (int i = 0; i < topicsRegistry.Length; i++)
                {
                    Console.WriteLine($" [{i + 1}] {topicsRegistry[i].DisplayTitle}");
                }

                Console.WriteLine("\n==================================================================");
                Console.WriteLine(" Exit Application Workspace");
                Console.WriteLine("==================================================================");

                Console.Write($"\nEnter choice entry index (0-{topicsRegistry.Length}): ");
                string? choiceInput = Console.ReadLine();

                if (!int.TryParse(choiceInput, out int targetSelection) || targetSelection < 0 || targetSelection > topicsRegistry.Length)
                {
                    Console.WriteLine("\n[Selection Warning]: Invalid selection constraints.");
                    PromptToContinue(ref keepRunningWorkspace);
                    continue;
                }

                if (targetSelection == 0)
                {
                    Console.WriteLine("\nReleasing active workspace console session. Goodbye!");
                    break;
                }

                Console.Clear();
                int arrayIndex = targetSelection - 1;
                var selectedTopic = topicsRegistry[arrayIndex];

                Console.WriteLine("==================================================================");
                Console.WriteLine($"⚙️ Running -> {selectedTopic.DisplayTitle}");
                Console.WriteLine("==================================================================");
                Console.WriteLine($"Day-{selectedTopic.DayNumber} {selectedTopic.DisplayTitle}:\n");

                try
                {
                    selectedTopic.RuntimeTask();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"\n[Runtime Pipeline Halt Failure]: {ex.Message}");
                }

                PromptToContinue(ref keepRunningWorkspace);
            }
        }

        private static void PromptToContinue(ref bool keepRunningWorkspace)
        {
            Console.WriteLine("\n--------------------------------------------------");
            Console.Write("Execution complete. Do you want to continue? (Y/N): ");
            string? input = Console.ReadLine()?.Trim();

            if (!string.Equals(input, "Y", StringComparison.OrdinalIgnoreCase) &&
                !string.Equals(input, "YES", StringComparison.OrdinalIgnoreCase))
            {
                keepRunningWorkspace = false;
                Console.WriteLine("\nReleasing active workspace console session. Goodbye!");
            }
        }
    }
}