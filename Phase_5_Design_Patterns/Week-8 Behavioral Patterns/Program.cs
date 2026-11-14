using System.Text;
using Phase_5_Design_Patterns.Week_8_Behavioral_Design_Patterns.Observer_Pattern;
using Phase_5_Design_Patterns.Week_8_Behavioral_Design_Patterns.Observer_Pattern_Voilation;
using Phase_5_Design_Patterns.Week_8_Behavioral_Design_Patterns.Strategy_Pattern;
using Phase_5_Design_Patterns.Week_8_Behavioral_Design_Patterns.Strategy_Pattern_Violation;

namespace Phase_5_Design_Patterns.Week_8
{
    public class Program
    {
        private record TopicItem(Action RuntimeTask, string DisplayTitle, int DayNumber);

        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            var topicsRegistry = new TopicItem[]
            {
                new(Observer_Pattern.Run, "Observer Pattern", 1),
                new(Observer_Pattern_Voilation.Run, "Observer Pattern Violation", 1),
                new(Strategy_Pattern.Run, "Strategy Pattern", 2),
                new(Strategy_Pattern_Violation.Run, "Strategy Pattern Violation", 2),

            };

            bool keepRunningWorkspace = true;

            while (keepRunningWorkspace)
            {
                Console.Clear();
                Console.WriteLine("==================================================================");
                Console.WriteLine("🚀 Phase 5 Design Patterns: Week-8 Behavioral Design Patterns");
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