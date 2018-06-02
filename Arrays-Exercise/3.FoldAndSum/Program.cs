using System;
using System.Linq;

namespace _3.FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersArr = Console.ReadLine()
                                .Split(" ")
                                .Select(int.Parse)
                                .ToArray();
            int k = numbersArr.Length / 4;

            int[] upperArray = new int[numbersArr.Length / 2];
            int[] lowerArray = new int[numbersArr.Length / 2];

            for (int i = 0; i < k; i++)
            {
                upperArray[i] = numbersArr[k - 1 - i];
                //upperArray[4 * k - 2 + i] = numbersArr[4 * k - i - 1];
            }
                                
        }
    }
}
