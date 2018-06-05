using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            while (true)
            {
                string[] lines = Console.ReadLine().Split();

                if ("Odd" == lines[0])
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 != 0)
                        {
                            Console.Write($"{numbers[i]} ");
                        }
                    }
                    break;
                }

                if ("Even" == lines[0])
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 == 0)
                        {
                            Console.Write($"{numbers[i]} ");
                        }
                    }
                    break;
                }
                    switch (lines[0])
                {
                    case "Delete":
                        numbers.RemoveAll(n => n == int.Parse(lines[1]));
                        break;

                    case "Insert":
                        numbers.Insert(int.Parse(lines[2]), int.Parse(lines[1]));
                        break;

                }
                
            }
        }
    }
}
