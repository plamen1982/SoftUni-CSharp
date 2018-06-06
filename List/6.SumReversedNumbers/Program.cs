using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.SumReversedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputNumbers = Console.ReadLine().Split(" ");
            long sum = 0;
            for (int i = 0; i < inputNumbers.Length; i++)
            {
                string output = "";
                for (int j = inputNumbers[i].Length - 1; j >= 0 ; j--)
                {
                     output += "" + inputNumbers[i][j];
                }

                sum += int.Parse(output);
            }

            Console.WriteLine(sum);
        }
    }
}
