using System;
using System.Text;

namespace _3.UnicodeCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            foreach (char c in input)
            {
                sb.AppendFormat("\\u{0:x4}", (uint)c);
            }

            Console.WriteLine(sb.ToString()); 
        }
    }
}
