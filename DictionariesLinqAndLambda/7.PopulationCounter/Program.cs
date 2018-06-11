using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.PopulationCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read input
            //Dictionry Contry and city
            //Dictionary Country and population 
            //Fill Dictionaries
            //Sort OrderBeyDescanding countries
            //Sort cities
            //Print



            Dictionary<string, long> countriesAndPopulation = new Dictionary<string, long>();
            Dictionary<string, Dictionary<string, long>> countriesAndCities = new Dictionary<string, Dictionary<string, long>>();

            while (true)
            {
                string[] inputTokens = Console.ReadLine().Split('|');
                string city = inputTokens[0];

                if (city == "report")
                {
                    break;
                }

                string country = inputTokens[1];
                long population = long.Parse(inputTokens[2]);

                if (countriesAndCities.ContainsKey(country) == false)
                {
                    countriesAndCities.Add(country, new Dictionary<string, long>());
                    countriesAndPopulation.Add(country, 0);
                }

                countriesAndCities[country].Add(city, population);
                countriesAndPopulation[country] += population;

            }
            foreach (var country in countriesAndPopulation.OrderByDescending(c => c.Value))
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value})");
                Dictionary<string, long> cities = countriesAndCities[country.Key].OrderByDescending(x => x.Value).ToDictionary(element => element.Key, element => element.Value);
                foreach (var city in cities)
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");

                }
            }
        }
    }
}
