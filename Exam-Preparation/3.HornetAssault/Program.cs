using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.HornetAssault
{
    class Program
    {
        static void Main(string[] args)
        {

            List<long> beehives = Console.ReadLine().Split().Select(long.Parse).ToList();
            List<long> hornets = Console.ReadLine().Split().Select(long.Parse).ToList();

            for (int i = 0; i < beehives.Count; i++)
            {
                long sum = hornets.Sum();
                if (beehives[i] < sum)
                {

                    beehives[i] = 0;
                }

                else if (beehives[i] == sum)
                {

                    beehives[i] = 0;
                    if (hornets.Count > 0)
                    {
                        hornets.RemoveAt(0);
                    }
                    else
                    {
                        break;
                    }
                }

                else
                {
                    beehives[i] = beehives[i] - sum;
                    if (hornets.Count > 0)
                    {
                        hornets.RemoveAt(0);
                    }
                    else
                    {
                        break;
                    }
                }

            }
            if (beehives.Sum() > 0)
            {
                List<long> print = new List<long>();
                print = beehives.Where(x => x != 0).ToList();
                Console.WriteLine(string.Join(" ", print));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornets));

            }
        }
    }
}
