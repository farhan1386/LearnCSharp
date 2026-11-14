using System;
using System.Collections.Generic;
using System.Text;

namespace Phase_5_Design_Patterns.Week_6_Creational_Design_Patterns.Factory.Interfaces
{
    public interface INotification
    {
        void Send(string recipient, string message);
    }
}
