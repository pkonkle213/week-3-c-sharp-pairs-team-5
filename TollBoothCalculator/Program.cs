using System;
using System.Collections.Generic;
using TollBoothCalculator.Classes;

namespace TollBoothCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IVehicle> vehicles = new List<IVehicle>();

            Random rnd = new Random();
            decimal sumTolls = 0.0M;
            int sumMiles = 0;
            Console.WriteLine("Vehicle            Distance Traveled      Toll $");
            Console.WriteLine("------------------------------------------------");

            vehicles.Add(new Car(false));
            vehicles.Add(new Car(true));
            vehicles.Add(new Tank());
            vehicles.Add(new Truck(4));
            vehicles.Add(new Truck(6));
            vehicles.Add(new Truck(8));

            foreach (IVehicle vehicle in vehicles)
            {
                int distance = rnd.Next(10,241);
                decimal toll = (decimal)vehicle.CalculateToll(distance);
                sumTolls += toll;
                sumMiles += distance;

                Console.WriteLine($"{vehicle}     {distance}               {toll.ToString("C")}");
            }

            Console.WriteLine();
            Console.WriteLine("Total Miles Traveled: " + sumMiles);
            Console.WriteLine("Total Toolbooth Revenue: " + sumTolls.ToString("C"));
        }
    }
}
