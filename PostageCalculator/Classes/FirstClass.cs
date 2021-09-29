using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    public class FirstClass : IDeliveryDriver
    {
        public FirstClass(int distance, double weight)
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
                return distance * 0.035;
            }
            else if (weight <= 8)
            {
                return distance * 0.040;
            }
            else if (weight <= 15)
            {
                return distance * 0.047;
            }
            else if (weight <= 48)
            {
                return distance * 0.195;
            }
            else if (weight <= 128)
            {
                return distance * 0.450;
            }
            else 
            {
                return distance * 0.500;
            }
        }
        public override string ToString()
        {
            return "Postal Service (1st Class)";
        }
    }
}
