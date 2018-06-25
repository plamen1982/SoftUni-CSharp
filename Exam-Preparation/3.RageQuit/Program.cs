using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _3.RageQuit
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"(\D+)(\d+)";
            Regex rgx = new Regex(pattern);
            StringBuilder result = new StringBuilder();

            foreach (Match match in rgx.Matches(text))
            {
                for (int i = 0; i < int.Parse(match.Groups[2].Value); i++)
                {
                    result.Append(match.Groups[1].Value.ToUpper());
                }
            }

            long count = result.ToString().Distinct().Count();
            Console.WriteLine($"Unique symbols used: {count}");
            Console.WriteLine(result.ToString());

        }
    }
}
