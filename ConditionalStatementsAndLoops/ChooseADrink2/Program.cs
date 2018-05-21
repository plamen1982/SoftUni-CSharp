using System;

namespace ChooseADrink2
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            string drink = "";
            int quantities = int.Parse(Console.ReadLine());
            double totalPrice;

            switch (profession) {
                case "Athlete":
                    drink = "Water";
                    totalPrice = quantities * 0.70;
                    Console.WriteLine($"The {profession} has to pay {totalPrice:F2}.");
                    break;

                case "Businessman":
                    drink = "Coffee";
                    totalPrice = quantities * 1.00;
                    Console.WriteLine($"The {profession} has to pay {totalPrice:F2}.");
                    break;

                case "Businesswoman":
                    drink = "Coffee";
                    totalPrice = quantities * 1.00;
                    Console.WriteLine($"The {profession} has to pay {totalPrice:F2}.");
                    break;

                case "SoftUni Student":
                    drink = "Beer";
                    totalPrice = quantities * 1.70;
                    Console.WriteLine($"The {profession} has to pay {totalPrice:F2}.");
                    break;

                default:
                    drink = "Tea";
                    totalPrice = quantities * 1.20;
                    Console.WriteLine($"The {profession} has to pay {totalPrice:F2}.");
                    break;

            }
        }
    }
}
