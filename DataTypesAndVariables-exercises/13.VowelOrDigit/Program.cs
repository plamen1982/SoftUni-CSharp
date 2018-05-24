using System;
using System.Linq;

namespace _13.VowelOrDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            /* First Solution
            string input = Console.ReadLine().ToUpper();

            int resultInt;

            string [] vowels = { "A", "E", "I", "O", "U", "Y"};
                                //65, 69, 73, 79, 89, 97, 
            if (vowels.Contains(input))
            {
                Console.WriteLine("vowel");
            }
            else if (int.TryParse(input, out resultInt))
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
            */

            /* Second Solution */

            char input = char.Parse(Console.ReadLine());

            char[] vowelsArray = new char[] { 'a', 'e', 'i', 'o', 'u', 'y' };

            if (vowelsArray.Contains(char.ToLower(input)))
            {
                Console.WriteLine("vowel");
            }
            else if(char.IsDigit(input))
            {
                Console.WriteLine("digit");
            }

            else 
            {
                Console.WriteLine("other");
            }

        }
    }
}
