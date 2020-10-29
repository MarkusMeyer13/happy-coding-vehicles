using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesCmd
{
    public class AmphibiousVehicle: Vehicle, ISwimable
    {
        public AmphibiousVehicle(Manufacturer manufacturer) : base(manufacturer)
        {

        }

        public void Swim()
        {
            Console.WriteLine("I can also swim");
        }
    }
}
