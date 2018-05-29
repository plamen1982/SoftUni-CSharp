using System;

namespace _5.FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(FibonacciNumbers(n));
        }
        static long FibonacciNumbers(int n)
        {
            long f0 = 0;
            long f1 = 1;
            long f2 = 1;
            for (int i = 0; i < n; i++)
            {
                f2 = f1 + f0;
                f0 = f1;
                f1 = f2;
            }
            return f2;
        }
    }
}
