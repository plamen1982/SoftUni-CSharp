using System;

namespace _11.GeometryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeFigure = Console.ReadLine();
            GetAreaOfFigure(typeFigure);
        }

        static void GetAreaOfFigure(string typeFigure)
        {
            switch (typeFigure)
            {
                case "triangle":
                    double sideTriangle = double.Parse(Console.ReadLine());
                    double height = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{AreaOfTriangle(sideTriangle, height):f2}");
                    break;

                case "rectangle":
                    double side1 = double.Parse(Console.ReadLine());
                    double side2 = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{AreaOfRectangle(side1, side2):f2}");
                    break;

                case "square":
                    double side = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{AreaOfSquare(side):f2}");
                    break;

                case "circle":
                    double radius = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{AreaOfCircle(radius):f2}");
                    break;
            }
        }
        
        static double AreaOfCircle(double radius)
        {
            double area = Math.PI * radius * radius;
            return area;
        }
        static double AreaOfRectangle(double side1, double side2)
        {
            double area = side1 * side2;
            return area;
        }
        static double AreaOfSquare(double side)
        {
            double area = side * side;
            return area;
        }
        static double AreaOfTriangle(double side, double height)
        {
            double area = side * height / 2;
            return area;
        }
    }
}
