using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    public class FexEd : IDeliveryDriver
    {
        public FexEd(int distance, double weight)
        {
            this.Distance = distance;
            this.Weight = weight;
        }
        public int Distance { get; }
        public double Weight { get; }

        public double CalculateRate(int distance, double weight)
        {
            decimal rate = 20.00M;
            if (Distance > 500)
            {
                rate += 5.00M;
            }
            if (Weight > 48)
            {
                rate += 3.00M;
            }
            return (double)rate;
        }
        public override string ToString()
        {
            return "FexEd                     ";
        }
    }
}
