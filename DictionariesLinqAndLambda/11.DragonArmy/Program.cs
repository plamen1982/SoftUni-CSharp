using System;
using System.Collections.Generic;

namespace _11.DragonArmy
{
    class Program
    {
        static void Main(string[] args)
        {
            //Types dragon, Name dragon
            //Damage, Health, Armor
            //Categories by type
            //Default values 250, 45, 10 
            //EX: 
            //Red Bazgargal 100 2500 25

            int n = int.Parse(Console.ReadLine());
            Dictionary<string, SortedDictionary<string, List<double>>> dragons = new Dictionary<string, SortedDictionary<string, List<double>>>();

            while (n-- > 0)
            {
                string[] tokens = Console.ReadLine().Split();
                string typeDragon = tokens[0];
                string nameDragon = tokens[1];
                double dagamge = tokens[2].Equals("null") ? 45 : double.Parse(tokens[2]);
                double health = tokens[3].Equals("null") ? 250 : double.Parse(tokens[3]);
                double armor = tokens[4].Equals("null") ? 10 : double.Parse(tokens[4]);

                List<double> stats = new List<double>(3);
                stats.Add(dagamge);
                stats.Add(health);
                stats.Add(armor);

                if (dragons.ContainsKey(typeDragon) == false)
                {
                    dragons[typeDragon] = new SortedDictionary<string, List<double>>();
                    if (dragons[typeDragon].ContainsKey(nameDragon) == false)
                    {
                        dragons[typeDragon][nameDragon] = new List<double>();
                    }
                    dragons[typeDragon][nameDragon] = stats;
                }
                else
                {
                    if (dragons[typeDragon].ContainsKey(nameDragon) == false)
                    {
                        dragons[typeDragon][nameDragon] = new List<double>();
                    }
                    dragons[typeDragon][nameDragon] = stats;
                }

            }

            foreach (var dragon in dragons)
            {
                double averageDamage = 0;
                double averageHealth = 0;
                double averageArmor = 0;

                foreach (var nameDragon in dragon.Value)
                {
                    averageDamage += nameDragon.Value[0];
                    averageHealth += nameDragon.Value[1];
                    averageArmor += nameDragon.Value[2];
                }

                Console.WriteLine($"{dragon.Key}::({(averageDamage / dragon.Value.Count):F2}/{(averageHealth / dragon.Value.Count):F2}/{(averageArmor / dragon.Value.Count):F2})");
                foreach (var nameDragon in dragon.Value)
                {
                    Console.WriteLine($"-{nameDragon.Key} -> damage: {nameDragon.Value[0]}, health: {nameDragon.Value[1]}, armor: {nameDragon.Value[2]}");
                }
            }
        }
    }
}
