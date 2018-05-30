using System;

namespace _9.LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            GetLongestLine(x1, y1, x2, y2, x3, y3, x4, y4);
        }

        static void GetLongestLine(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            double xLine1 = x1 - x2;
            double yLine1 = y1 - y2;
            double xLine2 = x3 - x4;
            double yLine2 = y3 - y4;
            double firstLine = Math.Sqrt(xLine1 * xLine1 + yLine1 * yLine1);
            double secondLine = Math.Sqrt(xLine2 * xLine2 + yLine2 * yLine2);
            if (firstLine > secondLine)
            {
                if (Math.Abs(x1) + Math.Abs(y1) > Math.Abs(x2) + Math.Abs(y2))
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");

                }
                else
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");

                }
            }
            else
            {
                if (Math.Abs(x3) + Math.Abs(y3) > Math.Abs(x4) + Math.Abs(y4))
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");

                }
                else
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");

                }
            }
        }

        static void GetClosestPoint(double x1, double y1, double x2, double y2)
        {
            double firstLine = Math.Sqrt(x1 * x1 + y1 * y1);
            double secondLine = Math.Sqrt(x2 * x2 + y2 * y2);
            if (firstLine > secondLine)
            {
                Console.Write($"({x2}, {y2})");
            }
            else
            {
                Console.Write($"({x1}, {y1})");
            }
        }
    }
}
