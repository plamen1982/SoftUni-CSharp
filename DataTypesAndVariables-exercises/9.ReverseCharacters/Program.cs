using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.ReverseCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            char third = char.Parse(Console.ReadLine());

            string word = "" + first + second + third;

            for (int i = word.Length - 1; i >= 0 ; i--)
            {
                Console.Write(word[i]); 
            }
        }
    }
}
