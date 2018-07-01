using System;
using System.Linq;
using System.Collections.Generic;

namespace SoftUniExamResults
{
    class Program
    {

        static void Main(string[] args)
        {
            string line = string.Empty;
            //language, name, points
            Dictionary<string, Dictionary<string, long>> results = new Dictionary<string, Dictionary<string, long>>();
            Dictionary<string, int> submissions = new Dictionary<string, int>();
            List<string> bannedNames = new List<string>();

            while ((line = Console.ReadLine()) != "exam finished")
            {
                string[] tokens = line.Split('-');
                //Pesho-Java-84
                //Results: { username} | { points}
                //Submission: {language} – {submissionsCount}
                string name = tokens[0];
                string language = tokens[1];
                //Console.WriteLine();
                if (tokens.Length == 3)
                {
                    long points = long.Parse(tokens[2]);

                    if (results.ContainsKey(language) == false)
                    {
                        if (submissions.ContainsKey(language) == false)
                        {
                            submissions[language] = 0;
                            submissions[language]++;
                        }
                        else
                        {
                            submissions[language]++;
                        }
                        results[language] = new Dictionary<string, long>();
                        if (results[language].ContainsKey(name) == false)
                        {
                            results[language].Add(name, points);
                        }
                        else
                        {
                            results[language][name] = Math.Max(results[language][name], points);
                        }

                    }
                    else
                    {
                        submissions[language]++;
                        if (results[language].ContainsKey(name) == false)
                        {
                            results[language].Add(name, points);
                        }
                        else
                        {
                            results[language][name] = Math.Max(results[language][name], points);
                        }
                    }
                }

                else if (tokens.Length == 2)
                {
                    bannedNames.Add(tokens[0]);
                }
            }
            Console.WriteLine();
            //You can receive a command to ban a user for cheating in the following format: "{username}-banned". 
            //In that case, you should remove the user from the contest
            Console.WriteLine("Results:");
            foreach (var result in results.OrderByDescending(x => x.Value.Values.Max()).ThenBy(x => x.Value.Keys))
            {//Results:
                foreach (var item in result.Value.OrderByDescending(x => x.Value))
                {
                    if (bannedNames.Count > 0)
                    {
                        foreach (var bannedName in bannedNames)
                        {
                            if (bannedName != item.Key)
                            {
                                Console.WriteLine($"{item.Key} | {item.Value}");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{item.Key} | {item.Value}");
                    }
                }
            }
            Console.WriteLine("Submissions:");
            foreach (var item in submissions.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
