using System;

namespace Phase_2_Intermediate.Week_3_Object_Oriented_Programming
{
    public class Classe_and_Objects
    {
        public static void Run()
        {
            var serverAsset = new HardwareAsset()
            {
                AssetTag = "SRV-LN-992",
                ModelName = "Enterprise Rack Mount Pro",
                MonthlyMaintenanceCost = 249.50
            };

            Console.WriteLine("=== ENTERPRISE INFRASTRUCTURE REGISTRY ===");
            Console.WriteLine($"Asset Reference : {serverAsset.AssetTag}");
            Console.WriteLine($"Model Inventory : {serverAsset.ModelName}");
            Console.WriteLine($"Operating cost  : ${serverAsset.MonthlyMaintenanceCost:F2}/mo");

            serverAsset.AllocateToCluster();

            Console.ReadLine();
        }
    }

    public class HardwareAsset
    {
        public string AssetTag { get; set; } = string.Empty;
        public string ModelName { get; set; } = string.Empty;
        public double MonthlyMaintenanceCost { get; set; }

        public void AllocateToCluster()
        {
            Console.WriteLine($"[System Pipeline] Provisioning allocation nodes for node cluster sequence: {AssetTag}.");
        }
    }
}
