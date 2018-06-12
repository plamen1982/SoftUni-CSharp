using System;

namespace _2.AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] phrases = 
                {
                "Such a great product.",
                "Now I feel good.",
                "Excelent product. Makes miracles.",
                "I am happy of the results!",
                "Best product of its category.",
                "That makes miracles."
            };
            string[] events = {
                "Now I feel good.",
                "I have succeeded with this product.",
            "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
            "Try it yourself, I am very satisfied.",
                "I feel great!"
            };

            string[] authors = new string[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            Random rnd = new Random();
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                string phrase = phrases[rnd.Next(0, phrases.Length - 1)];
                string @event = events[rnd.Next(0, events.Length - 1)];
                string author = authors[rnd.Next(0, authors.Length - 1)];
                string city = cities[rnd.Next(0, cities.Length - 1)];

                Console.WriteLine($"{phrase} {@event} {author} - {city}");
            }
        }
    }
}
