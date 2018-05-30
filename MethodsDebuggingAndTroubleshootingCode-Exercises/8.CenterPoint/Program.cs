using System;

namespace _8.CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            GetClosestPoint(x1, y1, x2, y2);

        }
        static void GetClosestPoint(double x1, double y1, double x2, double y2)
        {
            double firstLine = Math.Sqrt(x1 * x1 + y1 * y1);
            double secondLine = Math.Sqrt(x2 * x2 + y2 * y2);
            if (firstLine > secondLine)
            {
                Console.WriteLine($"({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x1}, {y1})");
            }
        }
    }
}
