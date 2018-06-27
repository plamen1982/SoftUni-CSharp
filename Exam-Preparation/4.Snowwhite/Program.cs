using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _4.Snowwhite
{
    class Program
    {
        static void Main(string[] args)
        {
                //{dwarfName} <:> {dwarfHatColor} <:> {dwarfPhysics}

                //Rules•If 2 dwarfs have the same name but different color, they should be considered different dwarfs, and you should store both of them.
                //•If 2 dwarfs have the same name and the same color, store the one with the higher physics.


                Dictionary<string, Dictionary<string, BigInteger>> dwarfs = new Dictionary<string, Dictionary<string, BigInteger>>();

            string line = string.Empty;
            while ((line = Console.ReadLine()) != "Once upon a time")
            {
                    string[] tokens = line.Split("<:> ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    string name = tokens[0];
                    string color = tokens[1];
                    BigInteger physics = BigInteger.Parse(tokens[2]);

                if (dwarfs.ContainsKey(color) == false)
                {
                    dwarfs[color] = new Dictionary<string, BigInteger>();
                    dwarfs[color].Add(name, physics);
                }
                else
                {
                    if (dwarfs[color].ContainsKey(name) == false)
                    {
                        dwarfs[color].Add(name, physics);
                    }
                    else
                    {
                        dwarfs[color][name] = BigInteger.Max(dwarfs[color][name], physics);
                    }
                }
            }

            //Print: You must order the dwarfs by physics in descending order - ok and then ---- by total count of dwarfs with the same hat color in descending order. 
            //Then you must print them all.  •	The output format is: ({hatColor}) {name} <-> {physics}

            // [color: [{name: 20},{name: 40}]]
            foreach (var color in dwarfs.OrderByDescending(x => x.Value.Values.Max()).ThenByDescending(x => x.Value.Values.Count()))
            {
                foreach (var dwarf  in color.Value.OrderByDescending(x => x.Key))
                {
                    Console.Write($"({color.Key}) ");
                    Console.WriteLine($"{dwarf.Key} <-> {dwarf.Value}");
                }
            }
        }
    }
}
