using System;

namespace Phase_4_SOLID_Principles.Week_5_SOLID_Principles
{
    public class Pragmatism_Solution
    {
        public static void Run()
        {
            var logger = new SystemMetadataLogger();
            logger.DisplaySystemMetadata();
        }
    }

    public static class ApplicationSettings
    {
        public const string Version = "v1.0.0-Stable";
    }

    public class SystemMetadataLogger
    {
        public void DisplaySystemMetadata()
        {
            Console.WriteLine($"System Metadata Engine: {ApplicationSettings.Version}");
        }
    }
}