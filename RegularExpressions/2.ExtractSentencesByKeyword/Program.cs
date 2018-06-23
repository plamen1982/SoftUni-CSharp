using System;
using System.Text.RegularExpressions;

namespace _2.ExtractSentencesByKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string text = Console.ReadLine();
            string patter = $@"\b[^?!.]*?\b({word})\b[^?!.]*";
            Regex rgx = new Regex(patter);

            foreach (Match sentence in rgx.Matches(text))
            {
                Console.WriteLine(sentence); 
            }
        }
    }
}
