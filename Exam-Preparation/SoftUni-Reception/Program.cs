using System;

namespace SoftUni_Reception
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstEmp = double.Parse(Console.ReadLine());
            double secondEmp = double.Parse(Console.ReadLine());
            double thirdEmp = double.Parse(Console.ReadLine());
            double studentsCount = double.Parse(Console.ReadLine());
            double fixedStudens = firstEmp + secondEmp + thirdEmp;
            double hoursWithoutBreak = studentsCount / (firstEmp + secondEmp + thirdEmp);
            double hoursToBreak = Math.Ceiling(hoursWithoutBreak / 3.0);
            double totalHours = Math.Floor(hoursWithoutBreak + hoursToBreak);
            double hours = 0;
            while (studentsCount > 0)
            {
                studentsCount -= fixedStudens;
                hours++;
                if (hours % 3 == 0)
                {
                    hours++;
                }
            }
            Console.WriteLine($"Time needed: {totalHours}h.");

        }
    }
}