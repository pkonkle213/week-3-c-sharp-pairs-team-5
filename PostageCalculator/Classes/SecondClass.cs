using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    public class SecondClass : IDeliveryDriver
    {
        public SecondClass(int distance, double weight)
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
                return distance * 0.0035;
            }
            else if (weight <= 8)
            {
                return distance * 0.0040;
            }
            else if (weight <= 15)
            {
                return distance * 0.0047;
            }
            else if (weight <= 48)
            {
                return distance * 0.0195;
            }
            else if (weight <= 128)
            {
                return distance * 0.0450;
            }
            else
            {
                return distance * 0.0500;
            }
        }
        public override string ToString()
        {
            return "Postal Service (2nd Class)";
        }
    }
}
