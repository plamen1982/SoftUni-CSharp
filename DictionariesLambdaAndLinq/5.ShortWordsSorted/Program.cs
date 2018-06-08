using System;
using System.Linq;

namespace _5.ShortWordsSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().ToLower().Split(new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] result = words.Where(x => x.Length < 5)
                  .OrderBy(x => x)
                  .Distinct()
                  .ToArray();
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
