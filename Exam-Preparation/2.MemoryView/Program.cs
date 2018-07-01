using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _2.MemoryView
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = string.Empty;

            StringBuilder theWholeString = new StringBuilder();
            while ((line = Console.ReadLine()) != "Visual Studio crash")
            {
                theWholeString.Append(" " + line);
            }
            
                string patternNumberDigits = @"(32656\s19759\s32763\s0\s(\d)\s0\s)+";
                Regex rgx = new Regex(patternNumberDigits);
                List<string> allNumbers = theWholeString.ToString().Split().ToList();

                foreach (Match item in rgx.Matches(theWholeString.ToString()))
                {
                    string numberDigits = item.Groups[2].ToString();
                    string fullMatch = item.Groups[0].ToString();
                    int n = int.Parse(numberDigits);
                    int startIndex = allNumbers.IndexOf("32763") + 4;
                    List<int> result = new List<int>();
                    for (int i = startIndex; i < startIndex + n; i++)
                    {
                        result.Add(int.Parse(allNumbers[i]));
                    }
                    if (allNumbers.Count > 22)
                    {
                        allNumbers.RemoveRange(0, 22);
                    }
                    PrintTheResult(result);
                    result.Clear();
                }
        }

        private static void PrintTheResult(List<int> resultsElements)
        {
            for (int i = 0; i < resultsElements.Count; i++)
            {
                if (i == resultsElements.Count - 1)
                {
                    Console.WriteLine((char)resultsElements[i]);
                }
                else
                {
                    Console.Write((char)resultsElements[i]);
                }
            }   
        }
    }
}
