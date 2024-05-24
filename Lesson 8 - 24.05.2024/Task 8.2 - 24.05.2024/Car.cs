using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8._2___24._05._2024
{
    public class Car : Vehicle
    {
        public override void Drive(int distance)
        {
            this.FuelQuantity = 20;
            this.FuelConsumptionPerKm = 0.5;
            if(distance >= 0)
                if(this.FuelQuantity >=  distance * (this.FuelConsumptionPerKm + 0.5))
                {
                    this.FuelQuantity -= distance * (this.FuelConsumptionPerKm + 0.5);
                    Console.WriteLine($"Masin {distance}km yol getdi, Qalan yanacaq: {this.FuelQuantity} ");
                }
                else
                {
                    double needFuel = distance * (this.FuelConsumptionPerKm + 0.5) - this.FuelQuantity;
                    Console.WriteLine($"Kifayet qeder benzin yoxdur, {needFuel}litr benzin lazimdir");
                }

        }

        public override void Refuel(int amount)
        {
            if (amount + this.FuelQuantity < 60)
                this.FuelQuantity += amount;
            else
                FuelQuantity = 60;
        }

    }
}
