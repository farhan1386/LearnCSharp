using System;
using System.Collections.Generic;
using System.Text;

namespace Phase_1_Basics.Week_2_Control_Statements_Parameter_Keywords
{
    public class interface_keyword
    {
        public static void Run()
        {
            List<ILogger> loggers = new List<ILogger>
            {
                new ConsoleLogger(),
                new FileLogger()
            };

            foreach (var logger in loggers)
            {
                logger.Log("Application started successfully.");
            }

            Console.ReadLine();
        }
    }

    public interface ILogger
    {
        void Log(string message);
    }

    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"[Console Log]: {message}");
        }
    }

    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"[File Log]: Writing '{message}' to text file.");
        }
    }
}