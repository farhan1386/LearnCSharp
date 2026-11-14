using Phase_2_Intermediate.Week_3_Object_Oriented_Programming;
using System.Text;

namespace Phase_2_Intermediate.Week_3
{
    public class Program
    {
        private record TopicItem(Action RuntimeTask, string DisplayTitle, int DayNumber);

        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            var topicsRegistry = new TopicItem[]
            {
                new(Classe_and_Objects.Run, "Class & Objects", 1),
                new(Constructors.Run, "Constructors", 1),
                new(Access_Modifiers.Run, "Access Modifiers", 2),
                new(Properties.Run, "Properties", 2),
                new(Abstraction.Run, "Abstraction", 3),
                new(Encapsulation.Run, "Encapsulation", 3),
                new(Inheritance.Run, "Inheritance", 4),
                new(Polymorphism.Run, "Polymorphism", 4),
                new(Method_Overloading.Run, "Method Overloading", 5),
                new(Method_Overriding.Run, "Method Overriding", 5),
                new(Abstract_Class.Run, "Abstract Class", 6),
                new(Interface_Basic.Run, "Interface Basic", 6),
                new(Static_and_Synthesis.Run, "Static & Synthesis", 7),
                new(Structs_and_Enums.Run, "Structs & Enums", 7)
            };

            bool keepRunningWorkspace = true;

            while (keepRunningWorkspace)
            {
                Console.Clear();
                Console.WriteLine("==================================================================");
                Console.WriteLine("🚀 Phase 2 Intermediate: Week 3 Object-Oriented Programming (OOP)");
                Console.WriteLine("==================================================================");
                Console.WriteLine("Select a topic file to execute:\n");

                for (int i = 0; i < topicsRegistry.Length; i++)
                {
                    Console.WriteLine($" [{i + 1}] {topicsRegistry[i].DisplayTitle}");
                }

                Console.WriteLine("\n==================================================================");
                Console.WriteLine(" [0] Exit Application Workspace");
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