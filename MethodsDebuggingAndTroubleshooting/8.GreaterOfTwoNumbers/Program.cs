using System;

namespace _8.GreaterOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeData = Console.ReadLine();
            string first = Console.ReadLine();
            string second = Console.ReadLine();

            switch (typeData)
            {
                case "int":
                    Console.WriteLine(GreaterOfTwo(int.Parse(first), int.Parse(second)));
                    break;
                case "char":
                    Console.WriteLine(GreaterOfTwo(char.Parse(first), char.Parse(second)));
                    break;
                case "string":
                    Console.WriteLine(GreaterOfTwo(first, second));
                    break;
            }
            
        }
        static int GreaterOfTwo(int first, int second)
        {
            if (first > second)
            {
                return first;
            }
            else if (second > first)
            {
                return second;
            }
            else
            {
                return first;
            }
        }

        static char GreaterOfTwo(char first, char second)
        {
            if (first > second)
            {
                return first;
            }
            else if (second > first)
            {
                return second;
            }
            else
            {
                return first;
            }
        }

        static string GreaterOfTwo(string first, string second)
        {
            if (String.Compare(first, second) >= 0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }

    }
}
