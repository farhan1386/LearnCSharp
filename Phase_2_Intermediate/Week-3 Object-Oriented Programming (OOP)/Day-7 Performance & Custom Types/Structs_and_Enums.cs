using System;

namespace Phase_2_Intermediate.Week_3_Object_Oriented_Programming
{
    public class Structs_and_Enums
    {
        public static void Run()
        {
            // 1. Working with Enums
            TreatmentCategory selectedTreatment = TreatmentCategory.RootCanal;

            // 2. Working with Structs (Value Type allocation on Stack)
            AppointmentTimeSlot slot = new AppointmentTimeSlot(14, 30); // 2:30 PM

            Console.WriteLine("--- Dental Clinic Scheduling Desk ---");
            Console.WriteLine($"Selected Procedure: {selectedTreatment} (System ID: {(int)selectedTreatment})");
            Console.WriteLine($"Scheduled Time Slot: {slot.GetFormattedTime()}");

            // 3. Demonstrating Value-Type Behavior (Copying vs Referencing)
            AppointmentTimeSlot backupSlot = slot; // Copies the actual data value, not a memory pointer reference
            backupSlot = new AppointmentTimeSlot(15, 00); // Modifying backup doesn't affect original slot

            Console.WriteLine($"\nOriginal Slot intact: {slot.GetFormattedTime()}");
            Console.WriteLine($"Rescheduled Backup Slot: {backupSlot.GetFormattedTime()}");

            Console.ReadLine();
        }
    }

    // ENUM DEFINITION: Defines fixed categories for dental treatments
    public enum TreatmentCategory
    {
        Checkup,     // Automatically assigned 0
        Cleaning,    // Automatically assigned 1
        RootCanal,   // Automatically assigned 2
        Extraction   // Automatically assigned 3
    }

    // STRUCT DEFINITION: A lightweight, value-type container for coordinates or dimensions
    // Perfect for small data structures that don't need inheritance
    public struct AppointmentTimeSlot
    {
        public int Hour { get; }
        public int Minute { get; }

        // Struct constructor (Must initialize all fields/properties)
        public AppointmentTimeSlot(int hour, int minute)
        {
            Hour = hour;
            Minute = minute;
        }

        public string GetFormattedTime()
        {
            return $"{Hour:D2}:{Minute:D2}";
        }
    }   
}