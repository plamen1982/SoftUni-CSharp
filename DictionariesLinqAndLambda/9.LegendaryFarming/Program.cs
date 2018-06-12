using System;
using System.Collections.Generic;
using System.Linq;

namespace _9.LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            //Shards, Fragments and Motes 
            //•	Shadowmourne – requires 250 Shards;
            //•	Valanyr – requires 250 Fragments;
            //•	Dragonwrath – requires 250 Motes;
            bool tryGetData = true;
            Dictionary<string, int> materials = new Dictionary<string, int>()
            {
                {"shards", 0 },
                {"fragments", 0 },
                {"motes", 0 }
            };

            Dictionary<string, int> junkMaterials = new Dictionary<string, int>();
            string printMaterial = "";

            while (tryGetData)
            {
                string[] input = Console.ReadLine().ToLower().Split();

                for (int i = 0; i < input.Length; i += 2)
                {
                    string material = input[i + 1];
                    int value = int.Parse(input[i]);


                    if (materials.ContainsKey(material))
                    {
                        //materials = {"fragments": 255}
                        materials[material] += value;
                        if (materials[material] >= 250)
                        {
                            printMaterial = material;
                            materials[material] = materials[material] - 250; 
                            tryGetData = false;
                            break;

                        }
                    }
                    else
                    {
                        if (junkMaterials.ContainsKey(material) == false)
                        {
                            junkMaterials[material] = value;
                        }
                        else
                        {
                            junkMaterials[material] += value;
                        }
                    }
                }
            }

            switch (printMaterial)
            {
                case "shards":
                    Console.WriteLine("Shadowmourne obtained!");
                    break;
                case "fragments":
                    Console.WriteLine("Valanyr obtained!");
                    break;
                case "motes":
                    Console.WriteLine("Dragonwrath obtained!");
                    break;

                default:
                    break;
            }

            foreach (var material in materials.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }
            foreach (var junk in junkMaterials.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{junk.Key}: {junk.Value}");

            }
        }
    }
}
