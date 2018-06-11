using System;
using System.Collections.Generic;

namespace _3.MinerTask
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, long> minerCollection = new Dictionary<string, long>();  

            while (true)
            {
                string mineral = Console.ReadLine();
                if (mineral == "stop")
                {
                    break;
                }
                long value = long.Parse(Console.ReadLine());

                if (minerCollection.ContainsKey(mineral))
                {
                    minerCollection[mineral] += value;
                }
                else
                {
                    minerCollection[mineral] = value;
                }
            }
            foreach (KeyValuePair<string, long> miner in minerCollection)
            {
                Console.WriteLine($"{miner.Key} -> {miner.Value}");
            }

        }
    }
}
