using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.Snowmen
{
    class Program
    {


        static void Main(string[] args)
        {
            //the snow man - which are indexed from 0 – sequence.length – 1. - OK!
            List<int> listOfNumbers = Console.ReadLine().Split().Select(x => int.Parse(x)).ToList();
            List<int> loserList = new List<int>();

            //The process must be repeated until there is 1 snowman left in the sequence. - OK!
            while (listOfNumbers.Count != 1)
            {

                //you must traverse the elements, from the first till the last. - OK! 
                for (int index = 0; index < listOfNumbers.Count; index++)
                {

                    //if the loserList is bigger that the listOfNumbers, exist the loop so you can remove the losers from the listOfNumbers
                    if (listOfNumbers.Count == loserList.Count + 1)
                    {
                        break;
                    }
                    //if current attacker is already a loser or his made a harahiri, continue with the other attackers
                    if (loserList.Contains(index))
                    {
                        continue;
                    }
                    //If the integer value is greater than the length of the sequence, divide it modulo (%) by the length - OK!
                    //14 3 2 1 0 - Each element is an attacker index and its integer value is its target index - OK!

                    int attackerIndex = index;
                    //check
                    int targetIndex = listOfNumbers[attackerIndex] % listOfNumbers.Count;

                    //When you extract the attacker index and the target index, you must calculate the AbsolutE value of the difference between them.  - OK!
                    int absoluteDifference = Math.Abs(attackerIndex - targetIndex);

                    //If the difference is an even number, the attacker wins. - OK!
                    if (absoluteDifference % 2 == 0 && absoluteDifference != 0)
                    {
                        //attackers win
                        loserList.Add(targetIndex);
                        loserList = loserList.Distinct().ToList();
                        Console.WriteLine($"{attackerIndex} x {targetIndex} -> {attackerIndex} wins");
                    }
                    //if the difference is an odd number, the target wins. - OK!
                     if (absoluteDifference % 2 != 0)
                    {
                        //target wins
                        loserList.Add(attackerIndex);
                        loserList = loserList.Distinct().ToList();
                        Console.WriteLine($"{attackerIndex} x {targetIndex} -> {targetIndex} wins");
                    }
                    //If the attacker and the target are equal(they are the same indexes), that means that snowman suicides. - OK!
                    //If an element loses a battle or suicides, it should NOT be able to attack. It can still be a target though.
                    if (absoluteDifference == 0)
                    {
                        //suicides
                        loserList.Add(attackerIndex);
                        loserList = loserList.Distinct().ToList();
                        Console.WriteLine($"{attackerIndex} performed harakiri");

                    }

                }

                //When you finish traversing the whole sequence, you must remove all elements that have lost or suicided, and then you must start over.
                //For each attacker and target, you must print “{ attacker}
                foreach (var loser in loserList.OrderByDescending(x => x).Distinct())
                {
                    listOfNumbers.RemoveAt(loser);
                }
                loserList.Clear();
            }
        }
    }
}
