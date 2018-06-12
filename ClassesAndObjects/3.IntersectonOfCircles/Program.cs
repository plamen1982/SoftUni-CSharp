using System;

namespace _3.IntersectonOfCircles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input1 = Console.ReadLine().Split();
            string[] input2 = Console.ReadLine().Split();

            double x1 = double.Parse(input1[0]);
            double y1 = double.Parse(input1[1]);
            double radius = double.Parse(input1[2]);
            Point p1 = new Point(x1, y1);
            Circle c1 = new Circle(p1, radius);

            double x2 = double.Parse(input2[0]);
            double y2 = double.Parse(input2[1]);
            Point p2 = new Point(x2, y2);
            double radius2 = double.Parse(input2[2]);
            Circle c2 = new Circle(p2, radius2);

            if (Circle.Intersect(c1, c2))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");

            }

        }
    }
}
