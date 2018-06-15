using System;
using System.Linq;

namespace _4.CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split()
                .OrderByDescending(c => c.Length)
                .ToArray();

            string string1 = input[0];
            string string2 = input[1];

            long sum = 0;

            for (int j = 0; j < string2.Length; j++)
            {
                sum += string1[j] * string2[j];
            }

            for (int i = string2.Length; i < string1.Length; i++)
            {
                sum += string1[i];
            }

            Console.WriteLine(sum); 
        }
    }
}
