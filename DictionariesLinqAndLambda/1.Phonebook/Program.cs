using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5.HandsOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> players = new Dictionary<string, List<string>>();

            while (true)
            {
                string[] tokens = Console.ReadLine().Split(':');

                string playerName = tokens[0];

                if (playerName == "JOKER")
                {
                    break;
                }


                string[] cards = tokens[1].Trim().Split(", ");



                if (players.ContainsKey(playerName))
                {
                    players[playerName].AddRange(cards);
                }
                else
                {
                    players.Add(playerName, new List<string>(cards));
                }

            }
            Dictionary<string, List<string>> results = new Dictionary<string, List<string>>();

            foreach (var player in players)
            {
                 results.Add(player.Key, player.Value.Distinct().ToList());
            }

            
            foreach (var result in results)
            {
                decimal sum = 0;
                foreach (var item in result.Value)
                {
                    sum += CalculateValue(item);
                }
                Console.WriteLine($"{result.Key}: {sum}");
            }

        }

        static decimal CalculateValue(string combination)
        {
            string firstElement = "" + combination[0];
            string secondElemnt = "" + combination[1];
            if (firstElement == "1")
            {
                firstElement = "" + combination[0] + combination[1];
                secondElemnt = "" + combination[2];

            }
            decimal firstInt = 0;
            decimal secondInt = 0;
            //2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K, A

            switch (firstElement)
            {
                case "2":
                    firstInt = 2;
                    break;
                case "3":
                    firstInt = 3;
                    break;
                case "4":
                    firstInt = 4;
                    break;
                case "5":
                    firstInt = 5;
                    break;
                case "6":
                    firstInt = 6;
                    break;
                case "7":
                    firstInt = 7;
                    break;
                case "8":
                    firstInt = 8;
                    break;
                case "9":
                    firstInt = 9;
                    break;
                case "10":
                    firstInt = 10;
                    break;
                case "J":
                    firstInt = 11;
                    break;
                case "Q":
                    firstInt = 12;
                    break;
                case "K":
                    firstInt = 13;
                    break;
                case "A":
                    firstInt = 14;
                    break;
            }

            //S, H, D, C
            switch (secondElemnt)
            {
                case "S":
                    secondInt = 4;
                    break;
                case "H":
                    secondInt = 3;
                    break;
                case "D":
                    secondInt = 2;
                    break;
                case "C":
                    secondInt = 1;
                    break;
            }
            return firstInt * secondInt;
        }



    }
}