using Phase_5_Design_Patterns.Week_5_Creational_Design_Patterns.Abstract_Factory.Interfaces;

namespace Phase_5_Design_Patterns.Week_5_Creational_Design_Patterns.AbstractFactory
{
    public class CloudDeploymentOrchestrator
    {
        private readonly IComputeInstance _server;
        private readonly IStorageBucket _storage;

        // Client relies completely on abstract interface definitions, guaranteeing vendor environment safety
        public CloudDeploymentOrchestrator(ICloudResourceFactory cloudFactory)
        {
            _server = cloudFactory.CreateComputeInstance();
            _storage = cloudFactory.CreateStorageBucket();
        }

        public void DeployStack()
        {
            _server.Provision();
            _storage.Allocate();
        }
    }
}
