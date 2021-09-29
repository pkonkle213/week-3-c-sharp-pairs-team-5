using System;
using System.Collections.Generic;
using System.Text;

namespace TollBoothCalculator.Classes
{
    public class Car : IVehicle
    {
        public bool HasTrailer { get; }

        public Car(bool hasTrailer)
        {
            this.HasTrailer = hasTrailer;
        }

        public double CalculateToll(int distance)
        {
            double toll = distance * 0.020;
            if (HasTrailer)
            {
                toll += 1;
            }
            return toll;
        }

        public override string ToString()
        {
            if (HasTrailer)
            {
                return "Car (with trailer)  ";
            }
            else
            {
                return "Car                 ";
            }
        }
    }
}
