using System;
using System.Collections.Generic;
using System.Text;

namespace Phase_5_Design_Patterns.Week_8_Behavioral_Patterns.Strategy_Pattern.Interfaces
{
    public interface IShipping
    {
        decimal CalculateCost(double packageWeightKg);
    }
}
