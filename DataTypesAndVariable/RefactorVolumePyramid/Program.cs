﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorVolumePyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Length: ");
            double length = double.Parse(Console.ReadLine());

            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());

            Console.Write("Height: ");
            double height = double.Parse(Console.ReadLine());

            double volumePyramid = (length * width * height) / 3;
            Console.WriteLine($"Pyramid Volume: {volumePyramid:F2}");
        }
    }
}
