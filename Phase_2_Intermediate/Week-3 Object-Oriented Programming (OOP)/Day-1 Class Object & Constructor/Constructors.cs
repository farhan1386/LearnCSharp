using System;

namespace Phase_2_Intermediate.Week_3_Object_Oriented_Programming
{
    public class Constructors
    {
        public static void Run()
        {
            var defaultServer = new CloudServer();
            var productionServer = new CloudServer("PROD-DB-01", "10.0.0.4");
            var backupServer = new CloudServer(productionServer);

            CloudUtility.LogSystemStatus();

            Console.WriteLine($"\nDefault Machine: {defaultServer.ServerName} ({defaultServer.IpAddress})");
            Console.WriteLine($"Active Production: {productionServer.ServerName} ({productionServer.IpAddress})");
            Console.WriteLine($"Redundant Backup : {backupServer.ServerName} ({backupServer.IpAddress})");

            Console.ReadLine();
        }
    }

    public class CloudServer
    {
        public string ServerName { get; set; }
        public string IpAddress { get; set; }

        static CloudServer()
        {
            Console.WriteLine("[Type 1: Static Constructor] Cloud runtime configuration loaded mapping virtual switches.");
        }

        public CloudServer()
        {
            ServerName = "SANDBOX-VM";
            IpAddress = "127.0.0.1";
            Console.WriteLine("[Type 2: Default Constructor] Provisioned basic local sandbox instance.");
        }

        public CloudServer(string serverName, string ipAddress)
        {
            ServerName = serverName;
            IpAddress = ipAddress;
            Console.WriteLine($"[Type 3: Parameterized Constructor] Provisioned physical nodegroup node: {ServerName}.");
        }

        public CloudServer(CloudServer sourceServer)
        {
            ServerName = $"{sourceServer.ServerName}-REPLICA";
            IpAddress = sourceServer.IpAddress;
            Console.WriteLine($"[Type 4: Copy Constructor] Cloned configuration cluster link from: {sourceServer.ServerName}.");
        }
    }

    public class CloudUtility
    {
        private CloudUtility() { }

        public static void LogSystemStatus()
        {
            Console.WriteLine("[Type 5: Private Constructor] Telemetry packet transmitted via static utility methods.");
        }
    }
}