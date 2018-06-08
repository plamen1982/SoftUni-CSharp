using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.SumMinMxAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<double> numbers = new List<double>();

            while (n-- > 0)
            {
                numbers.Add(double.Parse(Console.ReadLine()));
            }
            Console.WriteLine($"Sum = {numbers.Sum()}");
            Console.WriteLine($"Min = {numbers.Min()}");
            Console.WriteLine($"Max = {numbers.Max()}");
            Console.WriteLine($"Average = {numbers.Average()}");
        }
    }
}
