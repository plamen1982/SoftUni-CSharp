using System;
using System.Collections.Generic;

namespace Lists_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> someInts = new List<int>(5);
            double x1 = 3;
            double x2 = 4;
            double y1 = 5;
            double y2 = 6;
            double line = Math.Sqrt((Math.Abs(x1) + Math.Abs(x2)) * (x1 + x2) + y * y);
            Console.WriteLine(line);
        }
    }
}
