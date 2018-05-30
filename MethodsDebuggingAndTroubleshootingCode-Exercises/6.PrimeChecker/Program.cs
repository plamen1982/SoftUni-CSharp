﻿using System;

namespace _6.PrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(number)); 
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
