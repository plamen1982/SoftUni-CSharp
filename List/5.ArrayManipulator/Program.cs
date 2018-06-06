using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
             List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            while (true)
            {
                string[] commandsArrgs = Console.ReadLine().Split(" ").ToArray();
                string command = commandsArrgs[0];

                if (command == "add")
                {

                    int element = int.Parse(commandsArrgs[2]);
                    numbers.Insert(int.Parse(commandsArrgs[1]), element);

                }
                else if (commandsArrgs[0] == "addMany")
                {
                    List<int> elementsToInsert = new List<int>();

                    for (int i = 2; i < commandsArrgs.Length; i++)
                    {
                        elementsToInsert.Add(int.Parse(commandsArrgs[i]));
                    }

                    numbers.InsertRange(int.Parse(commandsArrgs[1]), elementsToInsert);

                }
                else if (command == "contains")
                {

                    if (!numbers.Contains(int.Parse(commandsArrgs[1])))
                    {
                        Console.WriteLine(-1);
                    }
                    else
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers.Contains(int.Parse(commandsArrgs[1])))
                            {
                                Console.WriteLine(i);
                                break;
                            }
                        }
                    }
                }
                else if (command == "remove")
                {
                    numbers.RemoveAt(int.Parse(commandsArrgs[1]));
                }
                else if (command == "shift")
                {
                    shiftList(numbers, int.Parse(commandsArrgs[1]));
                }
                else if (command == "sumPairs")
                {
                    List<int> summedList = new List<int>();

                    if (numbers.Count % 2 == 0)
                    {
                        for (int i = 0; i < numbers.Count; i += 2)
                        {
                            summedList.Add(numbers[i] + numbers[i + 1]);
                        }

                    }
                    else
                    {
                        for (int i = 0; i < numbers.Count; i += 2)
                        {
                            if (i == numbers.Count - 1)
                            {
                                summedList.Add(numbers[i]);
                                break;
                            }
                            summedList.Add(numbers[i] + numbers[i + 1]);
                        }
                    }

                    int diff = numbers.Count - summedList.Count;
                    numbers.RemoveRange(0, diff);
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        numbers[i] = summedList[i]; 
                    }
                }

                //print
                else
                {
                    Console.Write("[");
                    for (int i = 0; i < numbers.Count - 1; i++)
                    {
                        Console.Write($"{numbers[i]}, ");

                    }
                    Console.Write($"{numbers[numbers.Count - 1]}]");

                    break;
                }
            }

             List<int> shiftList(List<int> list, int numberPositionsToBeShift)
            {
                List<int> shiftedList = new List<int>(list);

                for (int i = 0; i < numberPositionsToBeShift; i++)
                {
                    int firstNumber = list[0];
                    int lastNumber = list[list.Count - 1];

                    for (int j = 0; j < list.Count; j++)
                    {
                        if (j == list.Count - 1)
                        {
                            shiftedList[list.Count - 1] = firstNumber;
                            break;
                        }
                        shiftedList[j] = list[j + 1];

                    }
                }
                for (int k = 0; k < list.Count; k++)
                {
                    list[k] = shiftedList[k];
                }
                return list;    
            }
        }
    }
}
