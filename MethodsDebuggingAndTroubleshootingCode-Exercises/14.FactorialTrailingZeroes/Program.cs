using System;
using System.Numerics;

namespace _14.FactorialTrailingZeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            BigInteger factorial = Factorial(number);
            Console.WriteLine(CountTrailingZeros(factorial));
        }

        static int CountTrailingZeros(BigInteger factorial)
        {
            string factorialString = factorial.ToString();
            int count = 0;

            for (int i = factorialString.Length - 1; i > 0; i--)
            {
                if (factorialString[i] == '0')
                {
                    count++;
                }
                else
                {
                    break;
                }
            }
            return count;
        }
    
        static BigInteger Factorial(int number)
        {
            BigInteger result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }

    }
}
