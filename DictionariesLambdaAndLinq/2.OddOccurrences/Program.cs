using System;
using System.Collections.Generic;

namespace _2.OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputString = Console.ReadLine().ToLower().Split(' ');

            var countElements = new Dictionary<string, int>();

            foreach (var item in inputString)
            {
                if (!countElements.ContainsKey(item))
                {
                    countElements.Add(item, 1);
                }
                else
                {                   
                    countElements[item]++;
                }
            }

            List<string> result = new List<string>();
            foreach (var item in countElements)
            {
                if (item.Value % 2 != 0)
                {
                    result.Add(item.Key);
                }
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
