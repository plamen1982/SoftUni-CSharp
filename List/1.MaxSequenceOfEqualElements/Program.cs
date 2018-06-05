using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            int currentLenght = 1;
            int bestLength = 1;
            int bestIndex = 0;

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currentLenght++;
                    if (bestLength < currentLenght)
                    {
                        bestLength = currentLenght;
                        bestIndex = i;
                    }
                }
                else
                {
                    currentLenght = 1;
                }
            }

            for (int j = bestIndex; j > bestIndex - bestLength; j--)
            {
                Console.Write($"{numbers[j]} ");
            }

        }
    }
}
