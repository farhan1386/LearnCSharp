using Phase_5_Design_Patterns.Week_5_Creational_Design_Patterns.Abstract_Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Phase_5_Design_Patterns.Week_5_Creational_Design_Patterns.Abstract_Factory.ConcreteProducts
{
    public class VmComputeInstance : IComputeInstance
    {
        public void Provision() => Console.WriteLine("[Compute] Azure Enterprise Virtual Machine scale set provisioned.");
    }

    public class BlobStorageBucket : IStorageBucket
    {
        public void Allocate() => Console.WriteLine("[Storage] Azure Blob Binary Object Storage Container allocated.");
    }
}
