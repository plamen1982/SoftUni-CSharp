using System;
using System.Globalization;

namespace ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string startDateStr = Console.ReadLine();
            string endDateStr = Console.ReadLine();

            DateTime startDate = DateTime.ParseExact(startDateStr, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(endDateStr, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            DateTime[] nonWorkingDays =  new DateTime[]
                {
                new DateTime(4, 01, 01),
                new DateTime(4, 03, 03),
                new DateTime(4, 05, 01),
                new DateTime(4, 05, 06),
                new DateTime(4, 05, 24),
                new DateTime(4, 09, 06),
                new DateTime(4, 09, 22),
                new DateTime(4, 11, 01),
                new DateTime(4, 12, 24),
                new DateTime(4, 12, 25),
                new DateTime(4, 12, 26),

            };
            int countWorkDays = 0;

            for (DateTime i = startDate; i <= endDate; i = i.AddDays(1))
            {
                if ((i.DayOfWeek == DayOfWeek.Sunday) == false && ((i.DayOfWeek == DayOfWeek.Saturday) == false)) 
                {
                    countWorkDays++;
                    foreach (var nonWorkingDay in nonWorkingDays)
                    {
                        if ((nonWorkingDay.Day == i.Day) && (nonWorkingDay.Month == i.Month))
                        {
                            countWorkDays--;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(countWorkDays);

        }
    }
}
