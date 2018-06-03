using System;
using System.Linq;

namespace _6.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int count = 1;
            int biggestCount = int.MinValue;
            int number = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    count++;
                    if (biggestCount < count)
                    {
                        biggestCount = count;
                        number = numbers[i];
                    }
                }
                else
                {
                    count = 1;
                }
            }
            for (int i = 0; i < biggestCount; i++)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();
        }
    }
}