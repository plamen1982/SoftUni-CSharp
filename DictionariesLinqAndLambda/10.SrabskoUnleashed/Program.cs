using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text.RegularExpressions;

namespace _10.SrabskoUnleashed
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> statisticsChalga = new Dictionary<string, Dictionary<string, long>>();

            string pattern = @"(\w+(?: \w+)*) @(\w+(?: \w+)*) (\d+) (\d+)";
            Regex regex = new Regex(pattern);

            while (true)
            {
                string inputInfo = Console.ReadLine();


                string[] inputData = inputInfo.Split('@');
                string singer = inputData[0];

                if (singer == "End")
                {
                    break;
                }

                if (!regex.IsMatch(inputInfo))
                {
                    continue;
                }

                string[] placeAndMoney = inputData[1].Split();



                int moneyForTicket = int.Parse(placeAndMoney[placeAndMoney.Length - 2]);
                int seats = int.Parse(placeAndMoney[placeAndMoney.Length - 1]);
                string place = "";

                if (placeAndMoney.Length == 4)
                {
                    place = placeAndMoney[0] + ' ' + placeAndMoney[1];
                }

                else if (placeAndMoney.Length == 5)
                {
                    place = placeAndMoney[0] + ' ' + placeAndMoney[1] + ' ' + placeAndMoney[2];
                }


                else if (placeAndMoney.Length == 3)
                {
                    place = placeAndMoney[0];
                }
                if (statisticsChalga.ContainsKey(place) == false)
                {
                    statisticsChalga[place] = new Dictionary<string, long>();

                    if (statisticsChalga[place].ContainsKey(singer) == false)
                    {
                        statisticsChalga[place][singer] = seats * moneyForTicket;

                    }

                }
                else
                {
                    if (statisticsChalga[place].ContainsKey(singer) == false)
                    {
                        statisticsChalga[place][singer] = seats * moneyForTicket;
                    }

                    else
                    {
                        statisticsChalga[place][singer] += seats * moneyForTicket;
                    }
                }
            }

            //statisticsChalga = {"Sunny Beach" , {"Lepa Brena", 30000}}

            foreach (var place in statisticsChalga)
            {
                Console.WriteLine(place.Key);
                foreach (var signer in place.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {signer.Key}-> {signer.Value}");
                }
            }
        }
    }
}
