using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputNumbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            int[] numberAndPower = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int numberToSearch = numberAndPower[0];
            int power = numberAndPower[1];

            for (int i = 0; i < inputNumbers.Count; i++)
            {
                if (inputNumbers[i] == numberToSearch)
                {
                    //Remove values of the array from the left part of the numberToSearch
                    for (int j = 1; j <= power; j++)
                    {
                        if (i - j < 0)
                        {
                            break;
                        }
                        inputNumbers[i - j] = 0;
                    }

                    //Remove values of the array from right part of numberToSearch with the numberToSearch included
                    for (int k = 0; k <= power; k++)
                    {
                        if (i + k == inputNumbers.Count)
                        {
                            break;
                        }
                        inputNumbers[i + k] = 0;
                    }
                }
            }
            Console.WriteLine(inputNumbers.Sum());
        }
    }
}
