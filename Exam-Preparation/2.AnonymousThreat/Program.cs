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

            List<string> dataList = Console.ReadLine().Split().ToList();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "3:1")
            {
                string[] tokens = input.Split();
                string command = tokens[0];
                if (command == "merge")
                {
                    int startIndex = int.Parse(tokens[1]);
                    int endIndex = int.Parse(tokens[2]);
                    Merge(dataList, startIndex, endIndex);
                }
                else if (command == "divide")
                {
                    int startIndex = int.Parse(tokens[1]);
                    int partitions = int.Parse(tokens[2]);
                    Divide(dataList, startIndex, partitions);
                }
            }
            Console.WriteLine(string.Join(" ", dataList));
        }

        static void Merge(List<string> dataList, int startIndex, int endIndex)
        {
            if (startIndex < 0)
            {
                startIndex = 0;
            }

            StringBuilder mergedResult = new StringBuilder();
            //0            1    
            //IvoJohnyTonyBony Mony merge 5 100


            if (startIndex >= dataList.Count)
            {
                startIndex = dataList.Count - 2;
                endIndex = dataList.Count - 1; 

            }

            int elementsToConnect = endIndex - startIndex + 1;

            if (endIndex > dataList.Count)
            {
                endIndex = endIndex - startIndex;
                elementsToConnect = endIndex - startIndex + 1;
            }

            if (elementsToConnect > dataList.Count)
            {
                return;
            }

            for (int i = startIndex; i <= endIndex; i++)
            {    //merge 4 10, ads adf jd jk ui fd fs
                //if dataList.Count = 2, startIndex = 3, endIndex = 4 => if start > count, startIndex = startIndex - dataList.Count + 1

                mergedResult.Append(dataList[i]);
            }
            dataList.RemoveRange(startIndex, elementsToConnect);
            dataList.Insert(startIndex, mergedResult.ToString());

        }

        static void Divide(List<string> dataList, int startIndex, int partitions)
        {
            // 0    1    2    3      4
            //abcd efgh ijkl mnop qrstuvwxyza, divide 4 5 => qr st uv wx yza
            if (startIndex < 0)
            {
                startIndex = 0;
            }
            if (startIndex >= dataList.Count)
            {
                startIndex = dataList.Count - 1;
            }
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
