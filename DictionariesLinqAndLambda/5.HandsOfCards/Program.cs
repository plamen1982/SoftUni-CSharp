using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.HandsOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> users = new Dictionary<string, decimal>();
            while (true)
            {

                string[] tokens = Console.ReadLine().Split(":,".ToCharArray()).Distinct().ToArray();
                string name = tokens[0];
                if (name == "JOKER")
                {
                    break;
                }
                for (int i = 1; i < tokens.Length; i++)
                {
                    if (users.ContainsKey(name))
                    {
                        users[name] += CalculateValue(tokens[i]);
                    }
                    else
                    {
                        users.Add(name, CalculateValue(tokens[i]));
                    }
                }

            }
            foreach (var user in users)
            {
                Console.WriteLine($"{user.Key}: {user.Value}");
            }
        }
        //Pesho: 2C, 4H, 9H, AS, QS

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

    }
}
