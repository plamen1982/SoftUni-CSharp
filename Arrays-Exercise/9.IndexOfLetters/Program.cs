using System;
using System.Linq;

namespace _9.IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string letters = Console.ReadLine().ToLower();
            for (int i = 0; i < letters.Length; i++)
            {
                Console.WriteLine($"{letters[i]} -> {(int)letters[i] - 97}");
            }
        }
    }
}
