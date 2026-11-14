using Phase_3_Advanced.Week_4_Advanced_Data_Structures_Language_Features;
using System.Text;

namespace Phase_3_Advanced.Week_4
{
    public class Program
    {
        private record TopicItem(Action RuntimeTask, string DisplayTitle, int DayNumber);

        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            var topicsRegistry = new TopicItem[]
            {
                new(Null_Handling_Operators.Run, "Null Handling Operators", 1),
                new(String_Builder.Run, "String Builder", 1),
                new(Dictionary_Collection.Run, "Dictionary Collection", 2),
                new(ICollection_Example.Run, "ICollection Example", 2),
                new(IEnumerable_Example.Run, "IEnumerable Example", 2),
                new(IList_Example.Run, "IList Example", 2),
                new(IQueryable_Example.Run, "IQueryable Example", 2),
                new(List_Collection.Run, "List Collection", 2),
                new(Generics_Basics.Run, "Generics Basics", 3),
                new(Queue_and_Stack.Run, "Queue and Stack", 3),
                new(Custom_Exceptions.Run, "Custom Exceptions", 4),
                new(Try_Catch_Finally.Run, "Try Catch Finally", 4),
                new(Delegates_Basics.Run, "Delegates Basics", 5),
                new(Lambda_Expressions.Run, "Lambda Expressions", 5),
                new(Linq_Method_syntax.Run, "Linq Method syntax", 6),
                new(Linq_Query_syntax.Run, "Linq Query syntax", 6),
                new(code_refactoring.Run, "Code Refactoring", 7),
                new(inventory_management_app.Run, "Inventory Management App", 7)
            };

            bool keepRunningWorkspace = true;

            while (keepRunningWorkspace)
            {
                Console.Clear();
                Console.WriteLine("==================================================================");
                Console.WriteLine("🚀 Phase 3 Advanced: Week 4 Advanced Data Structures & Language Features");
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