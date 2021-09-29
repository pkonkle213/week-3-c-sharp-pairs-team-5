using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    public class ThirdClass : IDeliveryDriver
    {
        public ThirdClass(int distance, double weight)
        {
            this.Distance = distance;
            this.Weight = weight;
        }
        public int Distance { get; }
        public double Weight { get; }

        public double CalculateRate(int distance, double weight)
        {
            if (weight <= 2)
            {
                return distance * 0.0020;
            }
            else if (weight <= 8)
            {
                return distance * 0.0022;
            }
            else if (weight <= 15)
            {
                return distance * 0.0024;
            }
            else if (weight <= 48)
            {
                return distance * 0.0150;
            }
            else if (weight <= 128)
            {
                return distance * 0.0160;
            }
            else
            {
                return distance * 0.0170;
            }
        }
        public override string ToString()
        {
            return "Postal Service (3rd Class)";
        }
    }
}
