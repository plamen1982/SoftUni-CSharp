using System;

namespace AddTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int result = num1 + num2;
            Console.WriteLine($"{num1} + {num2} = {result}");
        }
    }
}
