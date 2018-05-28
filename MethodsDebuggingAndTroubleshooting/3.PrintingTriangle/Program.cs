using System;

namespace _3.PrintingTriangle
{
    class Program
    {
        static void PrintLine(int start, int end)
        {
            for (int j = start; j <= end; j++)
            {
                Console.Write($"{j} ");
            }

            Console.WriteLine();

        }
        static void PrintTop(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                PrintLine(1, i);
            }
        }
        static void PrintBottom(int n)
        {
            for (int i = n - 1; i >= 1; i--)
            {
                PrintLine(1, i);
            }
        }

        static void PrintingTriangle(int n)
        {
            PrintTop(n);
            PrintBottom(n);

        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintingTriangle(n);
        }
    }
}
