using Phase_5_Design_Patterns.Week_5_Creational_Design_Patterns.Abstract_Factory.ConcreteFactories;
using Phase_5_Design_Patterns.Week_5_Creational_Design_Patterns.Abstract_Factory.Interfaces;
using Phase_5_Design_Patterns.Week_5_Creational_Design_Patterns.AbstractFactory;

namespace Phase_5_Design_Patterns.Week_6_Creational_Design_Patterns.Abstract_Factory
{
    public static class Abstract_Factory
    {
        public static void Run()
        {
            ICloudResourceFactory factory;
            CloudDeploymentOrchestrator orchestrator;

            Console.WriteLine("--- Initializing Automated Cloud Environment Provisioning Engine ---");

            // 1. Build and configure an AWS environment stack using its concrete vendor family factory
            Console.WriteLine("\n[Orchestration] Loading Amazon Web Services (AWS) Target Profiles:");
            factory = new AWSResourceFactory();
            orchestrator = new CloudDeploymentOrchestrator(factory);
            orchestrator.DeployStack();

            // 2. Build and configure an Azure environment stack using its concrete vendor family factory
            Console.WriteLine("\n[Orchestration] Loading Microsoft Azure Target Profiles:");
            factory = new AzureResourceFactory();
            orchestrator = new CloudDeploymentOrchestrator(factory);
            orchestrator.DeployStack();

            Console.ReadLine();
        }
    }
}
