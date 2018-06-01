using System;

namespace _3.LastKNumbersSumsSequence
{
    class Program
    {
        static void Main(string[] args)

        {
            /* First Solution
             * 
             * 
            long lengthOfArray = long.Parse(Console.ReadLine());
            long kLimit = long.Parse(Console.ReadLine());

            long[] array = new long[lengthOfArray];
            array[0] = 1;
            long sum = 0;


            for (int i = 0; i < array.Length - kLimit; i++)
            {
                if (i == 0)
                {
                    filledFirstKElementsInArray(array, kLimit);
                }
                else
                {
                    filledNextElementInArray(array, i, kLimit);
                }
            }


            Console.WriteLine(string.Join(" ", array));
        }

        static long[] filledFirstKElementsInArray(long[] array, long kLimit)
        {
            long sum = 0;
            
            for (int j = 0; j < kLimit; j++)
            {
                sum += array[j] + array[j + 1];
                array[j + 1] = sum;
            }
            return array;
        }

        static long[] filledNextElementInArray(long[] array, int startIndex, long kLimit)
        {
            long sum = 0;

            for (int i = startIndex; i <= kLimit + startIndex; i++)
            {
                sum += array[i];
            }

            array[startIndex + kLimit] = sum;
            return array;
            */

            /*Second Solution
                */
            
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        long[] arr = new long[n];
        arr[0] = 1;
        for (int i = 1; i < arr.Length; i++)
            {
                int start = Math.Max(0, i - k);
                int end = i - 1;
                long sum = 0;
                for (int j = start; j <= end; j++)
                {
                    sum += arr[j];
                }
                arr[i] = sum;
            }
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i] + " ");
        }
            Console.WriteLine();
        }
    }
}



