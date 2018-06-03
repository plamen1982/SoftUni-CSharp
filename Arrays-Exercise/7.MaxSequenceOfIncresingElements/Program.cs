using System;
using System.Linq;

namespace _7.MaxSequenceOfIncresingElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int count = 1;
            int biggestCount = 0;
            int startIndex = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > numbers[i - 1])
                {
                    count++;
                    if (biggestCount < count)
                    {
                        biggestCount = count;
                        startIndex = i - biggestCount + 1;
                    }
                }
                else
                {
                    count = 1;
                }
            }
            for (int i = startIndex; i < startIndex + biggestCount; i++)
            {
                Console.Write($"{numbers[i]} ");
            }
        }
    }
}
