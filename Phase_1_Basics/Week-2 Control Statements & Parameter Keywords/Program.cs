using Phase_1_Basics.Week_2_Control_Statements_Parameter_Keywords;
using System.Text;

namespace Phase_1_Basics.Week_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Action[] taskRegistry = new Action[]
            {
                Break_statement.Run,
                Continue_Statement.Run,
                Goto_Statement.Run,
                Return_Statement.Run,
                Throw_Statement.Run,
                in_parameter_keyword.Run,
                out_parameter_keyword.Run,
                ref_parameter_keyword.Run,
                const_modifier_keyword.Run,
                readonly_modifier_keyword.Run,
                class_reference_keyword.Run,
                record_semantic_keyword.Run,
                struct_value_keyword.Run,
                override_modifier_keyword.Run,
                virtual_modifier_keyword.Run,
                abstract_keyword.Run,
                interface_keyword.Run
            };

            string[] dayHeadings = new string[]
            {
                "Day 1: Control Flow Modifiers",
                "Day 1: Control Flow Modifiers",
                "Day 2: Jump & Exception Keywords",
                "Day 2: Jump & Exception Keywords",
                "Day 2: Jump & Exception Keywords",
                "Day 3: Method Parameter Modifiers",
                "Day 3: Method Parameter Modifiers",
                "Day 3: Method Parameter Modifiers",
                "Day 4: Value Mutability Constraints",
                "Day 4: Value Mutability Constraints",
                "Day 5: Type Architecture & Semantics",
                "Day 5: Type Architecture & Semantics",
                "Day 5: Type Architecture & Semantics",
                "Day 6: Polymorphism Core Keywords",
                "Day 6: Polymorphism Core Keywords",
                "Day 7: Advanced Abstraction Contracts",
                "Day 7: Advanced Abstraction Contracts"
            };

            bool keepRunningWorkspace = true;

            while (keepRunningWorkspace)
            {
                Console.Clear();
                Console.WriteLine("==================================================================");
                Console.WriteLine($"🚀 Phase 1 Basics: Week 2 Control Statements & Parameter Keywords");
                Console.WriteLine("==================================================================");
                Console.WriteLine("Select a topic file to execute:");

                Console.WriteLine("\n--- Day 1 ---");
                Console.WriteLine(" [1] Break Statement");
                Console.WriteLine(" [2] Continue Statement");

                Console.WriteLine("\n--- Day 2 ---");
                Console.WriteLine(" [3] Goto Statement");
                Console.WriteLine(" [4] Return Statement");
                Console.WriteLine(" [5] Throw Statement");

                Console.WriteLine("\n--- Day 3 ---");
                Console.WriteLine(" [6] In Parameter Keyword");
                Console.WriteLine(" [7] Out Parameter Keyword");
                Console.WriteLine(" [8] Ref Parameter Keyword");

                Console.WriteLine("\n--- Day 4 ---");
                Console.WriteLine(" [9] Const Modifier Keyword");
                Console.WriteLine(" [10] Readonly Modifier Keyword");

                Console.WriteLine("\n--- Day 5 ---");
                Console.WriteLine(" [11] Class Reference Keyword");
                Console.WriteLine(" [12] Record Semantic Keyword");
                Console.WriteLine(" [13] Struct Value Keyword");

                Console.WriteLine("\n--- Day 6 ---");
                Console.WriteLine(" [14] Override Modifier Keyword");
                Console.WriteLine(" [15] Virtual Modifier Keyword");

                Console.WriteLine("\n--- Day 7 ---");
                Console.WriteLine(" [16] Abstract Keyword");
                Console.WriteLine(" [17] Interface Keyword");

                Console.WriteLine("\n==================================================================");
                Console.WriteLine(" [0] Exit Application Workspace");
                Console.WriteLine("==================================================================");

                Console.Write("\nEnter choice entry index (0-17): ");
                string? choiceInput = Console.ReadLine();

                if (!int.TryParse(choiceInput, out int targetSelection) || targetSelection < 0 || targetSelection > 17)
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
                string dayHeading = dayHeadings[arrayIndex];

                Console.WriteLine("==================================================================");
                Console.WriteLine($"⚙️ Running -> {dayHeading}");
                Console.WriteLine("==================================================================");

                try
                {
                    taskRegistry[arrayIndex]();
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
            string? input = Console.ReadLine()?.Trim().ToUpper();

            if (input != "Y" && input != "YES")
            {
                keepRunningWorkspace = false;
                Console.WriteLine("\nReleasing active workspace console session. Goodbye!");
            }
        }
    }
}