using System;

namespace Phase_4_SOLID_Principles.Week_5_SOLID_Principles
{
    public class Pragmatism_Violation
    {
        public static void Run()
        {
            // ❌ Over-Engineering: Speculative Generality.
            // Creating complex abstraction hierarchies for simple, static parameters.
            IApplicationSettingsProvider settingsProvider = new StaticSettingsProvider();
            EnvironmentConfigManager configManager = new EnvironmentConfigManager(settingsProvider);
            configManager.DisplaySystemMetadata();
        }
    }

    // ❌ Over-Engineering: Speculative Generality.
    // Creating complex abstraction hierarchies for simple, static parameters.
    public interface IApplicationSettingsProvider
    {
        string GetVersionInfo();
    }

    public class StaticSettingsProvider : IApplicationSettingsProvider
    {
        public string GetVersionInfo() => "v1.0.0-Stable";
    }

    public class EnvironmentConfigManager
    {
        private readonly IApplicationSettingsProvider _provider;

        // Forced Dependency Injection boilerplates for code that never varies
        public EnvironmentConfigManager(IApplicationSettingsProvider provider)
        {
            _provider = provider;
        }

        public void DisplaySystemMetadata()
        {
            Console.WriteLine($"System Metadata Engine: {_provider.GetVersionInfo()}");
        }
    }
}