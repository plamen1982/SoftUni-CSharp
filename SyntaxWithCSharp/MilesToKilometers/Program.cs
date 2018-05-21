using System;

namespace MilesToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            double milesToKilometers = 1.60934;
            double miles = double.Parse(Console.ReadLine());
            double kilometers = miles* milesToKilometers;
            Console.WriteLine($"{kilometers:F2}");
            
        }
    }
}
