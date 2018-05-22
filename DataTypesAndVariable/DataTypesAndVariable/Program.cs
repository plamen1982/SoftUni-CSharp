using System;
using System.Numerics;

namespace DataTypesAndVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            for (int i = 0; i < 100000000; i++)
            {
                Console.Write(i*100);
                Console.Write("\r");
            }
        }
    }
}
