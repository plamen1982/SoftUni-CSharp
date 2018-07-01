using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace SoftUniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = string.Empty;
            string pattern = @"%([A-Z][a-z]+)+%<(\w+)>\|(\d+)\|(\d+\.\d+)\$";
            //customer, product, count and a price
            //group 1 - customer
            //group 2 - product
            //group 3 - count
            //group 4 - price

            Regex rgx = new Regex(pattern);
            decimal totalPrice = 0;
            decimal totalIncome = 0;
            while ((line = Console.ReadLine())!= "end of shift")
            {
                MatchCollection matches = rgx.Matches(line);
                foreach (Match match in matches)
                {
                    if (match.Success)
                    {
                        totalPrice = decimal.Parse(match.Groups[3].Value) * decimal.Parse(match.Groups[4].Value);
                    }
                    totalIncome += totalPrice;
                    Console.WriteLine($"{ match.Groups[1].Value }: { match.Groups[2].Value} - {totalPrice:F2}");
                }
                //For each valid line print on the console: "{customerName}: {product} - {totalPrice}"
            }
            Console.WriteLine($"Total income: {totalIncome:F2}");
        }
    }
}
