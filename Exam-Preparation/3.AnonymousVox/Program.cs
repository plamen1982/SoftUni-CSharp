using System;

namespace _3.AnonymousVox
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([A-Za-z]+)(?<placeholder>.+)(\1)";
            string text = Console.ReadLine();
            Regex rgx = new Regex(pattern);
            string[] placeholders = Console.ReadLine().Split(new char[] { '{', '}' }, StringSplitOptions.RemoveEmptyEntries);
            //Console.WriteLine(text);
            //Console.WriteLine(string.Join(",", placeholders));
            MatchCollection matches = rgx.Matches(text);
            //Console.WriteLine(string.Join(",", matches));
            for (int i = 0; i < matches.Count; i++)
            {
                //There may be more values than placeholders or more placeholders than values.

                string placeholder = string.Empty;
                placeholder = matches[i].Groups["placeholder"].Value;
                int startIndex = text.IndexOf(placeholder);
                //Console.WriteLine(startIndex);
                //Console.WriteLine(placeholder);
                //Console.WriteLine(placeholders[i]);
                text = text.Remove(startIndex, placeholder.Length);
                text = text.Insert(startIndex, placeholders[i]);
            }
            Console.WriteLine(text);
        }
    }
}
