using System;

namespace _2.MaxNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine(GetMax(a, b, c));
        }

        static int GetMax(int a, int b, int c)
        {
            int maxAB = Math.Max(a, b);
            return Math.Max(maxAB, c);
        }
    }
}
