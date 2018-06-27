using System;
using System.Text.RegularExpressions;

namespace _03.Snowflake
{
    class Program
    {
        static void Main(string[] args)
        {

            string pattern = "^([^A-Za-z0-9]+)\n([0-9_]+)\n([^A-Za-z0 - 9]+)([0-9_]+)(?<core>[A-Za-z]+)([0-9_]+)([^A-Za-z0 - 9]+)\n([0-9_]+)\n([^A-Za-z0-9]+)$";
            Regex rgx = new Regex(pattern);
            string text = string.Empty;
            for (int i = 0; i < 5; i++)
            {
                text += Console.ReadLine() + "\n";

            }
            if (rgx.IsMatch(text))
            {
                Console.WriteLine("Valid");
                string validCore = rgx.Match(text).Groups["core"].Value;
                Console.WriteLine(validCore.Length); 
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
