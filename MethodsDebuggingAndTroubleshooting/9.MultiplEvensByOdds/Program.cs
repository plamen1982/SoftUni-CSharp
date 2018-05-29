using System;

namespace _9.MultiplEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            Console.WriteLine(GetMultipleOfEvensAndOdds(number));

        }
        static int GetMultipleOfEvensAndOdds(int number)
        {
            int lastDigit;
            int sumEven = 0;
            int sumOdd = 0;

            while (number > 0)
            {
                lastDigit = number % 10;
                number /= 10;
                if (lastDigit % 2 == 0)
                {
                    sumEven += lastDigit;
                }
                else
                {
                    sumOdd += lastDigit;
                }
            }
            return sumEven * sumOdd;
        }
    }
}
