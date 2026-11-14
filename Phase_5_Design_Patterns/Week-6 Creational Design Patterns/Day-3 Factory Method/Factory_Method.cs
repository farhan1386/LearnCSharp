using Phase_5_Design_Patterns.Week_6_Creational_Design_Patterns.FactoryMethod;
using Phase_5_Design_Patterns.Week_6_Creational_Design_Patterns.FactoryMethod.Interfaces;

namespace Phase_5_Design_Patterns.Week_6_Creational_Design_Patterns.Factory_Method
{
    public static class Factory_Method
    {
        public static void Run()
        {
            AppointmentFactory factory;
            IAppointment appointment;

            Console.WriteLine("--- Initializing GoF Factory Method Execution Loops ---");

            // 1. Process Routine Checkup using its dedicated sub-factory
            factory = new CheckupAppointmentFactory();
            appointment = factory.ProcessAppointment();
            appointment.prepareRoom();
            Console.WriteLine($"Checkup cost: ${appointment.calculateCost():F2}\n");

            // 2. Process Root Canal using its dedicated sub-factory
            factory = new RootCanalAppointmentFactory();
            appointment = factory.ProcessAppointment();
            appointment.prepareRoom();
            Console.WriteLine($"Root Canal cost: ${appointment.calculateCost():F2}\n");

            // 3. Process Orthodontic Treatment using its dedicated sub-factory
            factory = new OrthodonticAppointmentFactory();
            appointment = factory.ProcessAppointment();
            appointment.prepareRoom();
            Console.WriteLine($"Orthodontic cost: ${appointment.calculateCost():F2}\n");

            Console.ReadLine();
        }
    }
}