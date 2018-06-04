using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.AppendLists
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("|");
            List<int> num = new List<int>();
            List<int> temp = new List<int>();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                temp = input[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();   // 7 8
                for (int j = 0; j < temp.Count; j++)
                {
                    num.Add(temp[j]);
                }
            }

            Console.WriteLine(string.Join(" ", num));

        }
    }
}
