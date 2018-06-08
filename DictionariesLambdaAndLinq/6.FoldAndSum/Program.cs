using System;
using System.Linq;

namespace _6.FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {

            //Solution with LINQ
            int[] numbers = Console.ReadLine().Split(new char[] {' '}).Select(int.Parse).ToArray();
            int k = numbers.Length / 4;

            int[] middArray = numbers.Skip(k).Take(2 * k).ToArray();
            int[] upperArray = numbers.Take(k).Reverse().ToArray().Concat(numbers.Reverse().Take(k).ToArray()).ToArray();
            int[] sumArray = new int[middArray.Length];

            for (int i = 0; i < upperArray.Length; i++)
            {
                sumArray[i] = upperArray[i] + middArray[i];
            }

            Console.WriteLine(string.Join(" ", sumArray));
            //Solution with no LINQ
            /*
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int k = numbers.Length / 4;

            int[] leftArray = new int[k];
            int[] rightArray = new int[k];
            int[] middArray = new int[2 * k];
            int[] sumArray = new int[2 * k];

            //left array
            for (int i = 0; i < k; i++)
            {
                leftArray[k - 1 - i] = numbers[i];
            }

            //midd array

            for (int i = k; i < 3 * k; i++)
            {
                middArray[i - k] = numbers[i];
            }

            //right array
            for (int i = 0; i < k; i++)
            {
                rightArray[i] = numbers[numbers.Length - i - 1];
            }

            //sum array 

            for (int i = 0; i < sumArray.Length; i++)
            {
                // sumArray = leftArray + middArray
                if (i < k)
                {
                    sumArray[i] = leftArray[i] + middArray[i];

                }
                // sumArray = rightArray + middArray

                else
                {
                    sumArray[i] = rightArray[i - k] + middArray[i];
                }
            }

            Console.WriteLine(string.Join(" ", sumArray));
            */
        }
    }
}
