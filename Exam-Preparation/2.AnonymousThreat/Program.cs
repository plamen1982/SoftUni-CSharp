using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input - test - OK
            //Merge method - test1 - OK, test2 - OK, test3 - OK, test4 - OK
            //Divide method - test
            //Result method - test

            List<string> words = Console.ReadLine().Split().ToList();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "3:1")
            {
                string[] tokens = input.Split();
                string command = tokens[0];
                if (command == "merge")
                {
                    int startIndex = int.Parse(tokens[1]);
                    int endIndex = int.Parse(tokens[2]);
                    startIndex = changeIndex(startIndex, words.Count);
                    endIndex = changeIndex(endIndex, words.Count);
                    Merge(words, startIndex, endIndex);
                }
                else if (command == "divide")
                {
                    int startIndex = int.Parse(tokens[1]);
                    int partitions = int.Parse(tokens[2]);
                    Divide(words, startIndex, partitions);
                }
            }
            Console.WriteLine(string.Join(" ", words));
        }
        static int changeIndex(int index, int wordsLength)
        {
            if (index < 0)
            {
                index = 0;
            }
            if (index >= wordsLength)
            {
                index = wordsLength - 1;
            }
            return index;
        }

        static void Merge(List<string> words, int startIndex, int endIndex)
        {
            string concatWord = string.Empty;
            for (int i = startIndex; i <= endIndex; i++)
            {    
                concatWord += words[i];
            }
            words.RemoveRange(startIndex, endIndex - startIndex + 1);
            words.Insert(startIndex, concatWord);
        }

        static void Divide(List<string> dataList, int startIndex, int partitions)
        {
            // 0    1    2    3      4
            //abcd efgh ijkl mnop qrstuvwxyza, divide 4 5 => qr st uv wx yza

            string elementToDivide = dataList[startIndex];
            int lengtPartitions = dataList[startIndex].Length / partitions;

            List<string> newDividedList = new List<string>();

            for (int i = 0; i < partitions; i++)
            {
                //if last partition
                if (i == partitions - 1)
                {
                    newDividedList.Add(elementToDivide.Substring(i * lengtPartitions));
                }
                else
                {
                    newDividedList.Add(elementToDivide.Substring(i * lengtPartitions, lengtPartitions));
                }
            }

            dataList.RemoveAt(startIndex);
            dataList.InsertRange(startIndex, newDividedList);

        }
    }
}
