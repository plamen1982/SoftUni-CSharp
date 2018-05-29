using System;

namespace _11.PriceChangeAlert
{
    class Program
    {
        static void Main(string[] args)
        {

            int numberOfPrices = int.Parse(Console.ReadLine()); 
            double limitPrice = double. Parse(Console.ReadLine()); 
            double lastPrice = double.Parse(Console.ReadLine()); 

        for (int i = 0; i < numberOfPrices - 1; i++)
            {

                double currentPrice = double.Parse(Console.ReadLine()); 
                double differenceInPrices = ProccessingPrice(lastPrice, currentPrice);
                bool isSignificantDifference = isThereADifference(differenceInPrices, limitPrice);
                string message = GetMessage(currentPrice, lastPrice, differenceInPrices, isSignificantDifference);

                Console.WriteLine(message);

                lastPrice = currentPrice;

            }  
        }

        private static string GetMessage(double currentPrice, double lastPrice, double differenceInPrices, bool isSignificantDifference)
            {
                string message = "";

                if (differenceInPrices == 0)
                {
                    message = string.Format("NO CHANGE: {0}", currentPrice);
                }
                else if (!isSignificantDifference)
                {
                    message = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, differenceInPrices*100);
                }
                else if (isSignificantDifference && (differenceInPrices > 0))
                {
                    message = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, differenceInPrices*100);
                }
                else if (isSignificantDifference && (differenceInPrices < 0))
                {
                    message = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, differenceInPrices*100);
                }

                return message;
            }

        private static bool isThereADifference(double differenceInPrices, double limitPrice)
        {
            if (Math.Abs(differenceInPrices) >= limitPrice)
            {
                return true;
            }
            return false;
        }

        private static double ProccessingPrice(double lastPrice, double currentPrice)
        {
            double result = (currentPrice - lastPrice) / lastPrice;
            return result;
        }
    }
}
