using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            int tempNumber = 0;

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    tempNumber = numbers[i] + numbers[i - 1];
                    numbers[i - 1] = tempNumber;
                    numbers.RemoveAt(i);
                    i = 0;
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
