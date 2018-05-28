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
                Console.Write(newString("\\/", n - 1));
                Console.Write('-');
                Console.WriteLine();

            }

            Console.WriteLine(new string('-', 2 * n));
        }

        static string newString(string symbol, int count)
        {
            string result = "";

            for (int i = 0; i < count; i++)
            {
                result += symbol; 
            }
            return result;
        }

        static void Main(string[] args)
        {
            DrawAFilledSquare(int.Parse(Console.ReadLine()));
        }
    }
}
