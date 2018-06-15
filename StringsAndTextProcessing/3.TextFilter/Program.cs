using System;
using System.Text;

namespace _3.TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(',', ' ', StringSplitOptions.RemoveEmptyEntries);

            
            //string[] bannedWords = Console.ReadLine().Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            string textToBeChecked = Console.ReadLine();
            for (int i = 0; i < bannedWords.Length; i++)
            {
                textToBeChecked = textToBeChecked.Replace(bannedWords[i], Repeat("*", bannedWords[i].Length));
            }
            Console.WriteLine(textToBeChecked);
        }

        static string Repeat(string word, int timesToBeRepeated)
        {
            string result = string.Empty;
            for (int i = 0; i < timesToBeRepeated; i++)
            {
                result += word;
            }

            return result;
        }
    }
}
