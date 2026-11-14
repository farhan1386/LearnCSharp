using System;

namespace Phase_5_Design_Patterns.Week_6_Creational_Design_Patterns.Abstract_Factory_Violation
{
    public class Abstract_Factory_Violation
    {
        public static void Run()
        {
            string provider = "AWS";

            if (provider == "AWS")
            {
                Console.WriteLine("Creating AWS Compute Instance (EC2)...");
                Console.WriteLine("Creating AWS Storage Bucket (S3)...");
            }
            else if (provider == "Azure")
            {
                Console.WriteLine("Creating Azure Compute Instance (VM)...");
                Console.WriteLine("Creating Azure Storage Blob...");
            }
            else
            {
                throw new Exception("Unknown cloud infrastructure provider target configuration.");
            }
        }
    }
}