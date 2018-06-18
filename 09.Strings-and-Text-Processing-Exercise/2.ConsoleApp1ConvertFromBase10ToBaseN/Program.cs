using System;
using System.Numerics;

namespace _2.ConsoleApp1ConvertFromBase10ToBaseN
{
    class Program
    {
        static void Main(string[] args)
        {
            var split = Console.ReadLine().Split();
            string n = split[1];
            int b = int.Parse(split[0]);
            var result = new BigInteger(0);
            for (int i = 0; i < n.Length; i++)
            {
                int c = n[n.Length - 1 - i] - '0';
                result += c * BigInteger.Pow(b, i);
            }
            Console.WriteLine(result);
        }
    }
}
