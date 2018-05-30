using System;

namespace _1.HelloName
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            HelloName(name);
        }

        static void HelloName(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
