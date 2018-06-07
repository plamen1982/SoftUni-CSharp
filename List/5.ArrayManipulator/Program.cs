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
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            numbers[i] = numbers[i] + numbers[i + 1];
                            numbers.RemoveAt(i + 1);
                        }
                    }
                    else
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (i == numbers.Count - 1)
                            {
                                break;
                            } 

                            numbers[i] = numbers[i] + numbers[i + 1];
                            numbers.RemoveAt(i + 1);
                        }
                    }

                }

                //print
                else
                {
                    Console.WriteLine("[" + string.Join(", ", numbers) + "]");
                    break;
                }
            }

             List<int> shiftList(List<int> list, int numberPositionsToBeShift)
            {
                List<int> shiftedList = new List<int>(list);
                int firstElement = list[0];
                for (int i = 0; i < numberPositionsToBeShift; i++)
                {
                    list.Add(list[0]);
                    list.RemoveAt(0);

                }
                list.IndexOf(list.Count - 1, firstElement);
                return list;
            }
        }
    }
}
