using System;
using System.Collections.Generic;
using PostageCalculator.Classes;

namespace PostageCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IDeliveryDriver> deliveryMethod = new List<IDeliveryDriver>();

            Console.Write("Please enter the weight of the package: ");
            int weight = int.Parse(Console.ReadLine());

            Console.Write("(P)ounds or (O)unces? ");
            string units = Console.ReadLine();

            if (units == "P" || units == "p")
            {
                weight *= 16;
            }

            Console.Write("What distance will it be traveling? ");
            int distance = int.Parse(Console.ReadLine());

            deliveryMethod.Add(new FirstClass(distance, weight));
            deliveryMethod.Add(new SecondClass(distance, weight));
            deliveryMethod.Add(new ThirdClass(distance, weight));
            deliveryMethod.Add(new FexEd(distance, weight));
            deliveryMethod.Add(new SPUFour(distance, weight));
            deliveryMethod.Add(new SPUTwo(distance, weight));
            deliveryMethod.Add(new SPUOne(distance, weight));

            Console.WriteLine();
            Console.WriteLine("Delivery Method                 $ cost");
            Console.WriteLine("--------------------------------------");

            foreach (IDeliveryDriver driver in deliveryMethod)
            {
                double rate = driver.CalculateRate(distance, weight);
                Console.WriteLine($"{driver}    {rate.ToString("C")}");
            }
        }
    }
}
