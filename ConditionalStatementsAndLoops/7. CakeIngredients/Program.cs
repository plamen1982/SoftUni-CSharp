using System;

namespace _7._CakeIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            string ingredient = "";

            for (int i = 0; i <= 20; i++) {
                ingredient = Console.ReadLine();
                if (ingredient == "Bake!")
                {
                    Console.WriteLine($"Preparing cake with {count} ingredients.");
                    return;
                }

                else
                {
                    count++;
                    Console.WriteLine($"Adding ingredient {ingredient}.");
                }        
            }
        }
    }
}
