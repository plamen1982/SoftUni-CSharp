using System;

namespace BevaregeLabels
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int volume = int.Parse(Console.ReadLine());
            int energyContent = int.Parse(Console.ReadLine());
            int sugarContent = int.Parse(Console.ReadLine());

            double kiloCalories = (Convert.ToDouble(volume) * Convert.ToDouble(energyContent)) / 100;
            double sugar = (Convert.ToDouble(volume) * Convert.ToDouble(sugarContent)) / 100;

            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{kiloCalories}kcal, {sugar}g sugars");

        }
    }
}
