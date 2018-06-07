using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.AssociativeArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();
        }
    }
}
