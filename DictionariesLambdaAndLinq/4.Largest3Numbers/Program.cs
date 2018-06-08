using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] result = inputNumbers.OrderByDescending(x => x).Take(3).ToArray();
            Console.WriteLine(string.Join(" ", result));

        }
    }
}
