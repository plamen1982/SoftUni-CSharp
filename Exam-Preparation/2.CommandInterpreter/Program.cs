using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.CommandInterpreter
{
    class Program
    {
        private static void Print(List<string> inputList)
        {
            Console.WriteLine("Invalid input parameters.");
            Console.Write($"[{string.Join(", ", inputList)}]");
        }
        static bool IsIndexValid(int startIndex, int count, List<string> inputList)
        {
            bool isValid = true;
            if (startIndex < 0 || startIndex >= inputList.Count || count < 0 || count >= inputList.Count || (startIndex + count) >= inputList.Count)
            {
                isValid = false;
            }
            return isValid;
        }

        static bool IsIndexValid(int count, List<string> inputList)
        {
            bool isValid = true;
            if (count < 0 || count >= inputList.Count)
            {
                isValid = false;
            }
            return isValid;
        }

        static void Main(string[] args)
        {
            
            List<string> inputList = Console.ReadLine().Split().ToList();
            string line = string.Empty;

            while ((line = Console.ReadLine()) != "end")
            {
                string[] tokens = line.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();

                string command = tokens[0];
                if (command == "reverse")
                {
                    int startIndex = int.Parse(tokens[2]);
                    int count = int.Parse(tokens[4]);

                    if (IsIndexValid(startIndex, count, inputList))
                    {
                        inputList.Reverse(startIndex, count);
                    }
                    else
                    {
                        Print(inputList);
                    }
                }

                if (command == "sort")
                {
                    int startIndex = int.Parse(tokens[2]);
                    int count = int.Parse(tokens[4]);

                    if (IsIndexValid(startIndex, count, inputList))
                    {
                        
                    }
                    else
                    {
                        Print(inputList);
                    }
                }

                if (command == "rollLeft")
                {
                    int count = int.Parse(tokens[1]);
                    if (IsIndexValid(count, inputList))
                    {
                        for (int i = 0; i < count; i++)
                        {
                            // 1 2 3 -> 1 2 3 1
                            inputList.Add(inputList[0]);
                            inputList.RemoveAt(0);
                        }
                    }
                    else
                    {
                        Print(inputList);
                    }
                }

                if (command == "rollRight")
                {
                    int count = int.Parse(tokens[1]);

                    if (IsIndexValid(count, inputList))
                    {
                        // 1 2 3 -> 3 1 2 3 
                        for (int i = 0; i < count; i++)
                        {
                            inputList.Insert(0, inputList[inputList.Count - 1]);
                            inputList.RemoveAt(inputList.Count - 1);
                        }
                    }
                    else
                    {
                        Print(inputList);
                    }
                }
            }
        }
    }
}

/*
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
            var dataToChange = Console.ReadLine().Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries).ToList();
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
*/