using System;
using System.Linq;

namespace _1.ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string reversedString = ReverseString(input);
            Console.WriteLine(reversedString);

        }

        static string ReverseString(string input)
        {
            return string.Join("",input.ToCharArray().Reverse());
        }
    }
}
