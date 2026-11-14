using Phase_4_SOLID_Principles.Week_5_SOLID_Principles;
using System.Text;

namespace Phase_4_SOLID_Principles.Week_5
{
    public class Program
    {
        private record TopicItem(Action RuntimeTask, string DisplayTitle, int DayNumber);

        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            var topicsRegistry = new TopicItem[]
            {
                new(SRP_Solution.Run, "SRP Solution", 1),
                new(SRP_Violation.Run, "SRP Violation", 1),
                new(OCP_Solution.Run, "OCP Solution", 2),
                new(OCP_Violation.Run, "OCP Violation", 2),
                new(LSP_Solution.Run, "LSP Solution", 3),
                new(LSP_Violation.Run, "LSP Violation", 3),
                new(ISP_Solution.Run, "ISP Solution", 4),
                new(ISP_Violation.Run, "ISP Violation", 4),
                new(DIP_Solution.Run, "DIP Solution", 5),
                new(DIP_Violation.Run, "DIP Violation", 5),
                new(Diagnostics_Solution.Run, "Diagnostics Solution", 6),
                new(Diagnostics_Violation.Run, "Diagnostics Violation", 6),
                new(Pragmatism_Solution.Run, "Pragmatism Solution", 7),
                new(Pragmatism_Violation.Run, "Pragmatism Violation", 7)
            };

            bool keepRunningWorkspace = true;

            while (keepRunningWorkspace)
            {
                Console.Clear();
                Console.WriteLine("==================================================================");
                Console.WriteLine("🚀 Phase 4 SOLID Principles: Week 5 SOLID Principles & Architecture");
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