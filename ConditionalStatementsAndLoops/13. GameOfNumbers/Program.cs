using System;

namespace _13._GameOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = n; i <= m; i++)
            {
                for (int j = n; j <= m; j++)
                {
                    count++;
                    if ((i + j) == magicNumber)
                    {
                        Console.WriteLine($"Number found! {j} + {i} = {magicNumber}");
                        return;
                    }
                }
            }
            Console.WriteLine($"{count} combinations - neither equals {magicNumber}");
        }
    }
}
