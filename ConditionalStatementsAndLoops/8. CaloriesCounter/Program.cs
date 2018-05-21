using System;

namespace _8._CaloriesCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            string ingridients = "";
            int calories = 0;
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)

            {
                ingridients = Console.ReadLine().ToLower();
                switch (ingridients)
                {
                    case "cheese":
                        calories += 500;
                        break;
                    case "tomato sauce":
                        calories += 150;
                        break;
                    case "salami":
                        calories += 600;
                        break;
                    case "pepper":
                        calories += 50;
                        break;
                }
            
            }
            Console.WriteLine($"Total calories: {calories}");
        }
    }
}
