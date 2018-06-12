using System;
using System.Collections.Generic;
using System.Text;

namespace DistanceBetweenPoints
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public static double calculateBetweenTwoPoints(Point p1, Point p2)
        {
            //return Math.Sqrt(Math.Pow(p1.X))
        }
    }
}
