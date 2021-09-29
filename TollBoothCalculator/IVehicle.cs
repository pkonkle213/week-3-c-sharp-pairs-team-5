using System;
using System.Collections.Generic;
using System.Text;

namespace TollBoothCalculator
{
    public interface IVehicle
    {
        double CalculateToll(int distance);
    }
}
