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
            //Console.WriteLine($"{(char)(80)}{(char)(101)}{(char)(115)}{(char)(104)}{(char)(111)}");
            StringBuilder theWholeString = new StringBuilder();
            while ((line = Console.ReadLine()) != "Visual Studio crash")
            {
                theWholeString.Append(" " + line);
            }
            
                //you will be receiving lines from the memory view in 2 - byte integer unsigned display.Each line consists of exactly 22 integers, 
                //separated by whitespace.You should find every string in the whole input and print them on the console.
                //Every string starts with -> "32656 19759 32763"
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
