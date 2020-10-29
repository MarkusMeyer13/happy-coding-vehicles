using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesCmd
{
    public abstract class Vehicle: IDriveable
    {
        private Manufacturer manufacturer;

        public Vehicle(Manufacturer manufacturer)
        {
            this.manufacturer = manufacturer;
        }

        public void Drive()
        {
            Console.WriteLine("Drive");
        }

        public override string ToString()
        {
            return $"I'm a {this.GetType().BaseType.Name}, but I'm a {this.GetType().Name} - {manufacturer.Name}";
        }

    }
}
