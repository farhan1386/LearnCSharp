using Phase_5_Design_Patterns.Week_5_Creational_Design_Patterns.Abstract_Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Phase_5_Design_Patterns.Week_5_Creational_Design_Patterns.Abstract_Factory.ConcreteProducts
{
    public class Ec2ComputeInstance : IComputeInstance
    {
        public void Provision() => Console.WriteLine("[Compute] AWS EC2 Elastic Compute Instance provisioned successfully.");
    }

    public class S3StorageBucket : IStorageBucket
    {
        public void Allocate() => Console.WriteLine("[Storage] AWS S3 Secure Object Storage Bucket allocated.");
    }
}
