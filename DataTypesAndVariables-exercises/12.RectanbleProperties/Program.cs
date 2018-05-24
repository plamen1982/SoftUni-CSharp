using System;

namespace _12.RectanbleProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double widthPow = Math.Pow(width, 2); 
            double heightPow = Math.Pow(height, 2);

            double perimeter = width * 2 + height * 2;
            double area = width * height;
            double diagonal = Math.Sqrt((widthPow  + heightPow));

            Console.WriteLine(perimeter);
            Console.WriteLine(area);
            Console.WriteLine(diagonal);
        }
    }
}
