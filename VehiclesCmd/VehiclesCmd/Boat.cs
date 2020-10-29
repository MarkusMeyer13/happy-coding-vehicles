using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesCmd
{
    public abstract class Boat : ISwimable
    {
        public void Swim()
        {
            Console.WriteLine("Swim");
        }
    }
}
