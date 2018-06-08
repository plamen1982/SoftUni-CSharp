using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
           
            List<string> inputElements = Console.ReadLine().Split(' ').ToList();
            
            while (true)
            {
                string[] input = Console.ReadLine().Split(' ');

                if (input[0] == "3:1")
                {
                    break;
                }

                if (input[0] == "merge")
                {
                    int startIndex = int.Parse(input[1]);
                    int endIndex = int.Parse(input[2]);
                    mergeList(inputElements, startIndex, endIndex);
                }
                else if(input[0] == "divide")
                {
                    int startIndex = int.Parse(input[1]);
                    int numberOfParts = int.Parse(input[2]);
                    divideList(inputElements, startIndex, numberOfParts);
                }
            }
            Console.Write(string.Join(" ", inputElements));
        }

        static List<string> mergeList(List<string> inputString, int startIndex, int endIndex)
        {

            for (int i = startIndex; i < endIndex; i++)
            {
                if (startIndex + 1 >= inputString.Count)
                {
                    break;
                }

                inputString[startIndex] = inputString[startIndex] + inputString[startIndex + 1];
                inputString.RemoveAt(startIndex + 1);
            }
            return inputString;
        }

        static List<string> divideList(List<string> inputString, int startIndex, int numberOfParts)
        {

            string element = inputString[startIndex]; 
            int dividedPartsLength = element.Length / numberOfParts;
            int addedToTheLast = element.Length % numberOfParts;

            List<string> dividedString = new List<string>();
            string currentElement = "";

            for (int i = 0; i < element.Length; i += dividedPartsLength)
            {
                if (addedToTheLast == 0)
                {
                    for (int j = 0; j < dividedPartsLength; j++)
                    {
                        currentElement += element[i + j];

                    }
                    dividedString.Add(currentElement);
                    currentElement = "";
                }
                else
                {
                    if (element.Length - 1 == i + dividedPartsLength)
                    {
                        i += addedToTheLast;
                        for (int j = 0; j < dividedPartsLength + addedToTheLast; j++)
                        {
                            currentElement += element[i + j];

                        }
                        dividedString.Add(currentElement);
                        currentElement = "";
                    }
                    else
                    {
                        for (int j = 0; j < dividedPartsLength; j++)
                        {
                            currentElement += element[i + j];

                        }
                        dividedString.Add(currentElement);
                        currentElement = "";
                    }
                }
            }

            inputString.RemoveAt(startIndex);
            inputString.InsertRange(startIndex, dividedString);

            return inputString;
       

        }
    }
}
