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

    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double X, double Y)
        {
            this.X = X;
            this.Y = Y;
        }
    }

    class Circle
    {
        public Point Center { get; set; }
        public double Radius { get; set; }

        public Circle(Point p1, double Radius)
        {
            this.Center = p1;
            this.Radius = Radius;
        }

        public static bool Intersect(Circle c1, Circle c2)
        {
            double distance = Math.Sqrt((c1.Center.X - c2.Center.X) * (c1.Center.X - c2.Center.X) + (c1.Center.X - c2.Center.X) * (c1.Center.Y - c2.Center.Y));

            bool isIntersect;

            if (c1.Radius + c2.Radius >= distance)
            {
                return isIntersect = true;
            }
            else
            {
                return isIntersect = false;
            }
        }
    }
}
