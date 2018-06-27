using System;
using System.Collections.Generic;
using System.Numerics;

namespace _1.Snowballs_5Jan218Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberSnowBalls = int.Parse(Console.ReadLine());
            long maxSnowballSnow = long.MinValue;
            long maxSnowballTime = long.MinValue;
            long maxSnowballQuality = long.MinValue;
            BigInteger maxSnowballValue = BigInteger.MinusOne;
            for (int i = 0; i < numberSnowBalls; i++)
            {
                long snowballSnow = long.Parse(Console.ReadLine());
                long snowballTime = long.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());
                BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime),  snowballQuality);
                if (maxSnowballValue < snowballValue)
                {
                    maxSnowballSnow = snowballSnow;
                    maxSnowballTime = snowballTime;
                    maxSnowballQuality = snowballQuality;
                    maxSnowballValue = snowballValue;
                }
            }
            Console.WriteLine($"{ maxSnowballSnow} : { maxSnowballTime} = { maxSnowballValue} ({ maxSnowballQuality})");
        }
    }
}
