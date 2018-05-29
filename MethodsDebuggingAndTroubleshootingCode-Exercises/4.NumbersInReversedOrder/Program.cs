using System;

namespace _4.NumbersInReversedOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            Console.WriteLine(ReveredNumber(number));
        }

        static string ReveredNumber(string number)
        {
            string result = "";
            for (int i = number.Length - 1; i >= 0; i--)
            {
                result += number[i];
            }
            return result;
        }

    }
}
