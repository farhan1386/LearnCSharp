using System;
using System.Text;

namespace Phase_3_Advanced.Week_4_Advanced_Data_Structures_Language_Features
{
    public class String_Builder
    {
        public static void Run()
        {
            string[] logData = { "2026-09-22", "ERROR", "DB_Timeout", "Connection string failed" };

            // Efficiently build a single comma-separated line
            StringBuilder csvLine = new StringBuilder();

            for (int i = 0; i < logData.Length; i++)
            {
                csvLine.Append('"').Append(logData[i]).Append('"');

                if (i < logData.Length - 1)
                    csvLine.Append(",");
            }

            // Convert to string for file writing or console output
            Console.WriteLine(csvLine.ToString());
            // Outputs: "2026-09-22","ERROR","DB_Timeout","Connection string failed"

            Console.ReadLine();
        }
    }
}