using System;
using System.Linq;

namespace _10.PairsOfDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int difference = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i; j < numbers.Length; j++)
                {
                    if (difference == Math.Abs(numbers[i] - numbers[j]))
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
