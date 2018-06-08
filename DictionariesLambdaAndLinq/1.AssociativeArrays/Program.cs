using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _1.AssociativeArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] inputNumbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
            SortedDictionary<double, int> foundedNumbersOccurance = new SortedDictionary<double, int>();

            foreach (var number in inputNumbers)
            {
                if (foundedNumbersOccurance.ContainsKey(number))
                {
                    foundedNumbersOccurance[number]++;
                }
                else
                {
                    foundedNumbersOccurance.Add(number, 1);
                }
            }

            foreach (var number in foundedNumbersOccurance)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}
