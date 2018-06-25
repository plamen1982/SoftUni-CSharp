/*
using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.CommandInterpreter
{
    class Program
    {
        static List<string> ReternRangedList(int startIndex, int endIndex, List<string> inputList)
        {
            List<string> RangedList = new List<string>();

            for (int i = startIndex; i < startIndex + endIndex; i++)
            {
                RangedList.Add(inputList[i]);
            }
            return RangedList;
        }

        static List<string> ReternRollRightList(int count, List<string> inputList)
        {

            for (int i = 0; i < count; i++)
            {

                string temp = inputList[inputList.Count - 1];
                inputList.Insert(0, temp);
                inputList.RemoveAt(inputList.Count - 1);
            }
            return inputList;
        }

        static List<string> ReternRollLeftList(int count, List<string> inputList)
        {

            for (int i = 0; i < count; i++)
            {

                string temp = inputList[0];
                inputList.Add(temp);
                inputList.RemoveAt(0);
            }
            return inputList;
        }

        static bool CheckIndexes(int startIndex, int count, List<string> inputList)
        {
            bool isValidIndex = true;
            if (startIndex < 0 || startIndex >= inputList.Count || count < 0 || count >= inputList.Count || startIndex + count >= inputList.Count)
            {
                isValidIndex = false;
                return isValidIndex;
            }

            return isValidIndex;
        }

        static bool CheckIndexes(int count, List<string> inputList)
        {
            bool isValidIndex = true;
            if (count >= inputList.Count || count < 0)
            {
                isValidIndex = false;
                return isValidIndex;
            }

            return isValidIndex;
        }

        private static void PrintResult(List<string> inputList)
        {
            Console.WriteLine("Invalid input parameters.");
            Console.WriteLine("[" + string.Join(", ", inputList) + "]");
        }

        static void Main(string[] args)
        {

            List<string> inputList = Console.ReadLine().Split().ToList();
            string line = string.Empty;

            while ((line = Console.ReadLine()) != "end")
            {
                string[] tokens = line.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string command = tokens[0];
                if (command == "reverse")
                {
                    int startIndex = int.Parse(tokens[2]);
                    int count = int.Parse(tokens[4]);
                    if (CheckIndexes(startIndex, count, inputList))
                    {
                        List<string> revesedElements = ReternRangedList(startIndex, count, inputList);
                        revesedElements.Reverse();
                        inputList.RemoveRange(startIndex, count);
                        inputList.InsertRange(startIndex, revesedElements);
                    }
                    else
                    {
                        PrintResult(inputList);
                    }

                }

                if (command == "sort")
                {
                    int startIndex = int.Parse(tokens[2]);
                    int count = int.Parse(tokens[4]);
                    if (CheckIndexes(startIndex, count, inputList))
                    {
                        List<string> sortedElements = ReternRangedList(startIndex, count, inputList);
                        sortedElements.Sort();
                        inputList.RemoveRange(startIndex, count);
                        inputList.InsertRange(startIndex, sortedElements);
                    }
                    else
                    {
                        PrintResult(inputList);
                    }
                }

                if (command == "rollLeft")
                {
                    int count = int.Parse(tokens[1]);
                    if (CheckIndexes(count, inputList))
                    {
                        ReternRollLeftList(count, inputList);
                    }
                    else
                    {
                        PrintResult(inputList);
                    }
                }

                if (command == "rollRight")
                {
                    int count = int.Parse(tokens[1]);
                    if (CheckIndexes(count, inputList))
                    {
                        ReternRollRightList(count, inputList);
                    }
                    else
                    {
                        PrintResult(inputList);
                    }
                }

            }
        }
    }
}
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Command_Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataToChange = Console.ReadLine().Split(new char[] { ' '},StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> theNewStr = new List<string>();
 
            string input = Console.ReadLine();
 
            while(input != "end")
            {
                string[] inputTokens = input.Split(' ').ToArray();
 

                    if(inputTokens[0] =="reverse")
                    {
                        int start =int.Parse(inputTokens[2]);
                        int count = int.Parse(inputTokens[4]);
 
                        if(start < 0 || start >= dataToChange.Count || (start + count) > dataToChange.Count || count < 0)
                        {
                            Console.WriteLine("Invalid input parameters.");                          
                        }                        
                        else
                        {
                            dataToChange.Reverse(start, count);
                        }                        
                        //Console.WriteLine(string.Join(" ",dataToChange));
                    }
                    else if(inputTokens[0] == "sort")
                    {
                        int start = int.Parse(inputTokens[2]);
                        int count = int.Parse(inputTokens[4]);
 
                        if (start < 0 || start >= dataToChange.Count || (start + count) > dataToChange.Count || count < 0)
                        {
                            Console.WriteLine("Invalid input parameters.");                            
                        }
                        else
                        {
                            theNewStr = dataToChange.Skip(start).Take(count).OrderBy(str => str).ToList();
                            dataToChange.RemoveRange(start, count);
                            dataToChange.InsertRange(start, theNewStr);
                        }                        
                    }
                

                    if(inputTokens[0] == "rollLeft")
                    {
                        int count = int.Parse(inputTokens[1]);
                        count = count % dataToChange.Count;

                    for (int i = 0; i < count; i++)
                            {
                                dataToChange.Insert(dataToChange.Count, dataToChange[0]);
                                dataToChange.RemoveAt(0);
                            }
                                            
                       // Console.WriteLine(string.Join(" ",dataToChange));
                    }
                    else if(inputTokens[0] == "rollRight")
                    {
                        int count = int.Parse(inputTokens[1]);
                        count = count % dataToChange.Count;

                        for (int i = 0; i < count; i++)
                        {
                            dataToChange.Insert(0, dataToChange[dataToChange.Count - 1]);
                            dataToChange.RemoveAt(dataToChange.Count - 1);
                        }
                                             
                       // Console.WriteLine(string.Join(" ", dataToChange));
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"[{string.Join(", ", dataToChange)}]");
        }
    }
}
