using System;

namespace _5.TemperatureConversion
{
    class Program
    {
        static double TemperatureConversion(double n)
        {

            double fahrenheit = (n - 32) * 5 / 9;
            return fahrenheit;
        }
        static void Main(string[] args)
        {
          double celsius = TemperatureConversion(double.Parse(Console.ReadLine()));
          Console.WriteLine($"{celsius:f2}");
        }
    }
}
