using System;
using System.Collections.Generic;

namespace _7.PrimesInGivenRange
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            PrintPrimeNumbers(FindPrimesInRange(startNum, endNum));
        }

        static List<long> FindPrimesInRange(long startNum, long endNum)
        {
            List<long> primeNumbers = new List<long>();

            for (long i = startNum; i <= endNum; i++)
            {
                if (IsPrime(i))
                {
                    primeNumbers.Add(i);
                };

            }

            return primeNumbers;
        }

        static void PrintPrimeNumbers(List<long> primeNumbers)
        {
            for (int i = 0; i < primeNumbers.Count; i++)
            {
                if (i == primeNumbers.Count - 1)
                {
                    Console.WriteLine($"{primeNumbers[i]}");
                }
                else
                {
                    Console.Write($"{primeNumbers[i]}, ");

                }
            }
        }

        public static bool IsPrime(long number)
        {
            if (number == 1)
            {
                return false;
            };
            if (number == 2)
            {
                return true;
            };
            if (number % 2 == 0)
            {
                return false;
            };

            long boundary = (long)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0)
                {
                    return false;
                };
            }

            return true;
        }

    }
}
