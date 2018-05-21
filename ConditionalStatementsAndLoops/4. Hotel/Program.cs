using System;

namespace _4._Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            double studio = 0.0;
            double doubleRoom = 0.0;
            double suite = 0.0;
            int freeNightStudio = 0;

            if (month == "May" || month == "October")
            {
                studio = 50;
                doubleRoom = 65;
                suite = 75;

                if (days > 7)
                {
                    studio = studio * 0.95;
                }

                if (days > 7 && month == "October")
                {
                    freeNightStudio++;
                }
            }

            else if (month == "June" || month == "September")
            {
                studio = 60;
                doubleRoom = 72;
                suite = 82;

                if (days > 14)
                {
                    doubleRoom = doubleRoom * 0.90;
                }

                if (days > 7 && month == "September")
                {
                    freeNightStudio++;
                }
            }

            else if (month == "July" || month == "August" || month == "December")
            {
                studio = 68;
                doubleRoom = 77;
                suite = 89;

                if (days > 14)
                {
                    suite = suite * 0.85;
                }

            }

            
            Console.WriteLine($"Studio: {(studio * (days - freeNightStudio)):F2} lv.");
            Console.WriteLine($"Double: {(doubleRoom * days):F2} lv.");
            Console.WriteLine($"Suite: {(suite * days):F2} lv.");

        }
    }
}
