using System;
using System.Collections.Generic;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = new List<int>(1);
            //Red Bazgargal 100 2500 25
            Dictionary<string, Dictionary<string, List<int>>> dragons = new Dictionary<string, Dictionary<string, List<int>>>();
            Dictionary<string, int> testDragons = new Dictionary<string, int>();

            int damage = 100;
            int health = 2500;
            int armor = 30;

            List<int> stats = new List<int> { damage, health, armor };

            string typeDragon = "Red";
            string nameDragon = "Bazgargal";

            if (testDragons.ContainsKey(typeDragon) == false)
            {
                //testDragons[typeDragon] = damage;
                testDragons.Add(typeDragon, damage);
            }


            if (dragons.ContainsKey(typeDragon) == false)
            {
                dragons[typeDragon] = new Dictionary<string, List<int>>();

                if (dragons[typeDragon].ContainsKey(nameDragon) == false)
                {
                    dragons[typeDragon][nameDragon] = new List<int>();
                }

                dragons[typeDragon][nameDragon] = stats;
            }
            foreach (var dragon in dragons)
            {
                foreach (var name in dragon.Value)
                {
                    foreach (var stat in name.Value)
                    {
                        Console.WriteLine(stat);
                    }
                }
            }
        }
    }
}
