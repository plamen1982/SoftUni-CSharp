using System;

namespace DebitCardNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstDebit = int.Parse(Console.ReadLine());
            int secondDebit = int.Parse(Console.ReadLine());
            int thirdDebit = int.Parse(Console.ReadLine());
            int forthDebit = int.Parse(Console.ReadLine());

            Console.WriteLine($"{firstDebit:D4} {secondDebit:D4} {thirdDebit:D4} {forthDebit:D4}");
        }
    }
}
