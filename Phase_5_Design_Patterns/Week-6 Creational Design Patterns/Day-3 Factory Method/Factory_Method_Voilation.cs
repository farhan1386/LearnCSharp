using System;
using System.Collections.Generic;
using System.Text;

namespace Phase_5_Design_Patterns.Week_6_Creational_Design_Patterns.Factory_Method_Voilation
{
    /// <summary>
    /// ANTI-PATTERN: Tight Instantiation.
    /// Hardcoding instantiation directly across client pathways. Adding new scheduling 
    /// pipelines (like "RootCanal") forces you to modify this core class, 
    /// breaking existing closed configurations and violating the Open-Closed Principle (OCP).
    /// </summary>
    public class Factory_Method_Voilation
    {
        public static void Run()
        {
            var scheduler = new Factory_Method_Voilation();
            scheduler.BookClinicSession("Checkup", "John Doe", "10:00 AM");
            scheduler.BookClinicSession("Orthodontic", "Jane Smith", "11:00 AM");
            scheduler.BookClinicSession("RootCanal", "Alice Johnson", "1:00 PM");
        }


        public void BookClinicSession(string appointmentType, string patientName, string timeSlot)
        {
            // Direct object coupling prevents clean architectural extensions
            if (appointmentType.Equals("Checkup", StringComparison.OrdinalIgnoreCase))
            {
                var checkup = new LocalCheckupAppointment();
                checkup.Schedule(patientName, timeSlot);
            }
            else if (appointmentType.Equals("Orthodontic", StringComparison.OrdinalIgnoreCase))
            {
                var ortho = new LocalOrthodonticAppointment();
                ortho.Schedule(patientName, timeSlot);
            }
            // ❌ VIOLATION: Incorporating RootCanal forces structural modifications to this code file
            else if (appointmentType.Equals("RootCanal", StringComparison.OrdinalIgnoreCase))
            {
                var canal = new LocalRootCanalAppointment();
                canal.Schedule(patientName, timeSlot);
            }
            else
            {
                throw new ArgumentException("Unsupported clinic session profile.");
            }
        }
    }

    public class LocalCheckupAppointment { public void Schedule(string p, string t) => Console.WriteLine($"Checkup booked for {p} at {t}"); }
    public class LocalOrthodonticAppointment { public void Schedule(string p, string t) => Console.WriteLine($"Ortho booked for {p} at {t}"); }
    public class LocalRootCanalAppointment { public void Schedule(string p, string t) => Console.WriteLine($"Root Canal booked for {p} at {t}"); }
}