using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.SearchForANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            int[] conditions = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            List<int> newNumbers = new List<int>();


            int takeNums = conditions[0];
            int deleteNumbs = conditions[1];
            int searchNums = conditions[2];


            for (int i = 0; i < takeNums; i++)
            {
                newNumbers.Add(numbers[i]);
            }

            for (int j = 0; j < deleteNumbs; j++)
            {
                newNumbers.RemoveAt(0);
            }

            if (newNumbers.Contains(searchNums))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }

        }
    }
}
