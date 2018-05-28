using System;

namespace _4.DrawAFilledSquare
{
    class Program
    {
        static void DrawAFilledSquare(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
            
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write('-');

                for (int j = 0; j <  n - 1; j++)
                {
                    Console.Write("\\/");
                }

                Console.Write('-');
                Console.WriteLine();

            }

            Console.WriteLine(new string('-', 2 * n));
        }
        static void Main(string[] args)
        {
            DrawAFilledSquare(int.Parse(Console.ReadLine()));
        }
    }
}
