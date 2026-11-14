using System;
using System.Collections.Generic;
using System.Text;

namespace Phase_1_Basics.Week_2_Control_Statements_Parameter_Keywords
{
    public class out_parameter_keyword
    {
        public static void Run()
        {
            string systemMessage;

            bool isAccessGranted = TryAuthenticateUser("Farhan_Admin", "SecurePass123", out systemMessage);

            Console.WriteLine("=== SECURITY GATEWAY ===");
            Console.WriteLine($"Authentication Status: {isAccessGranted}");
            Console.WriteLine($"System Message:        {systemMessage}");

            Console.ReadLine();
        }

        static bool TryAuthenticateUser(string username, string password, out string statusMessage)
        {
            if (username == "Farhan_Admin" && password == "SecurePass123")
            {
                statusMessage = "Access authorized. Profile loaded successfully.";
                return true;
            }

            statusMessage = "Error: Invalid credentials or account locked.";
            return false;
        }
    }
}