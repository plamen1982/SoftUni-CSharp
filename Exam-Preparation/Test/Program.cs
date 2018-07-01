//partedno

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> names = new List<string>() { "Paul", "Rachel", "Simon", "Bentley", "Angel", "Junior", "Poulinio", "Maradona" };
            List<string> friends = new List<string>() { "Peter", "Ralitsa", "Stephan", "Boqna", "Andon", "Julian", "Plamen", "George" };
            List<int> money = new List<int>() { 205, 240, 280, 260, 250, 430, 305, 300 };
            Console.WriteLine(string.Join(",", money.OrderByDescending(x => x)));
            List<int> age = new List<int>() { 22, 33, 44, 55, 66, 77, 88, 99 };
            int length = Math.Min(friends.Count, money.Count);
            Dictionary<string, int> namesAndAges = new Dictionary<string, int>();
            Dictionary<string, Dictionary<string, int>> namesAndFriends = new Dictionary<string, Dictionary<string, int>>();

            int count = 0;
            int count1 = 1;
            foreach (var name in names)
            {
                namesAndAges[name] = age[count];
                count++;

                for (int i = 0; i < length; i++)
                {
                    if (namesAndFriends.ContainsKey(name) == false)
                    {
                        namesAndFriends[name] = new Dictionary<string, int>();

                        if (namesAndFriends[name].ContainsKey(friends[i]) == false)
                        {
                            namesAndFriends[name].Add(friends[i], (money[i] + count1++));
                        }
                        else
                        {
                            namesAndFriends[name][friends[i]] += (money[i] + count1++);
                        }
                    }
                    else
                    {
                        if (namesAndFriends[name].ContainsKey(friends[i]) == false)
                        {

                            namesAndFriends[name].Add(friends[i], (money[i] + count1++));
                        }
                        else
                        {
                            namesAndFriends[name][friends[i]] += (money[i] + count1++);

                        }
                    }
                }
            }

            foreach (var item in namesAndAges.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{item.Key} {item.Value}");
            }

            foreach (var name in namesAndFriends.OrderByDescending(x => x.Value.Values.Min()))
            {
                Console.WriteLine($"{name.Key} is {namesAndAges[name.Key]} old");
                foreach (var friendsNameAndAge in name.Value)
                {
                    Console.WriteLine($"\t{friendsNameAndAge.Key} : {friendsNameAndAge.Value}");
                }
            }

            string worldCupStars = "Maradona 99 Poulinio 88 Junior 77 Angel 66 Bentley 55 Simon 44 Rachel 33 Paul 22";
            string patter = @"(?<name>[A-Z][a-z]+)+\s(?<age>\d+)+";
            Regex rgx = new Regex(patter);
            Dictionary<string, int> theStarts = new Dictionary<string, int>();
            MatchCollection namesAndAgesOfStarts = rgx.Matches(worldCupStars);
            foreach (Match nameAndAge in namesAndAgesOfStarts)
            {
                theStarts.Add(nameAndAge.Groups["name"].Value, int.Parse(nameAndAge.Groups["age"].Value));
            }
            Console.WriteLine("The start from the World Cup Dictionary are:");
            foreach (var item in theStarts)
            {
                Console.WriteLine($"Name: {item.Key}, Age: {item.Value}");
            }

            string text = "plamen___hristov";
            string textToPlacehoder = "antonov";
            int myNumber = 3;
            string pattern = $@"([A-Za-z]+)(?<placeholder>[^A-Za-z0-9]{{{myNumber}}})([A-Za-z])";
            Regex rgx1 = new Regex(pattern);

            Match theMatch = rgx.Match(text);
            int count2 = 0;
            string firstName = theMatch.Groups[1].ToString();
            string lastName = theMatch.Groups[2].ToString();
            firstName = FirstLetterToUpper(firstName);
            lastName = FirstLetterToUpper(lastName);
            textToPlacehoder = FirstLetterToUpper(textToPlacehoder);
            Console.WriteLine(theMatch.Groups["placeholder"].Value);
            
        }

        static string FirstLetterToUpper(string str)
        {
            string result = string.Empty;
            for (int i = 0; i < str.Length; i++)
            {
                if (i == 0)
                {
                    result += str[i].ToString().ToUpper();
                }
                else
                {
                    result += str[i];
                }
            }
            return result;

        }
    }
}

