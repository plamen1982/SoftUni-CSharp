using System;

namespace _6.CalculateTriangleArea
{
    class Program
    {
        static double CalculateTriangleArea(double a, double h)
        {
            return (a * h)/2.0 ;
        }
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double area = CalculateTriangleArea(a, h);
            Console.WriteLine(area);
        }
    }
}
