using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8._2___24._05._2024
{
    internal class Truck : Vehicle
    {
        public override void Drive(int distance)
        {
            this.FuelQuantity = 35;
            this.FuelConsumptionPerKm = 2.5;
            if (distance >= 0)
                if (this.FuelQuantity >= distance * (this.FuelConsumptionPerKm + 1.5))
                {
                    this.FuelQuantity -= distance * (this.FuelConsumptionPerKm + 1.5);
                    Console.WriteLine($"Truck {distance}km yol getdi, Qalan yanacaq: {this.FuelQuantity} ");
                }
                else 
                { 
                    double needFuel = distance * (this.FuelConsumptionPerKm + 0.5) - this.FuelQuantity;
                    Console.WriteLine($"Kifayet qeder benzin yoxdur, {needFuel}litr benzin lazimdir"); 
                }


        }

        public override void Refuel(int amount)
        {
            if (amount + this.FuelQuantity < 100)
                this.FuelQuantity += amount;
            else
                FuelQuantity = 100;
        }
    }
}
