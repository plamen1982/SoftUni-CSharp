using System;
using System.Collections.Generic;

namespace _1.Snowballs_5Jan218Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, double> bestSnowball = new Dictionary<string, double>();
            bestSnowball["snowballSnow"] = 0.0;
            bestSnowball["snowballTime"] = 0.0;
            bestSnowball["snowballQuality"] = 0.0;
            bestSnowball["maxSnowBallValue"] = 0.0;
            double maxSnowValue = double.MinValue;

            for (int i = 0; i < n; i++)
            {
                double snowballSnow = double.Parse(Console.ReadLine());
                double snowballTime = double.Parse(Console.ReadLine());
                double snowballQuality = double.Parse(Console.ReadLine());
                double currentValue = snowballValue(snowballSnow, snowballTime, snowballQuality);
                if (maxSnowValue < currentValue)
                {
                    maxSnowValue = currentValue;
                    bestSnowball["snowballSnow"] = snowballSnow;
                    bestSnowball["snowballTime"] = snowballTime;
                    bestSnowball["snowballQuality"] = snowballQuality;
                    bestSnowball["maxSnowBallValue"] = maxSnowValue;
                }
            }

            Console.WriteLine($"{bestSnowball["snowballSnow"]:f0} : {bestSnowball["snowballTime"]:f0} = {bestSnowball["maxSnowBallValue"]:f0} ({bestSnowball["snowballQuality"]:f0})");
        }

        static double snowballValue(double snowballSnow, double snowballTime, double snowballQuality)
        {
            double result = Math.Pow((snowballSnow / snowballTime), snowballQuality);
            return result;
        }
    }
}
