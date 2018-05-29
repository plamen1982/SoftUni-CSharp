using System;

namespace _7.MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            double result = MathPower(number, power);
            Console.WriteLine(result);
        }
        static double MathPower(double number, double power)
        {
            double temp = number;
            for (int i = 0; i < power - 1; i++)
            {
                number *= temp;
            }
            return number;
        }
    }
}
