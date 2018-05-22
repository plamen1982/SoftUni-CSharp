using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.CircleArea12digitsPrecision
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());
            double circleArea = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine($"{circleArea:f12}");
        }
    }
}
