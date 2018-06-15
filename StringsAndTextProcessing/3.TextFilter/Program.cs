using System;
using System.Linq;
using System.Text;

namespace _3.TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {

            //string[] bannedWords = Console.ReadLine().Split(',', ' ', StringSplitOptions.RemoveEmptyEntries);
            //string[] bannedWords = Console.ReadLine().Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            /*
             * First Solution
            string[] bannedWords = Console.ReadLine().Split(',').Select(x => x.Trim()).ToArray();
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
        */

            //Second Solution

            string[] banList = Console.ReadLine()
                .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //textToCkeck is the text from Console.Readline(), the previous argument. banWord is every element from banList[] array
            string text = banList.Aggregate(Console.ReadLine(), (textToCheck, banWord) => textToCheck.Replace(banWord, new string('*', banWord.Length)));

            Console.WriteLine(text);
        }
        
    }
}
