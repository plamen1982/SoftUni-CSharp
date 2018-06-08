using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.Snowmen
{
    class Program
    {
        static void Main(string[] args)
        {


            List<int> inputNumbers = Console.ReadLine().Split().Select(x => int.Parse(x)).ToList();
            List<int> indexesToRemove = new List<int>();
            while (true)
            {
                if (inputNumbers.Count == 1)
                {
                    break;
                }
                int i = 0;
                for (i = 0; i < inputNumbers.Count; i++)
                {
                    int index = inputNumbers[i];
                    int attackerIndex = i;
                    int target;
                    int attacker;
                    int targetIndex;

                    if (index >= inputNumbers.Count)
                    {
                        targetIndex = index % inputNumbers.Count;
                        target = inputNumbers[targetIndex];
                        attacker = inputNumbers[attackerIndex];
                    }
                    else
                    {
                        targetIndex = index;
                        target = inputNumbers[index];
                        attacker = inputNumbers[attackerIndex];
                    }

                    int diff = Math.Abs(attackerIndex - targetIndex);
                    if (diff % 2 == 0 && diff != 0)
                    {
                        Console.WriteLine($"{attackerIndex} x {targetIndex} -> {attackerIndex} wins");
                        indexesToRemove.Add(targetIndex);
                    }
                    else if (diff % 2 != 0)
                    {
                        Console.WriteLine($"{attackerIndex} x {targetIndex} -> {targetIndex} wins");
                        indexesToRemove.Add(attackerIndex);
                    }
                    else if(diff == 0)
                    {
                        Console.WriteLine($"{attackerIndex} performed harakiri");
                        indexesToRemove.Add(attackerIndex);
                    }
                }
                foreach (var index in indexesToRemove.OrderByDescending(x => x).Distinct())
                {
                    inputNumbers.RemoveAt(index);
                }
                indexesToRemove.Clear();
            }
        }
    }
}
