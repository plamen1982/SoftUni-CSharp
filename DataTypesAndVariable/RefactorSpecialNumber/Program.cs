using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorSpecialNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum;
            int currentIndex;
            bool result = false;

            for (int i = 1; i < n; i++)
            {
                sum = 0;
                currentIndex = i;

                while (currentIndex > 0)
                {
                    sum += currentIndex % 10;
                    currentIndex = currentIndex / 10;
                }

                result = (sum == 5) || (sum == 7) || (sum == 11);

                Console.WriteLine($"{i} -> {result}");
                
            }
        }
    }
}
