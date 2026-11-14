using System;

namespace Phase_5_Design_Patterns.Week_6_Creational_Design_Patterns.Singleton_Violation
{
    public class Singleton_Violation
    {
        public static void Run()
        {
            LoadBalancer b1 = new LoadBalancer();
            LoadBalancer b2 = new LoadBalancer();
            LoadBalancer b3 = new LoadBalancer();
            LoadBalancer b4 = new LoadBalancer();

            if (b1 != b2 || b2 != b3 || b3 != b4)
            {
                Console.WriteLine("Violation Detected: Multiple distinct instances created in memory!\n");
            }

            for (int i = 0; i < 15; i++)
            {
                LoadBalancer instantBalancer = new LoadBalancer();
                string server = instantBalancer.Server;
                Console.WriteLine($"Dispatch Request to: {server} (Using short-lived instance)");
            }
        }
    }

    public class LoadBalancer
    {
        private readonly List<string> _servers = new();
        private readonly Random _random = new();

        public LoadBalancer()
        {
            _servers.Add("ServerI");
            _servers.Add("ServerII");
            _servers.Add("ServerIII");
            _servers.Add("ServerIV");
            _servers.Add("ServerV");
        }

        public string Server
        {
            get
            {
                int r = _random.Next(_servers.Count);
                return _servers[r];
            }
        }
    }
}