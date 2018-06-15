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
            List<string> palindromes = new List<string>();

            //2nd Soluton
            palindromes = text
                .Where(IsPalindrome)
                .OrderBy(x => x)
                .Distinct()
                .ToList();
            /* 1st Solution
            foreach (var word in text)
            {
                if (IsPalindrome(word))
                {
                    palindromes.Add(word);
                }
            }
            */
            Console.WriteLine(string.Join(", " , palindromes.Distinct().OrderBy(x => x)));
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
