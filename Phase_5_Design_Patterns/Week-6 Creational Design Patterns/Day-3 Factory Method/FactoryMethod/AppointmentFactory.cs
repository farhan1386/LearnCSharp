using Phase_5_Design_Patterns.Week_6_Creational_Design_Patterns.FactoryMethod.Interfaces;
using Phase_5_Design_Patterns.Week_6_Creational_Design_Patterns.FactoryMethod.ConcreteProducts;

namespace Phase_5_Design_Patterns.Week_6_Creational_Design_Patterns.FactoryMethod
{
    public abstract class AppointmentFactory
    {
        public IAppointment ProcessAppointment()
        {
            // Deferring structural instantiation details to the derived child classes
            IAppointment appointment = CreateAppointment();
            return appointment;
        }

        // The polymorphic overridable Factory Method
        protected abstract IAppointment CreateAppointment();
    }

    public class CheckupAppointmentFactory : AppointmentFactory
    {
        protected override IAppointment CreateAppointment() => new CheckupAppointment();
    }

    public class OrthodonticAppointmentFactory : AppointmentFactory
    {
        protected override IAppointment CreateAppointment() => new OrthodonticAppointment();
    }

    public class RootCanalAppointmentFactory : AppointmentFactory
    {
        protected override IAppointment CreateAppointment() => new RootCanalAppointment();
    }
}
