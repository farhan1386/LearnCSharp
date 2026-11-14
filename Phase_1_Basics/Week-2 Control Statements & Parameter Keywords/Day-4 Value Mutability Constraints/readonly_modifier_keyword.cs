using System;
using System.Collections.Generic;
using System.Text;

namespace Phase_1_Basics.Week_2_Control_Statements_Parameter_Keywords
{
    public class readonly_modifier_keyword
    {
        public static void Run()
        {
            DatabaseConfig productionDb = new DatabaseConfig("Server=ProdServer01;Database=InventoryDb;");

            Console.WriteLine("=== SYSTEM INITIALIZATION ===");
            Console.WriteLine($"Active Connection String: {productionDb.ConnectionString}");

            Console.ReadLine();
        }
    }

    public class DatabaseConfig
    {
        public readonly string ConnectionString;

        public DatabaseConfig(string connectionString)
        {
            ConnectionString = connectionString;
        }
    }
}