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
            Dictionary<string, int> languageSubmission = new Dictionary<string, int>(); //sumbission
            Dictionary<string, long> languagePoints = new Dictionary<string, long>(); // points
            Dictionary<string, string> languageName = new Dictionary<string, string>(); //name

            while ((line = Console.ReadLine()) != "exam finished")
            {
                string[] tokens = line.Split('-');
                //Pesho-Java-84
                //Results: { username} | { points}
                //Submission: {language} – {submissionsCount}
                string name = tokens[0];
                //Console.WriteLine();
                if (tokens.Length == 3)
                {
                    string language = tokens[1];
                    long points = long.Parse(tokens[2]);
                    if (languageSubmission.ContainsKey(language) == false)
                    {
                        languageSubmission[language] = 0;
                        languageSubmission[language]++;
                    }
                    else
                    {
                        languageSubmission[language]++;
                    }

                    if (languagePoints.ContainsKey(language) == false)
                    {
                        languagePoints[language] = points;
                    }
                    else
                    {
                        languagePoints[language] = Math.Max(languagePoints[language], points);
                    }



                }
                else if (tokens.Length == 2)
                {
                    string nameToBanned = tokens[0];
                    string banned = tokens[1];

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
                    Console.WriteLine($"{item.Key} | {item.Value}");
                }
            }
            Console.WriteLine("Submissions:");
            foreach (var item in languageSubmission.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
