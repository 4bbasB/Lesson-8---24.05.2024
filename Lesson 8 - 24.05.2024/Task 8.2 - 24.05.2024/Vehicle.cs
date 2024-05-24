using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8._2___24._05._2024
{
    public abstract class Vehicle
    {
        public double FuelQuantity { get; set; }
        public double FuelConsumptionPerKm { get; set; }

        public abstract void Drive(int distance);

        public abstract void Refuel(int amount);
    }
}
