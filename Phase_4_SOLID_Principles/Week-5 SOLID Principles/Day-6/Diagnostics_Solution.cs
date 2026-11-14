using System;
using System.Threading.Tasks;

namespace Phase_4_SOLID_Principles.Week_5_SOLID_Principles
{
    public class Diagnostics_Solution
    {
        public static void Run()
        {
            var processor = new ActionProcessor();

            IUserRole admin = new AdminRole();
            IUserRole guest = new GuestRole();

            Console.WriteLine("--- Processing Admin ---");
            processor.ProcessUserAction(admin);

            Console.WriteLine("\n--- Processing Guest ---");
            processor.ProcessUserAction(guest);
        }
    }

    public interface IUserRole
    {
        void ExecuteDashboardAction();
    }

    public class AdminRole : IUserRole
    {
        public void ExecuteDashboardAction()
        {
            Console.WriteLine("Accessing database configurations...");
        }
    }

    public class GuestRole : IUserRole
    {
        public void ExecuteDashboardAction()
        {
            Console.WriteLine("Access Denied: Read-only access granted.");
        }
    }

    public class ManagerRole : IUserRole
    {
        public void ExecuteDashboardAction()
        {
            Console.WriteLine("Generating branch performance reports...");
        }
    }

    public class ActionProcessor
    {
        public void ProcessUserAction(IUserRole userRole)
        {
            userRole.ExecuteDashboardAction();
        }
    }
}