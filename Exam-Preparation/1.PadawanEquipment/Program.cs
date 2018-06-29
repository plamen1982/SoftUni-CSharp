using System;

namespace _1.PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            decimal numberOfStudents = int.Parse(Console.ReadLine());
            decimal priceLightSabers = decimal.Parse(Console.ReadLine());
            decimal priceOfRobes = decimal.Parse(Console.ReadLine());
            decimal priceOfBelts = decimal.Parse(Console.ReadLine());

            decimal studentsCountForLightSabers = numberOfStudents + Math.Ceiling(numberOfStudents * (decimal)0.1);
            decimal totalPriceLightSabers = studentsCountForLightSabers * priceLightSabers;
            int freeBelts = (int)numberOfStudents / 6;
            decimal totalPriceRobes = numberOfStudents * priceOfRobes;
            decimal totalPriceBelts = numberOfStudents * priceOfBelts - freeBelts * priceOfBelts;
            decimal totalPrice = totalPriceLightSabers + totalPriceBelts + totalPriceRobes;

            if (totalPrice <= budget)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {Math.Abs(budget - totalPrice):F2}lv more.");
            }
        }
    }
}
