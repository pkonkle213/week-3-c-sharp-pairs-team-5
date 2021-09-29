using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    public class SPUFour : IDeliveryDriver
    {
        public SPUFour(int distance, double weight)
        {
            this.Distance = distance;
            this.Weight = weight;
        }
        public int Distance { get; }
        public double Weight { get; }

        public double CalculateRate(int distance, double weight)
        {
            return ((weight / 16.0) * 0.0050) * distance;
        }
        public override string ToString()
        {
            return "SPU (4-Day Ground)        ";
        }
    }
}

