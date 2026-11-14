using System;
using System.Collections.Generic;
using System.Text;

namespace Phase_3_Advanced.Week_4_Advanced_Data_Structures_Language_Features
{
    public class Try_Catch_Finally
    {
        public static void Run()
        {
            try
            {
                // Code that may throw an exception
                int[] numbers = { 1, 2, 3 };
                Console.WriteLine(numbers[5]); // This will throw an IndexOutOfRangeException
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Execution completed.");
            }
        }
    }
}
