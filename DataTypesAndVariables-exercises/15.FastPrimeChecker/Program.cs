using System;

namespace _15.FastPrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int numberToCheck = int.Parse(Console.ReadLine());
            for (int i = 0; i <= numberToCheck; i++)
            {
                bool isPrime = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (i >= 2)
                {
                    Console.WriteLine($"{i} -> {isPrime}");

                }
            }
        }
    }
}
