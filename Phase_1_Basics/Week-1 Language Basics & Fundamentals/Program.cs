using Phase_1_Basics.Week_1_Language_Basics_Fundamentals;
using System.Text;

namespace Phase_1_Basics.Week_1
{
    public class Program
    {
        private record TopicItem(Action RuntimeTask, string DisplayTitle, int DayNumber);

        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            var topicsRegistry = new TopicItem[]
            {
                new(VariablesAndDataTypes.Run, "Variables & Data Types", 1),
                new(Arithmetic_Operators.Run, "Arithmetic Operators", 2),
                new(Relational_Operators.Run, "Relational Operators", 2),
                new(Assignment_Operators.Run, "Assignment Operators", 3),
                new(Logical_Operators.Run, "Logical Operators", 3),
                new(Bitwise_Operators.Run, "Bitwise Operators", 4),
                new(Increment_Decrement_Operators.Run, "Increment & Decrement Operators", 4),
                new(Null_Coalescing_Operator.Run, "Null-Coalescing Operator", 5),
                new(Ternary_Operator.Run, "Ternary Operator", 5),
                new(if_statement.Run, "If Statement", 6),
                new(if_else_statement.Run, "If-Else Statement", 6),
                new(If_Else_If_Ladder_Statement.Run, "If-Else-If Ladder Statement", 6),
                new(Nested_Switch_Statement.Run, "Nested Switch Statement", 6),
                new(Nested_If_Statement.Run, "Nested-If Statement", 6),
                new(switch_statement.Run, "Switch Statement", 6),
                new(do_while_loop.Run, "Do-While Loop", 7),
                new(for_each_loop.Run, "For-Each Loop", 7),
                new(for_loop.Run, "For Loop", 7),
                new(nested_loops.Run, "Nested Loops", 7),
                new(while_loop.Run, "While Loop", 7)
            };

            bool keepRunningWorkspace = true;

            while (keepRunningWorkspace)
            {
                Console.Clear();
                Console.WriteLine("==================================================================");
                Console.WriteLine("🚀 Phase 1 Basics: Week 1 Language Basics & Fundamentals");
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