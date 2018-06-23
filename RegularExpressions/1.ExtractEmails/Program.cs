using System;
using System.Text.RegularExpressions;

namespace _1.ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            //string pattern = @"(\b[\w.-]+@[a-zA-z-]+)(\.[a-zA-z-]+)+";
            string pattern = @"(?:[A-Za-z0-9]+)([_.-]\w*)*@([A-Za-z_.-]+)+\b";
            Regex rgxEmail = new Regex(pattern);
            string inputText = Console.ReadLine();

            foreach (Match emailMatch in rgxEmail.Matches(inputText))
            {
                Console.WriteLine(emailMatch.Value);
            }
        }
    }
}
