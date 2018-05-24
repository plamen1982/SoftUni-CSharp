using System;

namespace _11._ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            int milePerMeters = 1609;

            int meters = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            int totalSeconds = hours * 3600 + minutes * 60 + seconds;
            float totalHours = (float)totalSeconds / 3600;

            float kilometers = (float)(meters / 1000);
            float miles = kilometers / 1.609f;

            float metersPerSecond = (float)meters / (float)totalSeconds;
            float kilometersPerHour = kilometers / totalHours;
            float milesPerHour = miles / totalHours;

            Console.WriteLine(metersPerSecond);
            Console.WriteLine(kilometersPerHour);
            Console.WriteLine(milesPerHour);


        }
    }
}
