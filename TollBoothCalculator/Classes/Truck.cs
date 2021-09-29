using System;
using System.Collections.Generic;
using System.Text;

namespace TollBoothCalculator.Classes
{
    public class Truck : IVehicle
    {
        public int NumberOfAxles { get; }

        public Truck (int numberOfAxles)
        {
            this.NumberOfAxles = numberOfAxles;
        }

        public double CalculateToll(int distance)
        {
            double ratePerMile;
            if (NumberOfAxles < 6)
            {
                ratePerMile = 0.040;
            }
            else if (NumberOfAxles < 8)
            {
                ratePerMile = 0.045;
            }
            else
            {
                ratePerMile = 0.048;
            }

            return ratePerMile * distance;
        }

        public override string ToString()
        {
            return $"Truck ({NumberOfAxles} axels)     ";
        }
    }
}
