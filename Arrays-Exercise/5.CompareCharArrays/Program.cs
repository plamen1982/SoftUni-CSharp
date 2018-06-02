using System;
using System.Linq;

namespace _5.CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] firstArray = Console.ReadLine().Split(" ").Select(char.Parse).ToArray();
            char[] secondArray = Console.ReadLine().Split(" ").Select(char.Parse).ToArray();
            int minLength = Math.Min(firstArray.Length, secondArray.Length);

            for (int i = 0; i < minLength; i++)
            {
                if (firstArray[i] < secondArray[i])
                {
                    Console.WriteLine(string.Join("", firstArray));
                    Console.WriteLine(string.Join("", secondArray));
                    return;
                }

                else if (firstArray[i] > secondArray[i])
                {
                    Console.WriteLine(string.Join("", secondArray));
                    Console.WriteLine(string.Join("", firstArray));
                    return;
                }
            }
            if (minLength == firstArray.Length)
            {
                Console.WriteLine(string.Join("", firstArray));
                Console.WriteLine(string.Join("", secondArray));
            }
            else
            {
                Console.WriteLine(string.Join("", secondArray));
                Console.WriteLine(string.Join("", firstArray));
            }
        }
    }
}
