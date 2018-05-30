using System;

namespace _12.MasterNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            long limit = long.Parse(Console.ReadLine());

            for (long i = 0; i < limit; i++)
            {
                if (isSymmetric(i))
                {
                    if (isSumDivisibleBySeven(i))
                    {
                        if (isHoldEvenDigit(i))
                        {
                            Console.WriteLine(i);
                        }
                    }
                }
               
            }
        }

        static bool isSymmetric(long number)
        {
            string stringNumber = number.ToString();
            if (stringNumber.Length == 1)
            {
                return false;
            }
                string leftSide = "";
                for (int i = 0; i < stringNumber.Length / 2; i++)
                {
                    leftSide += stringNumber[i];
                }
            string rightSide = "";

            if (stringNumber.Length % 2 == 0)
            {
                for (int j = stringNumber.Length - 1; j >= stringNumber.Length / 2; j--)
                {
                    rightSide += stringNumber[j];
                }
            }
            else
            {
                for (int j = stringNumber.Length - 1; j > stringNumber.Length / 2; j--)
                {
                    rightSide += stringNumber[j];
                }
            }


            return leftSide.Equals(rightSide);
            }

        static bool isSumDivisibleBySeven(long number)
        {
            string stringNumber = number.ToString();
            long sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            if (sum % 7 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool isHoldEvenDigit(long number)
        {
            bool result = false;
            long lastDigit = 0;
            while (number > 0)
            {
                lastDigit = number % 10;
                number /= 10;

                if (lastDigit % 2 == 0)
                {
                    return true;
                }
            }
            return result;
        }

    }
 }

