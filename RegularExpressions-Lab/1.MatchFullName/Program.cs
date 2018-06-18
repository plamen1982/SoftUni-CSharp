using System;
using System.Text.RegularExpressions;

namespace _1.MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[A-Z][a-z]+\s[A-Z][a-z]+\b";
            Regex regex = new Regex(pattern);
            string names = Console.ReadLine();
            foreach (Match match in regex.Matches(names))
            {
                Console.Write(match.Value + " ");
            }
        }
    }
}
