using System;
using System.Numerics;

namespace _1.ConvertFromBase10ToBaseN.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            var split = Console.ReadLine().Split();
            var n = BigInteger.Parse(split[1]);
            int b = int.Parse(split[0]);
            string baseN = "";
            while (n > 0)
            {
                baseN = n % b + baseN;
                n /= b;
            }
            Console.WriteLine(baseN);
        }
    }
}
