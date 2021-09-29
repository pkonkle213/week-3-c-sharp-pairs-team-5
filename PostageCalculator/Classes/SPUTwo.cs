using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{

    public class SPUTwo : IDeliveryDriver
    {
        public SPUTwo(int distance, double weight)
        {
            this.Distance = distance;
            this.Weight = weight;
        }
        public int Distance { get; }
        public double Weight { get; }

        public double CalculateRate(int distance, double weight)
        {
            return ((weight / 16.0) * 0.050) * distance;
        }
        public override string ToString()
        {
            return "SPU (2-Day Business)      ";
        }
    }

}
