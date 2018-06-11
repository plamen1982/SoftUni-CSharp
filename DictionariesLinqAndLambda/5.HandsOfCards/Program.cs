using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.HandsOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> users = new Dictionary<string, List<string>>();
            while (true)
            {
                string[] tokens = Console.ReadLine().Split(":").ToArray();
                string name = tokens[0];

                if (name == "JOKER")
                {
                    break;
                }
                List<string> playingCards = tokens[1].Trim().Split(", ").ToList();


                if (users.ContainsKey(name) == false)
                {
                    users[name] = new List<string>();
                }
                    users[name].AddRange(playingCards);
            }

            Dictionary<string, int> cards = new Dictionary<string, int>();

            // string[] cardsToSwitch = tokens[1].Trim().Split(", ").ToArray();

            for (int i = 2; i <= 9; i++)
            {
                cards.Add(i.ToString(), i);
            }

            cards.Add("1", 10);
            cards.Add("J", 11);
            cards.Add("Q", 12);
            cards.Add("K", 13);
            cards.Add("A", 14);
            cards.Add("S", 4);
            cards.Add("H", 3);
            cards.Add("D", 2);
            cards.Add("C", 1);


            foreach (var user in users)
            {
                List<string> distinctCards = user.Value.Distinct().ToList();

                int sum = 0;

                foreach (var card in distinctCards)
                {
                    Dictionary<string, string> results = ReturnCardsToCalculate(card);
                    string typeCard = results.First().Key;
                    string typeColor = results.First().Value;

                    sum += cards[typeCard] * cards[typeColor];
                }
                Console.WriteLine($"{user.Key}: {sum}");
                sum = 0;
            }
        }
        static Dictionary<string, string> ReturnCardsToCalculate(string card)
        {

            string typeCard;
            string typeColor;
            Dictionary<string, string> result = new Dictionary<string, string>();

            if (card[0] == '1')
            {
                 typeCard = card[0].ToString();
                 typeColor = card[2].ToString();
            }
            else
            {
                 typeCard = card[0].ToString();
                 typeColor = card[1].ToString();
            }


            result[typeCard] = typeColor;
            return result;
        }


        //Pesho: 2C, 4H, 9H, AS, QS
        /*
        static decimal CalculateValue(string combination)
        {
            string firstElement = "" + combination[1];
            string secondElemnt = "" + combination[2];
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
        */

    }
}
