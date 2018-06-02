using System;
using System.Linq;

namespace _2.RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] arrayOfInt = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] sum = new int[arrayOfInt.Length];
            int kTimes = int.Parse(Console.ReadLine());
            for (int i = 0; i < kTimes; i++)
            {
                RotatedArray(arrayOfInt);
                for (int j = 0; j < arrayOfInt.Length; j++)
                {
                    sum[j] += arrayOfInt[j];
                }
            }

            Console.WriteLine(string.Join(" ", sum));

        }

        static int[] RotatedArray(int[] arrayOfInt)
        {
            int lastIndex = arrayOfInt[arrayOfInt.Length - 1];

            for (int i = 0; i < arrayOfInt.Length - 1; i++)
            {
                arrayOfInt[arrayOfInt.Length - 1 - i] = arrayOfInt[arrayOfInt.Length - 2 - i];
            }

            arrayOfInt[0] = lastIndex;
            return arrayOfInt;
        }
    }
}
