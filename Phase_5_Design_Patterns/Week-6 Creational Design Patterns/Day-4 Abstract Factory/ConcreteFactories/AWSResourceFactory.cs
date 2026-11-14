using Phase_5_Design_Patterns.Week_5_Creational_Design_Patterns.Abstract_Factory.ConcreteProducts;
using Phase_5_Design_Patterns.Week_5_Creational_Design_Patterns.Abstract_Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Phase_5_Design_Patterns.Week_5_Creational_Design_Patterns.Abstract_Factory.ConcreteFactories
{
    public class AWSResourceFactory : ICloudResourceFactory
    {
        public IComputeInstance CreateComputeInstance()
        {
            return new Ec2ComputeInstance();
        }

        public IStorageBucket CreateStorageBucket()
        {
            return new S3StorageBucket();
        }
    }
}
