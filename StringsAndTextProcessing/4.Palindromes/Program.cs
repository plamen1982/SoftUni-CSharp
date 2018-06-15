using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(",?!. ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            List<string> result = new List<string>();

            foreach (var word in text)
            {
                if (IsPalindrom(word))
                {
                    result.Add(word);
                }
            }
            Console.WriteLine(string.Join(", " , result.Distinct().OrderBy(x => x)));
        }

        static bool IsPalindrome(string word)
        {
            bool isPalindrom = false;
            for (int i = 0; i < word.Length / 2; i++)
            {
                if (word[i] != word[word.Length - 1 - i])
                {
                    return isPalindrom = false;
                }
            }
            return isPalindrom = true;
        }
    }
}
