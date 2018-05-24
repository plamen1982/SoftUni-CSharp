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

            for (int i = 1; i < n; i++)
            {
                int sum = 0;
                int currentIndex = i;

                while (currentIndex > 0)
                {
                    sum += currentIndex % 10;
                    currentIndex = currentIndex / 10;
                }

                bool result = (sum == 5) || (sum == 7) || (sum == 11);

                Console.WriteLine($"{i} -> {result}");


            }
        }
    }
}
