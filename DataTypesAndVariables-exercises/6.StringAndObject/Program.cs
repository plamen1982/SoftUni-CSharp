using System;

namespace _6.StringAndObject
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hello";
            string world = "World";
            
            object helloWorld = hello + " " + world;
            string helloWorldString = (string)helloWorld;

            Console.WriteLine(helloWorld);
        }
    }
}
