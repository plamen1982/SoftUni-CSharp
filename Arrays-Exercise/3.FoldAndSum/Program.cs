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
            int[] sum = new int[numbersArr.Length / 2];

            for (int i = 0; i < k; i++)
            {
                upperArray[i] = numbersArr[k - 1 - i];
                upperArray[upperArray.Length - 1 - i] = numbersArr[3 * k + i];
            }

            for (int j = 0; j < 2 * k; j++)
            {
                lowerArray[j] = numbersArr[k + j];
            }

            for (int m = 0; m < 2 * k; m++)
            {
                sum[m] = upperArray[m] + lowerArray[m];
            }
            Console.WriteLine( string.Join(" ", sum));
        }
    }
}
