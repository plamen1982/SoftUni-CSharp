using System;
using System.Numerics;
using System.Text;

namespace _1.AnonymousDownsite
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfWebSites = int.Parse(Console.ReadLine());
            int securityKey = int.Parse(Console.ReadLine());
            
            decimal totalLoss = 0;
            StringBuilder webSites = new StringBuilder();

            for (int i = 0; i < numberOfWebSites; i++)
            {
                //read the input separated by " "
                string[] input = Console.ReadLine().Split();
                webSites.AppendLine(input[0]);
                totalLoss += decimal.Parse(input[1]) * decimal.Parse(input[2]);
            }


            Console.Write(webSites);           
            Console.WriteLine($"Total Loss: {totalLoss:f20}");
            Console.WriteLine($"Security Token: {BigInteger.Pow(new BigInteger(securityKey), numberOfWebSites)}");

        }
    }
}
