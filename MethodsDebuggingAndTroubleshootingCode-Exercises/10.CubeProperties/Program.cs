using System;

namespace _10.CubeProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double cubeSide = double.Parse(Console.ReadLine());
            string cubeParameters = Console.ReadLine();
            Console.WriteLine($"{CubeProperities(cubeSide, cubeParameters):f2}"); 
        }

        static double CubeProperities(double cubeSide, string cubeParameter)
        {
            double result = 0.0;
            switch (cubeParameter)
            {
                case "face":
                    result = Math.Sqrt(2 * Math.Pow(cubeSide, 2));
                    break;
                case "volume":
                    result = Math.Pow(cubeSide, 3);
                    break;
                case "space":
                    result = Math.Sqrt(3 * Math.Pow(cubeSide, 2));
                    break;
                case "area":
                    result = 6 * Math.Pow(cubeSide, 2);
                    break;
            }
            return result;
        }
    }
}
