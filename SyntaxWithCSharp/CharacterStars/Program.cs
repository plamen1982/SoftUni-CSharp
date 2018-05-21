using System;

namespace CharacterStars
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int diffHealth = maxHealth - currentHealth;

            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());
            int diffEnergy = maxEnergy - currentEnergy;

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Health: |{new string('|', currentHealth)}{new string('.', diffHealth)}|");
            Console.WriteLine($"Energy: |{new string('|', currentEnergy)}{new string('.', diffEnergy)}|");
        }
    }
}
