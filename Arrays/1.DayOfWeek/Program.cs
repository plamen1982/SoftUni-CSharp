using System;

namespace _1.DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string[] dayOfWeek = 
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };
            for (int i = 1; i <= dayOfWeek.Length; i++)
            {
                if (i == number)
                {
                    Console.WriteLine(dayOfWeek[i - 1]);
                    return;
                }
            }
            Console.WriteLine("Invalid day!");
        }
    }
}
