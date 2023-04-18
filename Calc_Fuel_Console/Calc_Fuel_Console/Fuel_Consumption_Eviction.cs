using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_Fuel_Console
{
    internal class Fuel_Consumption_Eviction
    {
        public Fuel_Consumption_Eviction() { }
        public float Cost_Travel(float Distance, float AverageFuelConsumption, float FuelCost)
        {
            return (Distance / 100) * AverageFuelConsumption * FuelCost;
        }
        public float Must_Amount_Fuel(float Distance, float AverageFuelConsumption)
        {
            return (Distance / 100) * AverageFuelConsumption;
        }
    }
}
