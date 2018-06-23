using System;
using System.Text.RegularExpressions;

namespace _1.ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([A-Za-z0-9]+)([_.-]\w*)*@([A-Za-z.-]+)+\b";
            Regex rgxEmail = new Regex(pattern);
            string inputText = Console.ReadLine();

            foreach (Match emailMatch in rgxEmail.Matches(inputText))
            {
                Console.WriteLine(emailMatch.Value);
            }
        }
    }
}
