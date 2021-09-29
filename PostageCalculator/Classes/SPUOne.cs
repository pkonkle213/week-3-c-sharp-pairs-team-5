using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    public class SPUOne : IDeliveryDriver
    {
        public SPUOne(int distance, double weight)
        {
            this.Distance = distance;
            this.Weight = weight;
        }
        public int Distance { get; }
        public double Weight { get; }

        public double CalculateRate(int distance, double weight)
        {
            return ((weight / 16.0) * 0.075) * distance;
        }
        public override string ToString()
        {
            return "SPU (Next Day)            ";
        }
    }
}
