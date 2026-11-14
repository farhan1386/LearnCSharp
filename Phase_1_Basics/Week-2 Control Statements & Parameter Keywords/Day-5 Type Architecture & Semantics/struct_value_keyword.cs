using System;
using System.Collections.Generic;
using System.Text;

namespace Phase_1_Basics.Week_2_Control_Statements_Parameter_Keywords
{
    public class struct_value_keyword
    {
        public static void Run()
        {
            GpsCoordinates deliveryLocation = new GpsCoordinates(27.04, 74.72);
            GpsCoordinates driverDestination = deliveryLocation;

            Console.WriteLine("=== INITIAL COORDINATES ===");
            Console.WriteLine($"Delivery Point: Latitude {deliveryLocation.Latitude}, Longitude {deliveryLocation.Longitude}");
            Console.WriteLine($"Driver Route  : Latitude {driverDestination.Latitude}, Longitude {driverDestination.Longitude}");

            driverDestination.Latitude = 26.91;

            Console.WriteLine("\n=== AFTER ROUTE UPDATE ===");
            Console.WriteLine($"Delivery Point: Latitude {deliveryLocation.Latitude}, Longitude {deliveryLocation.Longitude}");
            Console.WriteLine($"Driver Route  : Latitude {driverDestination.Latitude}, Longitude {driverDestination.Longitude}");

            Console.ReadLine();
        }

        public struct GpsCoordinates
        {
            public double Latitude { get; set; }
            public double Longitude { get; set; }

            public GpsCoordinates(double latitude, double longitude)
            {
                Latitude = latitude;
                Longitude = longitude;
            }
        }
    }
}
