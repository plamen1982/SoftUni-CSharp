using System;

namespace RestaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            string discount = Console.ReadLine();
            string hall = "";
            double price = 0;
            double pricePerPerson;

            if (numberOfPeople > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }

            if (numberOfPeople > 0 && numberOfPeople <= 50)
            {
                price = 2500;
                hall = "Small Hall";
            }

            else if (numberOfPeople <= 100)
            {
                price = 5000;
                hall = "Terrace";
            }

            else if (numberOfPeople <= 120)
            {
                price = 7500;
                hall = "Great Hall";
            }

            if (discount == "Normal")
            {
                price += 500;
                price -= price * 0.05;
            }

            else if (discount == "Gold")
            {
                price += 750;
                price -= price * 0.10;
            }

            else if (discount == "Platinum")
            {
                price += 1000;
                price -= price * 0.15;
            }

            pricePerPerson = price / numberOfPeople;

            Console.WriteLine($"We can offer you the {hall}");
            Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
        }
    }
}
