using System;
using System.Collections.Generic;
using System.Text;

namespace Phase_1_Basics.Week_2_Control_Statements_Parameter_Keywords
{
    public class in_parameter_keyword
    {
        public static void Run()
        {
            Vector3D cameraPosition = new Vector3D(10.5, 20.0, -5.3);

            Console.WriteLine("=== GRAPHICS RENDER PIPELINE ===");
            Console.WriteLine($"Original Coordinates: X={cameraPosition.X}, Y={cameraPosition.Y}, Z={cameraPosition.Z}");

            RenderObject(in cameraPosition);

            Console.ReadLine();
        }

        static void RenderObject(in Vector3D position)
        {
            Console.WriteLine($"\nRendering frame using read-only reference matrix located at: X={position.X}, Y={position.Y}, Z={position.Z}");
        }

        public struct Vector3D
        {
            public double X { get; set; }
            public double Y { get; set; }
            public double Z { get; set; }

            public Vector3D(double x, double y, double z)
            {
                X = x;
                Y = y;
                Z = z;
            }
        }
    }
}