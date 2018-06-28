using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.AnonymousCache
{
    class Program
    {
        public static object MatchColltion { get; private set; }

        static void Main(string[] args)
        {
            //You will receive several input lines in one of the following formats:
            //•	{ dataSet}
            //•	{ dataKey} -> { dataSize} | { dataSet}
            //The dataSet and dataKey are both strings.The dataSize is an integer. The dataSets hold dataKeys and their dataSizes.

            string line = string.Empty;
            Dictionary<string, Dictionary<string, long>> mainSet = new Dictionary<string, Dictionary<string, long>>();
            Dictionary<string, Dictionary<string, long>> cache = new Dictionary<string, Dictionary<string, long>>();

            while ((line = Console.ReadLine())!="thetinggoesskrra")
            {
                string[] tokens = line.Split(new char[] { '-', '>', ' ', '|' }, StringSplitOptions.RemoveEmptyEntries);
                string set = tokens.Length == 3 ? tokens[2] : tokens[0];
                string key = tokens.Length == 3 ? tokens[0] : "";
                long size = tokens.Length == 3 ? long.Parse(tokens[1]) : 0;
                //Console.WriteLine(set);
                //Console.WriteLine(string.Join(',', tokens));

                if (tokens.Length == 3)
                {
                    if (mainSet.ContainsKey(set) == false)
                    {
                        if (cache.ContainsKey(set) == false)
                        {
                            cache[set] = new Dictionary<string, long>();
                            cache[set].Add(key, size);
                        }
                        else
                        {
                            cache[set].Add(key, size);
                        }
                    }
                    else
                    {
                        mainSet[set].Add(key, size);
                    }
                }
                else if(tokens.Length == 1)
                {
                    if (mainSet.ContainsKey(set) == false)
                    {
                        mainSet[set] = new Dictionary<string, long>();
                    }

                    if (cache.ContainsKey(set) == false)
                    {
                        continue;
                    }
                    else
                    {
                        mainSet[set] = cache[set];
                    }
                }
            }

            //•	As output you must print the dataSet with the HIGHEST SUM of all dataSizes.
            //•	The output format is:
            //Data Set: { dataSet}, Total Size: { sumOfAllDataSizes}
            //$.{ dataKey1}
            //$.{ dataKey2}
            var theHighestSize = mainSet.OrderByDescending(x => x.Value.Values.Sum()).First();
            long sum = 0;
            if (theHighestSize.Value.Values.Count > 0)
            {
                foreach (var item in theHighestSize.Value)
                {
                    sum += item.Value;
                }
                Console.WriteLine($"Data Set: {theHighestSize.Key}, Total Size: {sum}");
                foreach (var item in theHighestSize.Value)
                {
                    Console.WriteLine($"$.{item.Key}");
                }
            }
        }
    }
}
