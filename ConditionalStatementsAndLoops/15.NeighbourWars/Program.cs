using System;

namespace _15.NeighbourWars
{
    class Program
    {
        static void Main(string[] args)
        {
            int peshoDamage = int.Parse(Console.ReadLine());
            int goshoDamage = int.Parse(Console.ReadLine());

            int peshoHealth = 100;
            int goshoHealth = 100;

            int round = 0;

            while (peshoHealth > 0 && goshoHealth > 0)
            {

                round++;
                goshoHealth -= peshoDamage;

                if (goshoHealth > 0)
                {
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHealth} health.");

                }
                else
                {
                    break;
                }

                if (round % 3 == 0)
                {
                    goshoHealth += 10;
                    peshoHealth += 10;
                }




                round++;
                peshoHealth -= goshoDamage;

                if (peshoHealth > 0)
                {
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHealth} health.");

                }
                else
                {
                    break;
                }
                if (round % 3 == 0)
                {
                    goshoHealth += 10;
                    peshoHealth += 10;
                }


            }

            if (peshoHealth <= 0)
            {
                Console.WriteLine($"Gosho won in {round}th round.");
            }
            else if (goshoHealth <= 0)
            {
                Console.WriteLine($"Pesho won in {round}th round.");

            }
        }
    }
}
