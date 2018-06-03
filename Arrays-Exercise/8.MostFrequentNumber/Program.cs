using System;
using System.Linq;

namespace _8.MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int number = 0;
            int biggestCount = int.MinValue;
            int count = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        count++;
                    }
                }

                if (biggestCount < count)
                {
                    biggestCount = count;
                    number = numbers[i];
                }
                count = 1;
            }
            Console.WriteLine(number);
        }
    }
}
