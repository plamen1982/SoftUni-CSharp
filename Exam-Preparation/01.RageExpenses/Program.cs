using System;

namespace _01.RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            decimal headsetPrice = decimal.Parse(Console.ReadLine());
            decimal mousePrice = decimal.Parse(Console.ReadLine());
            decimal keyboardPrice = decimal.Parse(Console.ReadLine());
            decimal displayPrice = decimal.Parse(Console.ReadLine());

            int countHeadest = lostGames / 2;
            int countMouses = lostGames / 3;
            int countKeyboard = lostGames / 6;
            int countDisplay = lostGames / 12;

            decimal rageExpenses = headsetPrice * countHeadest + mousePrice * countMouses + keyboardPrice * countKeyboard + displayPrice * countDisplay;
            Console.WriteLine($"Rage expenses: {rageExpenses:F2} lv.");
        }
    }
}
