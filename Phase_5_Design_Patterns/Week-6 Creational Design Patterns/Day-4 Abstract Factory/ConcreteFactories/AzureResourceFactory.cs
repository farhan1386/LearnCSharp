using Phase_5_Design_Patterns.Week_5_Creational_Design_Patterns.Abstract_Factory.ConcreteProducts;
using Phase_5_Design_Patterns.Week_5_Creational_Design_Patterns.Abstract_Factory.Interfaces;

namespace Phase_5_Design_Patterns.Week_5_Creational_Design_Patterns.Abstract_Factory.ConcreteFactories
{
    public class AzureResourceFactory : ICloudResourceFactory
    {
        public IComputeInstance CreateComputeInstance()
        {
            return new VmComputeInstance();
        }

        public IStorageBucket CreateStorageBucket()
        {
            return new BlobStorageBucket();
        }
    }
}
