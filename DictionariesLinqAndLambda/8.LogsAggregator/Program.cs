using System;
using System.Collections.Generic;
using System.Linq;

namespace _8.LogsAggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> logsAggregator = new Dictionary<string, Dictionary<string, int>>();
            while (n-- > 0)
            {
                string[] inputLogs = Console.ReadLine().Split();
                string ip = inputLogs[0];
                string name = inputLogs[1];
                int logs = int.Parse(inputLogs[2]);

                if (logsAggregator.ContainsKey(name) == false)
                {
                    logsAggregator[name] = new Dictionary<string, int>();
                    if (logsAggregator[name].ContainsKey(ip) == false)
                    {
                        logsAggregator[name][ip] = logs;
                    }
                    else
                    {
                        logsAggregator[name][ip] += logs;

                    }
                }
                else
                {
                    if (logsAggregator[name].ContainsKey(ip) == false)
                    {
                        logsAggregator[name][ip] = logs;
                    }
                    else
                    {
                        logsAggregator[name][ip] += logs;

                    }
                }


            }
            //name = {"peter" : {"ip": 4}}
            foreach (var name in logsAggregator.OrderBy(x => x.Key))
            {
                Console.Write($"{name.Key}: ");
                //name.value = {ip: 4}
                int sum = 0;
                foreach (var ip in name.Value)
                {
                    sum += ip.Value;
                }
                Console.Write($"{sum} [");
                Console.Write(string.Join(", ", name.Value.OrderBy(x => x.Key).ToDictionary(e => e.Key, e => e.Value).Keys));
                Console.WriteLine("]");

            }

        }
    }
}
