using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace VehiclesCmd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var amphibiousVehicle = new AmphibiousVehicle(new Manufacturer() { Name = "DontKnow" });
            amphibiousVehicle.Drive();
            amphibiousVehicle.Swim();

            ISwimable swimable = new AmphibiousVehicle(new Manufacturer() { Name = "DontKnowAlso" });
            swimable.Swim();

            IDriveable driveable = new AmphibiousVehicle(new Manufacturer() { Name = "DontKnowAlsoToo" });
            driveable.Drive();

            SpeedBoat speedBoat = new SpeedBoat();
            speedBoat.Swim();



            IList<ISwimable> swimables = new List<ISwimable>();
            swimables.Add(amphibiousVehicle);
            swimables.Add(swimable);
            swimables.Add(speedBoat);


            SwimAll(swimables);

            #region zu


            //Manufacturer bmw = new Manufacturer();
            //bmw.Name = "BMW";
            //Car car = new Car(bmw);
            //Console.WriteLine(car.ToString());
            //car.Drive();

            //Manufacturer ford = new Manufacturer() { Name = "Ford" };
            //Truck truck = new Truck(ford);
            //Console.WriteLine(truck.ToString());
            //truck.Drive();
            #endregion
            Console.ReadLine();
            //Car car = new Car(new Manufacturer() { Name = "BMW" });

        }

        private static void SwimAll(IList<ISwimable> swimable)
        {
            IEnumerator<ISwimable> enumerator = swimable.GetEnumerator();
            while (enumerator.MoveNext())
            {
                enumerator.Current.Swim();
            }
        }
    }
}
